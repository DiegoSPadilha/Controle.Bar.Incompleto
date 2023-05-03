using Controle.Bar.ModuloCompartilhado;
using Controle.Bar.ModuloGarcom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle.Bar.ModuloConta
{
    public class TelaConta : TelaBase
    {
        private TelaGarcom telaGarcom;
        private TelaMesa telaMesa;
        private RepositorioConta repositoriConta;

        public TelaConta(RepositorioConta repositoriConta)
        {
            this.repositoriConta = repositoriConta;
        }
    }
}
