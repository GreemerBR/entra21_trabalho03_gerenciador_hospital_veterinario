using Entra21.Gerenciador.Hospital.Vet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.Gerenciador.Hospital.Vet.Services
{
    internal interface IRacaService
    {
        List<Raca> ObterPorNome(string nomeRaca);
        List<Raca> ObterPorEspecie(string especie);
        List<Raca> ObterTodos();
        Raca ObterPorId(int id);
        void Cadastrar(Raca raca);
        void Editar(Raca raca);
        void Apagar(int id);


    }
}
