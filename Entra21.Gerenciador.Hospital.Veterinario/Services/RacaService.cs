using Entra21.Gerenciador.Hospital.Vet.Database;
using Entra21.Gerenciador.Hospital.Vet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.Gerenciador.Hospital.Vet.Services
{
    internal class RacaService : IRacaService
    {
        public void Cadastrar(Raca raca)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = @"INSERT INTO racas (especie, nome)
            VALUES (@ESPECIE, @NOME);";

            comando.Parameters.AddWithValue("@ESPECIE", raca.Especie);
            comando.Parameters.AddWithValue("@NOME", raca.Nome);
           
            comando.ExecuteNonQuery();         

            comando.Connection.Close();
        }
        public void Editar(Raca raca)
        {
            throw new NotImplementedException();
        }
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();
        }
        public List<Raca> ObterTodos()
        {
            throw new NotImplementedException();
        }
        public Raca ObterPorId(int id)
        {
            throw new NotImplementedException();
        }


    }
}
