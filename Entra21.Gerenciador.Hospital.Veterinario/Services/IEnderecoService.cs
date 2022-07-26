using Entra21.Gerenciador.Hospital.Vet.Models;

namespace Entra21.Gerenciador.Hospital.Vet.Services
{
    internal interface IEnderecoService
    {
        List<Endereco> ObterTodos();
        Endereco ObterPorId();
        void Cadastrar(Endereco endereco);
        void Editar(Endereco endereco);
        void Apagar(int id);
    }
}
