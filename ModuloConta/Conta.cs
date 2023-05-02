using Controle.Bar.ModuloCompartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle.Bar.ModuloConta
{
    public class Conta : EntidadeBase
    {
        public string conta;

        public Conta(string conta)
        {
            this.conta = conta;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado, Conta contaAtualizada)
        {
            Conta contaAtualizada = (Conta)contaAtualizada;
        }

        public override ArrayList Validar()
        {
          
        }
    }
}
