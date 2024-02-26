using System;
using eAgenda.ConsoleApp.ModuloTarefa;
using eAgenda.ConsoleApp.ModuloItem;
using eAgenda.ConsoleApp.ModuloContatos;

namespace eAgenda.ConsoleApp.Compartilhado
{
    public class TelaMenuPrincipal
    {
        private string opcaoSelecionada;

        private IRepositorio<Tarefa> repositorioTarefa;
        private TelaCadastroTarefa telaCadastroTarefa;

        private IRepositorio<Item> repositorioItem;
        private TelaCadastroItem telaCadastroItem;

        private IRepositorio<Contato> repositorioContato;
        private TelaCadastroContato telaCadastroContato;

        public TelaMenuPrincipal(Notificador notificador)
        {
            repositorioTarefa = new RepositorioTarefa();

            repositorioItem = new RepositorioItem();

            telaCadastroTarefa = new TelaCadastroTarefa(repositorioTarefa, notificador);
            telaCadastroItem = new TelaCadastroItem(telaCadastroTarefa, repositorioTarefa, repositorioItem, notificador);
            telaCadastroContato = new TelaCadastroContato(repositorioContato, notificador);
        }
        public string MostrarOpcoes()
        {
            Console.Clear();

            Console.WriteLine("eAgenda");

            Console.WriteLine();

            Console.WriteLine("Digite 1 para Gerenciar Tarefas");
            Console.WriteLine("Digite 2 para Gerenciar Itens");
            Console.WriteLine("Digite 3 para Gerenciar Contatos");

            
            Console.WriteLine("Digite s para Sair");

            opcaoSelecionada = Console.ReadLine();

            return opcaoSelecionada;
        }
        public TelaBase ObterTela()
        {
            string opcao = MostrarOpcoes();

            TelaBase tela = null;

            if (opcao == "1")
                tela = telaCadastroTarefa;

            else if (opcao == "2")
                tela = telaCadastroItem;

            else if (opcao == "3")
                tela = telaCadastroContato;

            return tela;
        }

    }
}
