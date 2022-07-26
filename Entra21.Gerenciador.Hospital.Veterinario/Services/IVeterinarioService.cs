﻿using Entra21.Gerenciador.Hospital.Vet.Models;

namespace Entra21.Gerenciador.Hospital.Vet.Services
{
    internal interface IVeterinarioService
    {
        List<Veterinario> ObterPorNome(string nomeVeterinario);
        List<Veterinario> ObterPorEspecialidade(string especialidade);
        List<Veterinario> ObterTodos();
        Veterinario ObterPorId(int id);
        void Apagar(int id);
        void Cadastrar(Veterinario veterinario);
        void Editar(Veterinario veterinario);
    }
}
