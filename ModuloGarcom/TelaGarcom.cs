using Controle.Bar.ModuloCompartilhado;
using Controle.Bar.ModuloFuncionario;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle.Bar.ModuloGarcom
{
    public class TelaGarcom : TelaBase
    {
        public RepositorioBase repositorioGarcom;
        public RepositorioGarcom RepositorioGarcom;

        public TelaGarcom(string garcom, int mesa)
        {
        }

        public TelaGarcom(RepositorioGarcom repositorioGarcom)
        {
            this.repositorioGarcom = repositorioGarcom;
        }

        protected override EntidadeBase ObterRegistro => throw new NotImplementedException();

        protected override void MostrarTabela(ArrayList registros)
        {
            foreach (Garcom garcom in registros)
            {
                Console.WriteLine(garcom.pedido);
                Console.WriteLine(garcom.mesa);
            }
        }
        public override void ExcluirRegistro()
        {
            Console.WriteLine("Digite o pedido que quer excluir: !");
            string pedido = Convert.ToString(Console.ReadLine());

            base.ExcluirRegistro();
        }
    }
}
