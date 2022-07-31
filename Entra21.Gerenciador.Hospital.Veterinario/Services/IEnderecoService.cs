using Entra21.Gerenciador.Hospital.Vet.Models;

namespace Entra21.Gerenciador.Hospital.Vet.Services
{
    internal interface IEnderecoService
    {
        List<Endereco> ObterTodos();
        Endereco ObterPorId(int id);
        List<Endereco> ObterPorBairro(string bairro);
        void Cadastrar(Endereco endereco);
        void Editar(Endereco endereco);
        void Apagar(int id);
    }
}
