using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle.Bar
{
    internal class TelaPrincipal
    {
        internal static string apresentarTelaPrincipal()
        {
            throw new NotImplementedException();
        }

        public string TelaBase()
        {
            Console.Clear();

            Console.WriteLine("Controle de Bar\n");

            Console.WriteLine("Digite 1 para cadastrar Produto");
            Console.WriteLine("Digite 2 para cadastrar Mesa");
            Console.WriteLine("Digite 3 para cadastrar Garcom");
            Console.WriteLine("Digite 4 para cadastrar Pedido");
            Console.WriteLine("Digite 5 para cadastrar Conta\n");

            Console.WriteLine("Digite s para Sair");

            string opcao = Console.ReadLine();

            return opcao;
        }
    }
}
