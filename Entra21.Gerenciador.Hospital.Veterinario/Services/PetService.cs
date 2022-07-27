using Entra21.Gerenciador.Hospital.Vet.Database;
using Entra21.Gerenciador.Hospital.Vet.Models;
using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }

        public Pet ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pet> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
