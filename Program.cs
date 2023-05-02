using Controle.Bar.ModuloCliente;
using Controle.Bar.ModuloCompartilhado;
using Controle.Bar.ModuloConta;
using Controle.Bar.ModuloFuncionario;
using Controle.Bar.ModuloGarcom;
using System.Collections;
using System.Reflection;

namespace Controle.Bar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RepositorioCliente repositorioCliente = new RepositorioCliente(new ArrayList());
            RepositorioConta repositoriConta = new RepositorioConta(new ArrayList());
            RepositorioFuncionario repositorioFuncionario = new RepositorioFuncionario(new ArrayList());
            RepositorioGarcom repositorioGarcom = new RepositorioGarcom(new ArrayList());
            TelaConta telaConta = new TelaConta(repositoriConta);
            TelaCliente telacliente = new TelaCliente(repositorioCliente);
            TelaFuncionario telaFuncionario = new TelaFuncionario(repositorioFuncionario);
            TelaGarcom telaGarcom = new TelaGarcom(repositorioGarcom);

            TelaPrincipal apresentarTelaPrincipal = new TelaPrincipal();

            while (true)
            {
                Console.WriteLine("Digite S para sair");

                string opcao = TelaPrincipal.apresentarTelaPrincipal();

                if(opcao == "s")
                    break;
                if (opcao == "1") 
                {
                    string opcaoFuncionario = telaFuncionario.ApresentarMenu();
                    if (opcaoFuncionario == "1")
                        telaFuncionario.InserirNovoRegistro();
                    if (opcaoFuncionario == "2")
                        telaFuncionario.EditarRegistro();
                    if(opcaoFuncionario == "3")
                       telaFuncionario.ExcluirRegistro();
                    if (opcaoFuncionario == "4");
                       telaFuncionario.VisualizarRegistros(true);
                    continue;
                }

            }
    }
}