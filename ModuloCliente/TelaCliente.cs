using Controle.Bar.ModuloCompartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle.Bar.ModuloCliente
{
    public class TelaCliente : TelaBase
    {
        public RepositorioCliente RepositorioCliente;

        public TelaCliente(RepositorioCliente repositorioCliente)
        {
            RepositorioCliente = repositorioCliente;
        }
    }
}
