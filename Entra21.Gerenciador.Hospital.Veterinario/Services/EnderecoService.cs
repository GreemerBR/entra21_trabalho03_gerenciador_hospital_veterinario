using Entra21.Gerenciador.Hospital.Vet.Database;
using Entra21.Gerenciador.Hospital.Vet.Models;
using System.Data;

namespace Entra21.Gerenciador.Hospital.Vet.Services
{
    internal class EnderecoService : IEnderecoService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "DELETE FROM enderecos WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Cadastrar(Endereco endereco)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "id_responsaveis, cep, logradouro, bairro, cidade, unidade_federativa VALUES (@ID_RESPONSAVEIS, @CEP, @LOGRADOURO, @BAIRRO, @CIDADE, @UNIDADE_FEDERATIVA);";

            comando.Parameters.AddWithValue("@ID_RESPONSAVEIS", endereco.Responsavel.Id);
            comando.Parameters.AddWithValue("@CEP", endereco.Cep);
            comando.Parameters.AddWithValue("@LOGRADOURO", endereco.Logradouro);
            comando.Parameters.AddWithValue("@BAIRRO", endereco.Bairro);
            comando.Parameters.AddWithValue("@CIDADE", endereco.Cidade);
            comando.Parameters.AddWithValue("@UNIDADE_FEDERATIVA", endereco.UnidadeFederativa);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Editar(Endereco endereco)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "UPDADETE enderecos SET id_responsaveis = @ID_RESPONSAVEIS, cep = @CEP, logradouro = @LOGRADOURO, bairro = @BAIRRO, cidade = @CIDADE, unidade_federativa = @UNIDADE_FEDERATIVA, id = @ID";

            comando.Parameters.AddWithValue("@ID_RESPONSAVEIS", endereco.Responsavel.Id);
            comando.Parameters.AddWithValue("@CEP", endereco.Cep);
            comando.Parameters.AddWithValue("@LOGRADOURO", endereco.Logradouro);
            comando.Parameters.AddWithValue("@BAIRRO", endereco.Bairro);
            comando.Parameters.AddWithValue("@CIDADE", endereco.Cidade);
            comando.Parameters.AddWithValue("@UNIDADE_FEDERATIVA", endereco.UnidadeFederativa);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public Endereco ObterPorId()
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT id, id_responsaveis, cep, logradouro, bairro, cidade, unidade_federativa FROM enderecos WHERE id = @ID";

            var dataTable = new DataTable();
            dataTable.Load(comando.ExecuteReader());
            if(dataTable.Rows.Count == 0)
                return null;

            var registro = dataTable.Rows[0];
            var endereco = new Endereco();
            endereco.Id = Convert.ToInt32(registro["id"]);

            endereco.Responsavel = new Responsavel();
            endereco.Responsavel.Id = Convert.ToInt32(registro["id_editora"]);

            endereco.Cep = registro["cep"].ToString();
            endereco.Logradouro = registro["logradouro"].ToString();
            endereco.Bairro = registro["bairro"].ToString();
            endereco.Cidade = registro["cidade"].ToString();
            endereco.UnidadeFederativa = registro["unidade_federativa"].ToString();

            conexao.Close();

            return endereco;
        }

        public List<Endereco> ObterTodos()
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"SELECT
e.id AS 'id',
e.cep AS 'cep',
e.logradouro AS 'logradouro',
e.bairro AS 'bairro',
e.cidade AS 'cidade',
e.unidade_federativa AS 'unidade_federativa',
r.id AS 'responsavel_id',
r.nome AS 'responsavel_nome'
r.idade AS 'responsavel_idade'
r.cpf AS 'responsavel_cpf'
r.telefone AS 'responsavel_telefone'
FROM enderecos AS e
INNER JOIN responsaveis AS r ON(e.id_responsaveis = r.id)";

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            var enderecos = new List<Endereco>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];
                var endereco = new Endereco();
                endereco.Id = Convert.ToInt32(registro["id"]);
                endereco.Cep = registro["cep"].ToString();
                endereco.Logradouro = registro["logradouro"].ToString();
                endereco.Bairro = registro["bairro"].ToString();
                endereco.Cidade = registro["cidade"].ToString();
                endereco.UnidadeFederativa = registro["unidade_federativa"].ToString();

                endereco.Responsavel = new Responsavel();
                endereco.Responsavel.Id = Convert.ToInt32(registro["id"]);
                endereco.Responsavel.Nome = registro["nome"].ToString();
                endereco.Responsavel.Idade = Convert.ToInt32(registro["idade"]);
                endereco.Responsavel.Cpf = registro["cpf"].ToString();
                endereco.Responsavel.Telefone = Convert.ToInt32(registro["telefone"]);

                enderecos.Add(endereco);
            }
            return enderecos;
        }
    }
}
