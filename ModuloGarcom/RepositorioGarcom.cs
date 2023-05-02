using Controle.Bar.ModuloCompartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle.Bar.ModuloGarcom
{
    public class RepositorioGarcom : RepositorioBase
    {
        private ArrayList arrayList;
        public RepositorioGarcom(ArrayList arrayList)
        { 
            this.arrayList = arrayList;
        }

    }
}
