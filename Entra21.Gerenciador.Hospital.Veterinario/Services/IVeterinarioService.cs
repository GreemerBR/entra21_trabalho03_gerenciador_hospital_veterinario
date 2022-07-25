using Entra21.Gerenciador.Hospital.Veterinario.Enums;

namespace Entra21.Gerenciador.Hospital.Veterinario.Services
{
    internal interface IVeterinarioService
    {
        List<Veterinario> ObterTodosFiltrando(string nomeVeterinario, VeterinarioListaFiltroStatus veterinarioListaFiltroSatus);
        Veterinario ObterPorId(int id);
    }
}
