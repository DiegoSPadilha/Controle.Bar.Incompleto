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
                if (opcao == "2")
                {
                    string opcaoGarcom = telacliente.ApresentarMenu();
                    if (opcaoGarcom == "1")
                        telacliente.InserirNovoRegistro();
                    if (opcaoGarcom == "2")
                        telacliente.EditarRegistro();
                    if (opcaoGarcom == "3")
                        telacliente.ExcluirRegistro();
                    if (opcaoGarcom == "4") ;
                       telacliente.VisualizarRegistros(true);
                    continue;   
                }
                if(opcao == "3")
                {
                    string opcaoCliente = telacliente.ApresentarMenu();
                    if (opcaoCliente == "1")
                        telacliente.InserirNovoRegistro();
                    if (opcaoCliente == "2")
                        telacliente.EditarRegistro();
                    if (opcaoCliente == "3")
                        telacliente.ExcluirRegistro();
                    if (opcaoCliente == "4") ;
                    telacliente.VisualizarRegistros(true);
                    continue;
                }
                if (opcao == "4") 
                {
                    string opcaoConta = telaConta.ApresentarMenu();
                    if (opcaoConta == "1")
                        telaConta.InserirNovoRegistro();
                    if (opcaoConta == "2")
                        telaConta.EditarRegistro();
                    if (opcaoConta == "3")
                        telaConta.ExcluirRegistro();
                    if (opcaoConta == "4") ;
                    telaConta.VisualizarRegistros(true);
                    continue;
                }


            }
        }
    }
}