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
    public class TelaFuncionario : TelaBase
    {
        protected override EntidadeBase ObterRegistro => throw new NotImplementedException();

        public class funcionario;

        public TelaFuncionario(RepositorioFuncionario repositorioFuncionario,RepositorioGarcom repositorioGarcom) 
        {
            this.repositorioFuncionario = repositorioFuncionario;
            this.repositorioFuncionario = repositorioGarcom;
        }

        public TelaFuncionario()
        {
        }

        public TelaFuncionario(RepositorioFuncionario repositorioFuncionario)
        {
            this.repositorioFuncionario = repositorioFuncionario;
        }

        protected override void MostrarTabela(ArrayList produto)
        {
            foreach (Produto produto in produto)
            {
                Console.WriteLine("Digite o produto que deseja registrar: !");
                produto = produto.ToList();

            }
        }
        public override void ExcluirRegistro()
        {
            Console.WriteLine("Digite o produto que deseja excluir: !");
            string produto = Console.ReadLine();

            base.ExcluirRegistro();
        }
    }
}
