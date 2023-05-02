using Controle.Bar.ModuloCompartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle.Bar.ModuloConta
{
    public class RepositorioConta : RepositorioBase
    {
        private ArrayList arrayList;

        public RepositorioConta(ArrayList arrayList)
        {
            this.arrayList = arrayList;
        }
    }
}
