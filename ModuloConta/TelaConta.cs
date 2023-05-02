using Controle.Bar.ModuloCompartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle.Bar.ModuloConta
{
    public class TelaConta : TelaBase
    {
        private RepositorioConta repositoriConta;

        public TelaConta(RepositorioConta repositoriConta)
        {
            this.repositoriConta = repositoriConta;
        }
    }
}
