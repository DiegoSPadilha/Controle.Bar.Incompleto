using Controle.Bar.ModuloCompartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Controle.Bar.ModuloCliente
{
    public class Cliente :EntidadeBase
    {
        public string cliente;
        public string clientePedido;

        // parametros 
        public Cliente(string cliente, string clientePedido)
        {
            this.cliente = cliente;
            this.clienteDescricao = clientePedido;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Cliente clienteAtualizado = (Cliente)registroAtualizado;
            cliente = clienteAtualizado.cliente;
            cliente = clienteAtualizado.clientePedido;
           
        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();
            if (string.IsNullOrEmpty(cliente.Trim()))
                erros.Add("O campo \"cliente\" é obrigatório");

            if (string.IsNullOrEmpty(clientePedido.Trim()))
                erros.Add("O campo \"clientePedido\" é obrigatório");

            return erros;
        }
    }
}
