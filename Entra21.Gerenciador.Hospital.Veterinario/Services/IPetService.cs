using Entra21.Gerenciador.Hospital.Vet.Models;

namespace Entra21.Gerenciador.Hospital.Vet.Services
{
    internal interface IPetService
    {
        List<Pet> ObterTodos();
        List<Pet> ObterPorNomePet(string nomePet);
        List<Pet> ObterPorNomeResponsavel(string nomeResponsavel);
        Pet ObterPorId(int id);
        void Cadastrar(Pet pet);
        void Editar(Pet pet);
        void Apagar(int id);
    }
}
