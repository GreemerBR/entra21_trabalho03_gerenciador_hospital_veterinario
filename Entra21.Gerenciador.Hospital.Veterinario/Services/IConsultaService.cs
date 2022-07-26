using Entra21.Gerenciador.Hospital.Vet.Models;

namespace Entra21.Gerenciador.Hospital.Vet.Services
{
    internal interface IConsultaService
    {
        List<Consulta> ObterTodos();
        List<Consulta> ObterPorData(DateTime dataHora);
        Consulta ObterPorId(int id);
        void Apagar(int id);
        void Cadastrar(Consulta consulta);
        void Editar(Consulta consulta);
    }
}
