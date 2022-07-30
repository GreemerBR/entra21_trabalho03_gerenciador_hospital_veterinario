using Entra21.Gerenciador.Hospital.Vet.Database;
using Entra21.Gerenciador.Hospital.Vet.Models;
using System.Data;

namespace Entra21.Gerenciador.Hospital.Vet.Services
{
    internal class PetService : IPetService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "DELETE FROM pets WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Cadastrar(Pet pet)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = @"INSERT INTO pets (id_responsaveis,id_raca,nome, idade,peso,altura,genero)
                                  VALUES (@ID_RESPONSAVEIS, @ID_RACA, @NOME, @IDADE, @PESO, @ALTURA, @GENERO);";

            comando.Parameters.AddWithValue("@ID_RESPONSAVEIS", pet.Responsavel.Id);
            comando.Parameters.AddWithValue("@ID_RACA", pet.Raca.Id);
            comando.Parameters.AddWithValue("@NOME", pet.Nome);
            comando.Parameters.AddWithValue("@IDADE", pet.Idade);
            comando.Parameters.AddWithValue("@PESO", pet.Peso);
            comando.Parameters.AddWithValue("@ALTURA", pet.Altura);
            comando.Parameters.AddWithValue("@GENERO", pet.Genero);
            

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Editar(Pet pet)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = @"UPDATE pets SET @ID_RACA=id_raca, @NOME=nome, @IDADE=idade,@PESO=peso,@ALTURA=altura,@GENERO=genero WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID_RESPONSAVEIS", pet.Responsavel.Id);
            comando.Parameters.AddWithValue("@ID_RACA", pet.Raca.Id);
            comando.Parameters.AddWithValue("@NOME", pet.Nome);
            comando.Parameters.AddWithValue("@IDADE", pet.Idade);
            comando.Parameters.AddWithValue("@PESO", pet.Peso);
            comando.Parameters.AddWithValue("@ALTURA", pet.Altura);
            comando.Parameters.AddWithValue("@GENERO", pet.Genero);


            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public Pet ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT id, id_responsaveis,id_raca, nome, idade, peso, altura, genero FROM pet WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            var dataTable = new DataTable();
            dataTable.Load(comando.ExecuteReader());
            if (dataTable.Rows.Count == 0)
                return null;

            var registro = dataTable.Rows[0];

            var pet = new Pet();
            pet.Id = Convert.ToInt32(registro["id"]);
            pet.Nome = registro["nome"].ToString();
            pet.Idade = Convert.ToInt32(registro["idade"]);
            pet.Genero = registro["genero"].ToString();
            pet.Peso = Convert.ToDouble(registro["peso"]);
            pet.Altura = Convert.ToDouble(registro["altura"]);

            pet.Raca = new Raca();
            pet.Raca.Id = Convert.ToInt32(registro["id_raca"]);

            pet.Responsavel = new Responsavel();
            pet.Responsavel.Id = Convert.ToInt32(registro["id_responsaveis"]);


            comando.Connection.Close();

            return pet;
        }

        public List<Pet> ObterPorNomePet(string nomePet)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = @"SELECT
p.id AS 'id',
p.nome AS 'nome', 
p.idade AS 'idade', 
p.peso AS 'peso', 
p.altura AS 'altura', 
p.genero AS 'genero', 
rp.id AS 'id_responsaveis',
rp.nome AS 'nome_responsavel',
rc.id AS 'id_raca',
rc.nome AS 'nome_raca'
FROM pets AS p
INNER JOIN responsaveis AS rp ON(p.id_responsaveis = rp.id)
INNER JOIN racas AS rc ON(p.id_racas = rc.id)
WHERE nome_responsavel LIKE @NOME_RESPONSAVEL";

            comando.Parameters.AddWithValue("@NOME_RESPONSAVEL", $"%{nomePet}%");

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            var pets = new List<Pet>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];

                var pet = new Pet();
                pet.Id = Convert.ToInt32(registro["id"]);
                pet.Nome = registro["nome"].ToString();
                pet.Idade = Convert.ToInt32(registro["idade"]);
                pet.Genero = registro["genero"].ToString();
                pet.Peso = Convert.ToDouble(registro["peso"]);
                pet.Altura = Convert.ToDouble(registro["altura"]);

                pet.Raca = new Raca();
                pet.Raca.Id = Convert.ToInt32(registro["id_raca"]);
                pet.Raca.Nome = registro["nome"].ToString();

                pet.Responsavel = new Responsavel();
                pet.Responsavel.Id = Convert.ToInt32(registro["id_responsaveis"]);
                pet.Responsavel.Nome = registro["nome"].ToString();
            }

            comando.Connection.Close();

            return pets;
        }

        public List<Pet> ObterPorNomeResponsavel(string nomeResponsavel)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = @"SELECT
p.id AS 'id',
p.nome AS 'nome', 
p.idade AS 'idade', 
p.peso AS 'peso', 
p.altura AS 'altura', 
p.genero AS 'genero', 
rp.id AS 'id_responsaveis',
rp.nome AS 'nome_responsavel',
rc.id AS 'id_raca',
rc.nome AS 'nome_raca'
FROM pets AS p
INNER JOIN responsaveis AS rp ON(p.id_responsaveis = rp.id)
INNER JOIN racas AS rc ON(p.id_racas = rc.id)
WHERE nome_responsavel LIKE @NOME_RESPONSAVEL";

            comando.Parameters.AddWithValue("@NOME_RESPONSAVEL", $"%{nomeResponsavel}%");

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            var pets = new List<Pet>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];

                var pet = new Pet();
                pet.Id = Convert.ToInt32(registro["id"]);
                pet.Nome = registro["nome"].ToString();
                pet.Idade = Convert.ToInt32(registro["idade"]);
                pet.Genero = registro["genero"].ToString();
                pet.Peso = Convert.ToDouble(registro["peso"]);
                pet.Altura = Convert.ToDouble(registro["altura"]);

                pet.Raca = new Raca();
                pet.Raca.Id = Convert.ToInt32(registro["id_raca"]);
                pet.Raca.Nome = registro["nome"].ToString();

                pet.Responsavel = new Responsavel();
                pet.Responsavel.Id = Convert.ToInt32(registro["id_responsaveis"]);
                pet.Responsavel.Nome = registro["nome"].ToString();
            }

            comando.Connection.Close();

            return pets;
        }

        public List<Pet> ObterTodos()
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = @"SELECT
p.id AS 'id',
p.nome AS 'nome', 
p.idade AS 'idade', 
p.peso AS 'peso', 
p.altura AS 'altura', 
p.genero AS 'genero', 
rp.id AS 'id_responsaveis',
rp.nome AS 'nome_responsavel',
rc.id AS 'id_raca',
rc.nome AS 'nome_raca'
FROM pets AS p
INNER JOIN responsaveis AS rp ON(p.id_responsaveis = rp.id)
INNER JOIN racas AS rc ON(p.id_racas = rc.id)";

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            var pets = new List<Pet>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];

                var pet = new Pet();
                pet.Id = Convert.ToInt32(registro["id"]);
                pet.Nome = registro["nome"].ToString();
                pet.Idade = Convert.ToInt32(registro["idade"]);
                pet.Genero = registro["genero"].ToString();
                pet.Peso = Convert.ToDouble(registro["peso"]);
                pet.Altura = Convert.ToDouble(registro["altura"]);

                pet.Raca = new Raca();
                pet.Raca.Id = Convert.ToInt32(registro["id_raca"]);
                pet.Raca.Nome = registro["nome"].ToString();

                pet.Responsavel = new Responsavel();
                pet.Responsavel.Id = Convert.ToInt32(registro["id_responsaveis"]);
                pet.Responsavel.Nome = registro["nome"].ToString();
            }

            comando.Connection.Close();

            return pets;
        }
    }
}
