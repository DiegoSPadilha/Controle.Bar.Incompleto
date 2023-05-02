using Controle.Bar.ModuloCompartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Controle.Bar.ModuloGarcom
{
    public class Garcom : EntidadeBase
    {
        public int mesa;
        public  string pedido;

        public Garcom(string pedido,int mesa)
        {
            pedido = pedido;
            mesa = mesa;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Garcom garcomAtualizado = (Garcom)registroAtualizado;
            pedido = registroAtualizado.mesa; 
        }
    }
}
