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
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = @"UPDATE racas SET nome = @NOME, especie = @Especie";

            comando.Parameters.AddWithValue("@ESPECIE", raca.Especie);
            comando.Parameters.AddWithValue("@NOME", raca.Nome);
           
            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "DELETE FROM racas WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public Raca ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, especie, nome FROM racas WHERE id = @ID";
           
            comando.Parameters.AddWithValue("@ID", id);

            var dataTable = new DataTable();

            dataTable.Load(comando.ExecuteReader());

            if (dataTable.Rows.Count == 0)
                return null;

            var registro = dataTable.Rows[0];

            var raca = new Raca();

            raca.Id = Convert.ToInt32(registro["id"]);
            raca.Especie = registro["especie"].ToString();
            raca.Nome = registro["nome"].ToString();
            
            conexao.Close();

            return raca;
        }

        public List<Raca> ObterTodos()
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, especie, nome FROM racas";
           

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            var racas = new List<Raca>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];

                var raca = new Raca();
                raca.Id = Convert.ToInt32(registro["id"]);
                raca.Especie = registro["especie"].ToString();
                raca.Nome = registro["nome"].ToString();

                racas.Add(raca);
            }
            comando.Connection.Close();

            return racas;
        }

        public List<Raca> ObterPorNome(string nomeRaca)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, especie, nome FROM racas WHERE nome LIKE @NOME";

            comando.Parameters.AddWithValue("@NOME", $"%{nomeRaca}%");

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            var racas = new List<Raca>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];

                var raca = new Raca();
                raca.Id = Convert.ToInt32(registro["id"]);
                raca.Especie = registro["especie"].ToString();
                raca.Nome = registro["nome"].ToString();

                racas.Add(raca);
            }
            comando.Connection.Close();

            return racas;
        }

        public List<Raca> ObterPorEspecie(string especie)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, especie, nome FROM racas WHERE especie LIKE @ESPECIE";

            comando.Parameters.AddWithValue("@ESPECIE", $"%{especie}%");

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            var racas = new List<Raca>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];

                var raca = new Raca();
                raca.Id = Convert.ToInt32(registro["id"]);
                raca.Especie = registro["especie"].ToString();
                raca.Nome = registro["nome"].ToString();

                racas.Add(raca);
            }
            comando.Connection.Close();

            return racas;
        }
    }
}
