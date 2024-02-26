using ControleDeMedicamentos.ConsoleApp.ModuloFornecedor;
using ControleDeMedicamentos.ConsoleApp.ModuloFuncionario;
using ControleDeMedicamentos.ConsoleApp.ModuloPaciente;
using ControleDeMedicamentos.ConsoleApp.ModuloMedicamento;
using System;

namespace ControleDeMedicamentos.ConsoleApp.Compartilhado
{
    public class TelaMenuPrincipal
    {
        private RepositorioFuncionario repositorioFuncionario;
        private TelaCadastroFuncionario telaCadastroFuncionario;

        private RepositorioFornecedor repositorioFornecedor;
        private TelaCadastroFornecedor telaCadastroFornecedor;

        //Paciente
        private RepositorioPaciente repositorioPaciente;
        private TelaCadastroPaciente telaCadastroPaciente;

        //Medicamento
        private RepositorioMedicamento repositorioMedicamento;
        private TelaCadastroMedicamento telaCadastroMedicamento;

        //Requisicao

        public TelaMenuPrincipal(Notificador notificador)
        {
            repositorioFuncionario = new RepositorioFuncionario();
            telaCadastroFuncionario = new TelaCadastroFuncionario(repositorioFuncionario, notificador);

            repositorioFornecedor = new RepositorioFornecedor();
            telaCadastroFornecedor = new TelaCadastroFornecedor(repositorioFornecedor, notificador);

            repositorioPaciente = new RepositorioPaciente();
            telaCadastroPaciente = new TelaCadastroPaciente(repositorioPaciente, notificador);

            repositorioMedicamento = new RepositorioMedicamento();
            telaCadastroMedicamento = new TelaCadastroMedicamento(repositorioMedicamento, notificador);
        }

        public string MostrarOpcoes()
        {
            Console.Clear();

            Console.WriteLine("Controle de Retirada de Medicamentos 1.0");

            Console.WriteLine();

            Console.WriteLine("Digite 1 para Gerenciar Funcionários");
            Console.WriteLine("Digite 2 para Gerenciar Fornecedores");
            Console.WriteLine("Digite 3 para Gerenciar Pacientes");
            Console.WriteLine("DIgite 4 para Gerenciar Medicamentos");


            Console.WriteLine("Digite s para sair");

            string opcaoSelecionada = Console.ReadLine();

            return opcaoSelecionada;
        }

        public TelaBase ObterTela()
        {
            string opcao = MostrarOpcoes(); 

            TelaBase tela = null;

            if (opcao == "1")
                tela = telaCadastroFuncionario;

            else if (opcao == "2")
                tela = telaCadastroFornecedor;

            else if (opcao == "3")
                tela = telaCadastroPaciente;

            else if (opcao == "4")
                tela = telaCadastroMedicamento;

            return tela;
        }
    }
}
