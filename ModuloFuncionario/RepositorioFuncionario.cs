using Controle.Bar.ModuloCompartilhado;
using Controle.Bar.ModuloGarcom;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle.Bar.ModuloFuncionario
{
    public class RepositorioFuncionario : RepositorioBase
    {
        private ArrayList arrayList;

        public RepositorioFuncionario(ArrayList arrayList) 
        {
            this.arrayList = arrayList;
        }
    }
}
