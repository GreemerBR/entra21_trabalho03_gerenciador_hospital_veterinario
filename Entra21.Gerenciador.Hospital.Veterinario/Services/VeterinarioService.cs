using Entra21.Gerenciador.Hospital.Vet.Database;
using Entra21.Gerenciador.Hospital.Vet.Models;
using System.Data;

namespace Entra21.Gerenciador.Hospital.Vet.Services
{
    internal class VeterinarioService : IVeterinarioService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "DELETE FROM veterinarios WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Cadastrar(Veterinario veterinario)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = @"INSERT INTO veterinarios (nome, idade, telefone, cpf, especialidade, crmv_estado, crmv_numero)
VALUES (@NOME, @IDADE, @TELEFONE, @CPF, @ESPECIALIDADE, @CRMV_ESTADO, @CRMV_NUMERO);";

            comando.Parameters.AddWithValue("@NOME", veterinario.Nome);
            comando.Parameters.AddWithValue("@IDADE", veterinario.Idade);
            comando.Parameters.AddWithValue("@TELEFONE", veterinario.Telefone);
            comando.Parameters.AddWithValue("@CPF", veterinario.Cpf);
            comando.Parameters.AddWithValue("@ESPECIALIDADE", veterinario.Especialidade);
            comando.Parameters.AddWithValue("@CRMV_ESTADO", veterinario.CrmvEstado);
            comando.Parameters.AddWithValue("@CRMV_NUMERO", veterinario.CrmvNumero);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Editar(Veterinario veterinario)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();
            comando.CommandText = @"UPDATE veterinarios SET nome = @NOME, idade = @IDADE, telefone = @TELEFONE, cpf = @CPF, 
especialidade = @ESPECIALIDADE, crmv_estado = @CRMV_ESTADO, crmv_numero = @CRMV_NUMERO WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", veterinario.Id);
            comando.Parameters.AddWithValue("@NOME", veterinario.Nome);
            comando.Parameters.AddWithValue("@IDADE", veterinario.Idade);
            comando.Parameters.AddWithValue("@TELEFONE", veterinario.Telefone);
            comando.Parameters.AddWithValue("@CPF", veterinario.Cpf);
            comando.Parameters.AddWithValue("@ESPECIALIDADE", veterinario.Especialidade);
            comando.Parameters.AddWithValue("@CRMV_ESTADO", veterinario.CrmvEstado);
            comando.Parameters.AddWithValue("@CRMV_NUMERO", veterinario.CrmvNumero);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public Veterinario ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, nome, idade, telefone, cpf, especialidade, crmv_estado, crmv_numero FROM veterinarios WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            if (tabelaEmMemoria.Rows.Count == 0)
                return null;

            var registro = tabelaEmMemoria.Rows[0];

            var veterinario = new Veterinario();

            veterinario.Id = Convert.ToInt32(registro["id"]);
            veterinario.Nome = registro["nome"].ToString();
            veterinario.Idade = Convert.ToInt32(registro["idade"]);
            veterinario.Telefone = registro["telefone"].ToString();
            veterinario.Cpf = registro["cpf"].ToString();
            veterinario.Especialidade = registro["especialidade"].ToString();
            veterinario.CrmvEstado = registro["crmv_estado"].ToString();
            veterinario.CrmvNumero = Convert.ToInt32(registro["crmv_numero"]);

            comando.Connection.Close();

            return veterinario;
        }

        public List<Veterinario> ObterPorNome(string nomeVeterinario)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = @"SELECT id, nome, idade, telefone, cpf, especialidade, crmv_estado, crmv_numero FROM veterinarios
WHERE nome LIKE @NOME";

            comando.Parameters.AddWithValue("@NOME", $"%{nomeVeterinario}%");

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            var veterinarios = new List<Veterinario>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];

                var veterinario = new Veterinario();

                veterinario.Id = Convert.ToInt32(registro["id"]);
                veterinario.Nome = registro["nome"].ToString();
                veterinario.Idade = Convert.ToInt32(registro["idade"]);
                veterinario.Telefone = registro["telefone"].ToString();
                veterinario.Cpf = registro["cpf"].ToString();
                veterinario.Especialidade = registro["especialidade"].ToString();
                veterinario.CrmvEstado = registro["crmv_estado"].ToString();
                veterinario.CrmvNumero = Convert.ToInt32(registro["crmv_numero"]);

                veterinarios.Add(veterinario);
            }

            comando.Connection.Close();

            return veterinarios;
        }

        public List<Veterinario> ObterTodos()
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = @"SELECT id, nome, idade, telefone, cpf, especialidade, crmv_estado, crmv_numero FROM veterinarios";

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            var veterinarios = new List<Veterinario>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];

                var veterinario = new Veterinario();

                veterinario.Id = Convert.ToInt32(registro["id"]);
                veterinario.Nome = registro["nome"].ToString();
                veterinario.Idade = Convert.ToInt32(registro["idade"]);
                veterinario.Telefone = registro["telefone"].ToString();
                veterinario.Cpf = registro["cpf"].ToString();
                veterinario.Especialidade = registro["especialidade"].ToString();
                veterinario.CrmvEstado = registro["crmv_estado"].ToString();
                veterinario.CrmvNumero = Convert.ToInt32(registro["crmv_numero"]);

                veterinarios.Add(veterinario);
            }

            comando.Connection.Close();

            return veterinarios;
        }
    }
}
