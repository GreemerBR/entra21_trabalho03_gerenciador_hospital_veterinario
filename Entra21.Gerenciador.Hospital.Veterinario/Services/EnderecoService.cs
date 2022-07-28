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
            comando.CommandText = "INSERT INTO enderecos (id_responsaveis, cep, logradouro, bairro, cidade, unidade_federativa) VALUES (@ID_RESPONSAVEIS, @CEP, @LOGRADOURO, @BAIRRO, @CIDADE, @UNIDADE_FEDERATIVA)";

            comando.Parameters.AddWithValue("@ID_RESPONSAVEIS", endereco.Responsavel.Id);
            comando.Parameters.AddWithValue("@CEP", endereco.Cep);
            comando.Parameters.AddWithValue("@LOGRADOURO", endereco.Logradouro);
            comando.Parameters.AddWithValue("@BAIRRO", endereco.Bairro);
            comando.Parameters.AddWithValue("@CIDADE", endereco.Localidade);
            comando.Parameters.AddWithValue("@UNIDADE_FEDERATIVA", endereco.Uf);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Editar(Endereco endereco)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "UPDATE enderecos SET id_responsaveis = @ID_RESPONSAVEIS, cep = @CEP, logradouro = @LOGRADOURO, bairro = @BAIRRO, cidade = @CIDADE, unidade_federativa = @UNIDADE_FEDERATIVA WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID_RESPONSAVEIS", endereco.Responsavel.Id);
            comando.Parameters.AddWithValue("@CEP", endereco.Cep);
            comando.Parameters.AddWithValue("@LOGRADOURO", endereco.Logradouro);
            comando.Parameters.AddWithValue("@BAIRRO", endereco.Bairro);
            comando.Parameters.AddWithValue("@CIDADE", endereco.Localidade);
            comando.Parameters.AddWithValue("@UNIDADE_FEDERATIVA", endereco.Uf);
            comando.Parameters.AddWithValue("@ID", endereco.Id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public Endereco ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT id, id_responsaveis, cep, logradouro, bairro, cidade, unidade_federativa FROM enderecos WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            var dataTable = new DataTable();
            dataTable.Load(comando.ExecuteReader());
            if(dataTable.Rows.Count == 0)
                return null;

            var registro = dataTable.Rows[0];
            var endereco = new Endereco();
            endereco.Id = Convert.ToInt32(registro["id"]);

            endereco.Responsavel = new Responsavel();
            endereco.Responsavel.Id = Convert.ToInt32(registro["id_responsaveis"]);

            endereco.Cep = registro["cep"].ToString();
            endereco.Logradouro = registro["logradouro"].ToString();
            endereco.Bairro = registro["bairro"].ToString();
            endereco.Localidade = registro["cidade"].ToString();
            endereco.Uf = registro["unidade_federativa"].ToString();

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
r.nome AS 'responsavel_nome',
r.idade AS 'responsavel_idade',
r.cpf AS 'responsavel_cpf',
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
                endereco.Localidade = registro["cidade"].ToString();
                endereco.Uf = registro["unidade_federativa"].ToString();

                endereco.Responsavel = new Responsavel();
                endereco.Responsavel.Id = Convert.ToInt32(registro["responsavel_id"]);
                endereco.Responsavel.Nome = registro["responsavel_nome"].ToString();
                endereco.Responsavel.Idade = Convert.ToInt32(registro["responsavel_idade"]);
                endereco.Responsavel.Cpf = registro["responsavel_cpf"].ToString();
                endereco.Responsavel.Telefone = registro["responsavel_telefone"].ToString();

                enderecos.Add(endereco);
            }
            return enderecos;
        }
    }
}
