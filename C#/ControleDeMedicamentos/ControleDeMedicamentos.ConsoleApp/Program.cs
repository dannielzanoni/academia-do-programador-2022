using ControleDeMedicamentos.ConsoleApp.Compartilhado;
using ControleDeMedicamentos.ConsoleApp.ModuloMedicamento;
using System;

namespace ControleDeMedicamentos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notificador notificador = new Notificador();
            TelaMenuPrincipal menuPrincipal = new TelaMenuPrincipal(notificador);

            while (true)
            {
                TelaBase telaSelecionada = menuPrincipal.ObterTela();

                if (telaSelecionada is null)
                    return;

                string opcaoSelecionada = telaSelecionada.MostrarOpcoes();

                if (telaSelecionada is ITelaCadastravel)
                {
                    ITelaCadastravel telaCadastravel = (ITelaCadastravel)telaSelecionada;

                    if (opcaoSelecionada == "1")
                        telaCadastravel.Inserir();

                    else if (opcaoSelecionada == "2")
                        telaCadastravel.Editar();

                    else if (opcaoSelecionada == "3")
                        telaCadastravel.Excluir();

                    else if (opcaoSelecionada == "4")
                        telaCadastravel.VisualizarRegistros("Tela");    
                }
                else if (telaSelecionada is TelaCadastroMedicamento)
                {
                    GerenciarCadastroMedicamentos(telaSelecionada, opcaoSelecionada);
                }
            }
        }
        private static void GerenciarCadastroMedicamentos(TelaBase telaSelecionada, string opcaoSelecionada)
        {
            TelaCadastroMedicamento telaCadastroMedicamento = telaSelecionada as TelaCadastroMedicamento;


            if (telaCadastroMedicamento is null)
                return;

            if(opcaoSelecionada == "1")
                telaCadastroMedicamento.Inserir();

            if(opcaoSelecionada == "2")
                telaCadastroMedicamento.Editar();

            if(opcaoSelecionada == "3")
                telaCadastroMedicamento.Excluir();

            if(opcaoSelecionada == "4")
                telaCadastroMedicamento.VisualizarRegistros(opcaoSelecionada);

            if(opcaoSelecionada == "5")
                telaCadastroMedicamento.VisualizarMedicamentosEmFalta(opcaoSelecionada);


        }
    }
}
