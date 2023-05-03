using Controle.Bar.ModuloCompartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Controle.Bar.ModuloFuncionario
{
    public class Funcionario : EntidadeBase
    {
        public string Produto;
        public int Mesa;
        public string Garcom;

        // parametros
        public Funcionario(string produto, int mesa, string garcom)
        {
            Produto = produto;
            Mesa = mesa;
            this.Garcom = garcom;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Funcionario funcionarioAtulizar = (Funcionario)registroAtualizado;
            Produto = funcionarioAtulizar.Produto;
            Mesa = funcionarioAtulizar.Mesa;
            Garcom = funcionarioAtulizar.Garcom;

        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();
            if (string.IsNullOrEmpty(Produto.Trim()))
                erros.Add("O campo \"produto\" é obrigatório");
            if (string.IsNullOrEmpty(mesa.Trim()))
                erros.Add("O campo \"mesa\" é obrigatório");
            if (string.IsNullOrEmpty(Garcom.Trim()))
                erros.Add("O campo \"garcom\" é obrigatório");
            return erros;
        }
    }
}
