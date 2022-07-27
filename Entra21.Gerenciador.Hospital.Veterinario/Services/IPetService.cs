using Entra21.Gerenciador.Hospital.Vet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.Gerenciador.Hospital.Vet.Services
{
    internal interface IPetService
    {
        List<Pet> ObterTodos();
        Pet ObterPorId(int id);
        void Cadastrar(Pet pet);
        void Editar(Pet pet);
        void Apagar(int id);
    }
}
