﻿using Entra21.Gerenciador.Hospital.Vet.Database;
using Entra21.Gerenciador.Hospital.Vet.Models;
using System.Data;
using System.Data.SqlClient;

namespace Entra21.Gerenciador.Hospital.Vet.Services
{
    internal class ResponsavelService : IResponsavelService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "DELETE FROM responsaveis WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Cadastrar(Responsavel responsavel)
        {
            var conexao = new Conexao().Conectar();

            SqlCommand comando = conexao.CreateCommand();

            comando.CommandText = "INSERT INTO responsaveis (nome, idade, cpf, telefone) VALUES (@NOME, @IDADE, @CPF, @TELEFONE)";

            comando.Parameters.AddWithValue("@NOME", responsavel.Nome);
            comando.Parameters.AddWithValue("@IDADE", responsavel.Idade);
            comando.Parameters.AddWithValue("@CPF", responsavel.Cpf);
            comando.Parameters.AddWithValue("@TELEFONE", responsavel.Telefone);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Editar(Responsavel responsavel)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "UPDATE responsaveis SET nome = @NOME, idade = @IDADE, cpf = @CPF, telefone = @TELEFONE WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", responsavel.Id);
            comando.Parameters.AddWithValue("@NOME", responsavel.Nome);
            comando.Parameters.AddWithValue("@IDADE", responsavel.Idade);
            comando.Parameters.AddWithValue("@CPF", responsavel.Cpf);
            comando.Parameters.AddWithValue("@TELEFONE", responsavel.Telefone);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public Responsavel ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT id, nome, idade, cpf, telefone FROM responsaveis WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            var dataTable = new DataTable();
            dataTable.Load(comando.ExecuteReader());
            if(dataTable.Rows.Count == 0)
                return null;

            var registro = dataTable.Rows[0];
            var responsavel = new Responsavel();
            responsavel.Id = Convert.ToInt32(registro["id"]);
            responsavel.Nome = registro["nome"].ToString();
            responsavel.Idade = Convert.ToInt32(registro["idade"]);
            responsavel.Cpf = registro["cpf"].ToString();
            responsavel.Telefone = registro["telefone"].ToString();

            conexao.Close();

            return responsavel;
        }

        public List<Responsavel> ObterPorNome(string nome)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, nome, idade, cpf, telefone FROM responsaveis WHERE nome LIKE @NOME";

            comando.Parameters.AddWithValue("@NOME", $"%{nome}%");

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            var responsaveis = new List<Responsavel>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var linha = tabelaEmMemoria.Rows[i];

                var responsavel = new Responsavel();
                responsavel.Id = Convert.ToInt32(linha["id"].ToString());
                responsavel.Nome = linha["nome"].ToString();
                responsavel.Idade = Convert.ToInt32(linha["idade"].ToString());
                responsavel.Cpf = linha["cpf"].ToString();
                responsavel.Telefone = linha["telefone"].ToString();

                responsaveis.Add(responsavel);
            }

            comando.Connection.Close();

            return responsaveis;
        }

        public List<Responsavel> ObterTodos()
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, nome, idade, cpf, telefone FROM responsaveis";

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            var responsaveis = new List<Responsavel>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var linha = tabelaEmMemoria.Rows[i];

                var responsavel = new Responsavel();
                responsavel.Id = Convert.ToInt32(linha["id"].ToString());
                responsavel.Nome = linha["nome"].ToString();
                responsavel.Idade = Convert.ToInt32(linha["idade"].ToString());
                responsavel.Cpf = linha["cpf"].ToString();
                responsavel.Telefone = linha["telefone"].ToString();

                responsaveis.Add(responsavel);
            }

            comando.Connection.Close();

            return responsaveis;
        }
    }
}
