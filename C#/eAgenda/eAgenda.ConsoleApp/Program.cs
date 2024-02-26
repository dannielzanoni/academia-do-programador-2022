using System;
using eAgenda.ConsoleApp.Compartilhado;
using eAgenda.ConsoleApp.ModuloTarefa;

namespace eAgenda.ConsoleApp
{
    internal class Program
    {
        static Notificador notificador = new Notificador();
        static TelaMenuPrincipal menuPrincipal = new TelaMenuPrincipal(notificador);
        static void Main(string[] args)
        {
            while (true)
            {
                TelaBase telaSelecionada = menuPrincipal.ObterTela();

                if (telaSelecionada is null)
                    return;

                string opcaoSelecionada = telaSelecionada.MostrarOpcoes();

                if (telaSelecionada is ITelaCadastrvel)
                    GerenciarCadastroBasico(telaSelecionada, opcaoSelecionada);
                else if (telaSelecionada is TelaCadastroTarefa)
                    GerenciarCadastroTarefa(telaSelecionada, opcaoSelecionada);
            }
        }

        private static void GerenciarCadastroBasico(TelaBase telaSelecionada, string opcaoSelecionada)
        {
            ITelaCadastrvel telaCadastroBasico = telaSelecionada as ITelaCadastrvel;

            if (telaCadastroBasico is null)
                return;

            if (opcaoSelecionada == "1")
                telaCadastroBasico.InserirRegistro();

            else if (opcaoSelecionada == "2")
                telaCadastroBasico.EditarRegistro();

            else if (opcaoSelecionada == "3")
                telaCadastroBasico.ExcluirRegistro();

            else if (opcaoSelecionada == "4")
                telaCadastroBasico.VisualizarRegistros("Tela");

            TelaCadastroTarefa telaCadastroTarefa = telaCadastroBasico as TelaCadastroTarefa;

            if (telaCadastroTarefa is null)
                return;

            else if (opcaoSelecionada == "5")
                telaCadastroTarefa.VisualizarTarefasPendentes("Tela");

            else if (opcaoSelecionada == "6")
                telaCadastroTarefa.VisualizarTarefasConcluidas("Tela");
        }
        private static void GerenciarCadastroTarefa(TelaBase telaSelecionada, string opcaoSelecionada)
        {
            TelaCadastroTarefa telaCadastroTarefa = telaSelecionada as TelaCadastroTarefa;

            if (telaCadastroTarefa is null)
                return;

            if (opcaoSelecionada == "1")
                telaCadastroTarefa.InserirRegistro();

            else if (opcaoSelecionada == "2")
                telaCadastroTarefa.EditarRegistro();

            else if (opcaoSelecionada == "3")
                telaCadastroTarefa.ExcluirRegistro();

            else if (opcaoSelecionada == "4")
                telaCadastroTarefa.VisualizarRegistros("Tela");
        }

    }
}
