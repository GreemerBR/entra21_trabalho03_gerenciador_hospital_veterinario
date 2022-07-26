using Entra21.Gerenciador.Hospital.Vet.Database;
using Entra21.Gerenciador.Hospital.Vet.Models;

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

            comando.CommandText = @"INSERT INTO consultas (data_consulta, hora_consulta, observação, id_veterinarios, id_pets)
VALUES (@DATA_CONSULTA, @HORA_CONSULTA, @OBSERVACAO, @ID_VETERINARIOS, @ID_PETS);";

            comando.Parameters.AddWithValue("@DATA_CONSULTA", consulta.Data);
            comando.Parameters.AddWithValue("@HORA_CONSULTA", consulta.Hora);
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
            comando.CommandText = @"UPDATE consultas SET data_consulta = @DATA_CONSULTA, hora_consulta = @HORA_CONSULTA, observação = @OBSERVACAO, 
id_veterinarios = @ID_VETERINARIOS, id_pets = @ID_PETS WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", consulta.Id);
            comando.Parameters.AddWithValue("@DATA_CONSULTA", consulta.Data);
            comando.Parameters.AddWithValue("@HORA_CONSULTA", consulta.Hora);
            comando.Parameters.AddWithValue("@OBSERVACAO", consulta.Observacao);
            comando.Parameters.AddWithValue("@ID_VETERINARIOS", consulta.Veterinario.Id);
            comando.Parameters.AddWithValue("@ID_PETS", consulta.Pet.Id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public List<Consulta> ObterPorData(DateTime data)
        {
            throw new NotImplementedException();
        }

        public List<Consulta> ObterPorHora(DateTime hora)
        {
            throw new NotImplementedException();
        }

        public Consulta ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Consulta> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
