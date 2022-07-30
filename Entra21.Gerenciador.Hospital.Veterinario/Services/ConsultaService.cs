using Entra21.Gerenciador.Hospital.Vet.Database;
using Entra21.Gerenciador.Hospital.Vet.Models;
using System.Data;

namespace Entra21.Gerenciador.Hospital.Vet.Services
{
    internal class ConsultaService : IConsultaService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "DELETE FROM consultas WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Cadastrar(Consulta consulta)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = @"INSERT INTO consultas (data_hora_consulta, observacao, id_veterinarios, id_pets)
VALUES (@DATA_HORA_CONSULTA, @OBSERVACAO, @ID_VETERINARIOS, @ID_PETS);";

            comando.Parameters.AddWithValue("@DATA_HORA_CONSULTA", consulta.DataHora);
            comando.Parameters.AddWithValue("@OBSERVACAO", consulta.Observacao);
            comando.Parameters.AddWithValue("@ID_VETERINARIOS", consulta.Veterinario.Id);
            comando.Parameters.AddWithValue("@ID_PETS", consulta.Pet.Id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Editar(Consulta consulta)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();
            comando.CommandText = @"UPDATE consultas SET data_hora_consulta = @DATA_HORA_CONSULTA, observacao = @OBSERVACAO, 
id_veterinarios = @ID_VETERINARIOS, id_pets = @ID_PETS WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", consulta.Id);
            comando.Parameters.AddWithValue("@DATA_HORA_CONSULTA", consulta.DataHora);
            comando.Parameters.AddWithValue("@OBSERVACAO", consulta.Observacao);
            comando.Parameters.AddWithValue("@ID_VETERINARIOS", consulta.Veterinario.Id);
            comando.Parameters.AddWithValue("@ID_PETS", consulta.Pet.Id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public Consulta ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT id, data_hora_consulta, observacao, id_veterinarios, id_pets FROM consultas WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            if (tabelaEmMemoria.Rows.Count == 0)
                return null;

            var registro = tabelaEmMemoria.Rows[0];

            var consulta = new Consulta();

            consulta.Id = Convert.ToInt32(registro["id"]);
            consulta.DataHora = Convert.ToDateTime(registro["data_hora_consulta"]).Date;
            consulta.Observacao = registro["observacao"].ToString();

            consulta.Veterinario = new Veterinario();
            consulta.Veterinario.Id = Convert.ToInt32(registro["id_veterinarios"]);

            consulta.Pet = new Pet();
            consulta.Pet.Id = Convert.ToInt32(registro["id_pets"]);

            comando.Connection.Close();

            return consulta;
        }

        public List<Consulta> ObterPorPet(string nomePet)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();
            comando.CommandText = @"SELECT
c.id AS 'id',
c.data_hora_consulta AS 'data_hora_consulta',
c.observacao AS 'observacao',
v.id AS 'id_veterinarios,
v.nome AS 'nome_veterinario',
p.id A 'id_pets',
p.nome AS 'nome_pet',
FROM consultas AS c
INNER JOIN veterinarios AS v ON(c.id_veterinarios = v.id)
INNER JOIN pets AS p ON(c.id_pets = p.id) 
WHERE nome_pet LIKE @NOME_PET";

            comando.Parameters.AddWithValue("@NOME_PET", $"%{nomePet}%");

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            var consultas = new List<Consulta>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];

                var consulta = new Consulta();

                consulta.Id = Convert.ToInt32(registro["id"]);
                consulta.DataHora = Convert.ToDateTime(registro["data_consulta"]).Date;
                consulta.Observacao = registro["observacao"].ToString();

                consulta.Veterinario = new Veterinario();
                consulta.Veterinario.Id = Convert.ToInt32(registro["id_veterinarios"]);
                consulta.Veterinario.Nome = registro["nome"].ToString();

                consulta.Pet = new Pet();
                consulta.Pet.Id = Convert.ToInt32(registro["id_pets"]);
                consulta.Pet.Nome = registro["nome"].ToString();

                consultas.Add(consulta);
            }

            comando.Connection.Close();

            return consultas;
        }

        public List<Consulta> ObterPorVeterinario(string nomeVeterinario)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();
            comando.CommandText = @"SELECT
c.id AS 'id',
c.data_hora_consulta AS 'data_hora_consulta',
c.observacao AS 'observacao',
v.id AS 'id_veterinarios,
v.nome AS 'nome_veterinario',
p.id A 'id_pets',
p.nome AS 'nome_pet',
FROM consultas AS c
INNER JOIN veterinarios AS v ON(c.id_veterinarios = v.id)
INNER JOIN pets AS p ON(c.id_pets = p.id) 
WHERE nome_veterinario LIKE @NOME_VETERINARIO";

            comando.Parameters.AddWithValue("@NOME_VETERINARIO", $"%{nomeVeterinario}%");

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            var consultas = new List<Consulta>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];

                var consulta = new Consulta();

                consulta.Id = Convert.ToInt32(registro["id"]);
                consulta.DataHora = Convert.ToDateTime(registro["data_consulta"]).Date;
                consulta.Observacao = registro["observacao"].ToString();

                consulta.Veterinario = new Veterinario();
                consulta.Veterinario.Id = Convert.ToInt32(registro["id_veterinarios"]);
                consulta.Veterinario.Nome = registro["nome"].ToString();

                consulta.Pet = new Pet();
                consulta.Pet.Id = Convert.ToInt32(registro["id_pets"]);
                consulta.Pet.Nome = registro["nome"].ToString();

                consultas.Add(consulta);
            }

            comando.Connection.Close();

            return consultas;
        }

        public List<Consulta> ObterTodos()
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();
            comando.CommandText = @"SELECT
c.id AS 'id',
c.data_hora_consulta AS 'data_hora_consulta',
c.observacao AS 'observacao',
v.id AS 'id_veterinarios,
v.nome AS 'nome_veterinario',
p.id A 'id_pets',
p.nome AS 'nome_pet',
FROM consultas AS c
INNER JOIN veterinarios AS v ON(c.id_veterinarios = v.id)
INNER JOIN pets AS p ON(c.id_pets = p.id)"; 

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            var consultas = new List<Consulta>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];

                var consulta = new Consulta();

                consulta.Id = Convert.ToInt32(registro["id"]);
                consulta.DataHora = Convert.ToDateTime(registro["data_consulta"]).Date;
                consulta.Observacao = registro["observacao"].ToString();

                consulta.Veterinario = new Veterinario();
                consulta.Veterinario.Id = Convert.ToInt32(registro["id_veterinarios"]);
                consulta.Veterinario.Nome = registro["nome"].ToString();

                consulta.Pet = new Pet();
                consulta.Pet.Id = Convert.ToInt32(registro["id_pets"]);
                consulta.Pet.Nome = registro["nome"].ToString();

                consultas.Add(consulta);
            }

            comando.Connection.Close();

            return consultas;
        }
    }
}
