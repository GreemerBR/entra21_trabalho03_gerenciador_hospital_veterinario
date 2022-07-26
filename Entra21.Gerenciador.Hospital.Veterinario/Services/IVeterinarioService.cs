using Entra21.Gerenciador.Hospital.Vet.Enums;
using Entra21.Gerenciador.Hospital.Vet.Models;

namespace Entra21.Gerenciador.Hospital.Vet.Services
{
    internal interface IVeterinarioService
    {
        List<Veterinario> ObterTodosFiltrando(string nomeVet, VeterinarioListaStatus VetListaFiltroSatus);
        Veterinario ObterPorId(int id);
        void Apagar(int id);
        void Cadastrar(Veterinario veterinario);
        void Editar(Veterinario veterinario);
    }
}
