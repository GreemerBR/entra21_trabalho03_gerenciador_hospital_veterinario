using Entra21.Gerenciador.Hospital.Vet.Models;

namespace Entra21.Gerenciador.Hospital.Vet.Services
{
    internal interface IResponsavelService
    {
        List<Responsavel> ObterTodos();
        Responsavel ObterPorId(int id);
        void Cadastrar(Responsavel responsavel);
        void Editar(Responsavel responsavel);
        void Apagar(int id);
    }
}
