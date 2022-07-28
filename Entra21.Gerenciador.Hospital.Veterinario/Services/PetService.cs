using Entra21.Gerenciador.Hospital.Vet.Database;
using Entra21.Gerenciador.Hospital.Vet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            comando.CommandText = "SELECT id_responsaveis,id_raca,nome, idade,peso,altura,genero FROM pet WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            var dataTable = new DataTable();
            dataTable.Load(comando.ExecuteReader());
            if (dataTable.Rows.Count == 0)
                return null;

            var registro = dataTable.Rows[0];
            var pet = new Raca();

            pet.Id = Convert.ToInt32(registro["id"]);
            pet.Nome = registro["nome"].ToString();
            pet.Raca.Id = Convert.ToInt32(registro["id_raca"]);
            pet.Responsavel.Id = Convert.ToInt32(registro["id_responsaveis"]);
            pet.Idade = Convert.ToInt32(registro["idade"]);
            pet.Genero = registro["genero"].ToString();
            pet.Peso = 


            conexao.Close();

            return pet;
        }

        public List<Pet> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
