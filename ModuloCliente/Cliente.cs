using Controle.Bar.ModuloCompartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Controle.Bar.ModuloCliente
{
    public class Cliente :EntidadeBase
    {
        public string cliente;
        public string clienteDescricao;

        // parametros 
        public Cliente(string cliente, string clienteDescricao)
        {
            this.cliente = cliente;
            this.clienteDescricao = clienteDescricao;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Cliente clienteAtualizado = (Cliente)registroAtualizado;
            cliente = clienteAtualizado.cliente;
            cliente = clienteAtualizado.clienteDescricao;
           
        }

        //public override ArrayList Validar()
        //{
          
        //}
    }
}
