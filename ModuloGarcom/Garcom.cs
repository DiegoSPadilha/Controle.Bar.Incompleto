using Controle.Bar.ModuloCompartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Controle.Bar.ModuloGarcom
{
    public class Garcom : EntidadeBase
    {
        public string mesa;
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

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();
            if (string.IsNullOrEmpty(mesa.Trim()))
                erros.Add("O campo \"mesa\" é obrigatório");

            if (string.IsNullOrEmpty(pedido.Trim()))
                erros.Add("O campo \"pedido\" é obrigatório");
            return erros;
        }
    }
}
