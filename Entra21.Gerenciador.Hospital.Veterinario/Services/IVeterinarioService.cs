using Entra21.Gerenciador.Hospital.Vet.Enums;
using Entra21.Gerenciador.Hospital.Vet.Models;

namespace Entra21.Gerenciador.Hospital.Vet.Services
{
    internal interface IVeterinarioService
    {
        List<Veterinario> ObterTodosFiltrando(string nomeVet, VeterinarioListaFiltroStatus VetListaFiltroSatus);
        Veterinario ObterPorId(int id);
    }
}
