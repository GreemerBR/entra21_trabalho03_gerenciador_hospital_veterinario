using Entra21.Gerenciador.Hospital.Veterinario.Database;
using Entra21.Gerenciador.Hospital.Veterinario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.Gerenciador.Hospital.Veterinario.Services
{
    internal class ResponsavelService : IResponsavelService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();
        }

        public void Cadastrar(Responsavel responsavel)
        {
            throw new NotImplementedException();
        }

        public void Editar(Responsavel responsavel)
        {
            throw new NotImplementedException();
        }

        public Responsavel ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Responsavel> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
