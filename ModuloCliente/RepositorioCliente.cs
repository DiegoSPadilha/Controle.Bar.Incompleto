using Controle.Bar.ModuloCompartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle.Bar.ModuloCliente
{
    public class RepositorioCliente : RepositorioBase
    {
        private ArrayList arrayList;

        public RepositorioCliente(ArrayList arrayList)
        {
            this.arrayList = arrayList;
        }
    }
}
