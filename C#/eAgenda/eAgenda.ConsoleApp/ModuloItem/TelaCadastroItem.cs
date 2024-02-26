using eAgenda.ConsoleApp.Compartilhado;
using eAgenda.ConsoleApp.ModuloTarefa;
using System;
using System.Collections.Generic;

namespace eAgenda.ConsoleApp.ModuloItem
{
    public class TelaCadastroItem : TelaBase, ITelaCadastrvel
    {
        private readonly TelaCadastroTarefa telaCadastroTarefa;
        private readonly IRepositorio<Tarefa> repositorioTarefa;
        private readonly IRepositorio<Item> repositorioItem;

        private readonly List<Item> listaItensPedentes = new List<Item>();
        private readonly List<Item> listaItensConcluidos = new List<Item>();

        private Notificador notificador;

        public TelaCadastroItem(
            TelaCadastroTarefa telaCadastroTarefa,
            IRepositorio<Tarefa> repositorioTarefa,
            IRepositorio<Item> repositorioItem,
            Notificador notificador) : base("Cadastro de Itens")
        {
            this.telaCadastroTarefa = telaCadastroTarefa;
            this.repositorioTarefa = repositorioTarefa;
            this.repositorioItem = repositorioItem;
            this.notificador = notificador;
        }

        public void InserirRegistro()
        {
            MostrarTitulo("Inserindo novo Item");

            //Validacao Tarefa
            Tarefa tarefaSelecionada = ObtemTarefa();

            if (tarefaSelecionada == null)
            {
                notificador.ApresentarMensagem("Cadastre uma Tarefa antes para cadastrar Itens", TipoMensagem.Atencao);
                return;
            }

            Item novoItem = ObterItem(tarefaSelecionada);

            if (novoItem.EstaPendente)
            {
                listaItensPedentes.Add(novoItem);
            }
            else
            {
                listaItensConcluidos.Add(novoItem);
            }

            string statusValidacao = repositorioItem.Inserir(novoItem);

            if (statusValidacao == "REGISTRO_VALIDO")
                notificador.ApresentarMensagem("Item inserido com sucesso", TipoMensagem.Sucesso);

            else
                notificador.ApresentarMensagem(statusValidacao, TipoMensagem.Erro);
        }
        public void EditarRegistro()
        {
            MostrarTitulo("Editando Item");

            bool temItensCadastrados = VisualizarRegistros("Pesquisando");

            if (temItensCadastrados == false)
            {
                notificador.ApresentarMensagem("Nenhuma Item cadastrado para poder editar", TipoMensagem.Atencao);
                return;
            }

            int numeroItem = ObterNumItem();

            Console.WriteLine();

            Tarefa tarefaSelecionada = ObtemTarefa();

            Item ItemAtualizado = ObterItem(tarefaSelecionada);

            bool conseguiuEditar = repositorioItem.Editar(x => x.numero == numeroItem, ItemAtualizado);

            if (!conseguiuEditar)
                notificador.ApresentarMensagem("Não foi possível excluir.", TipoMensagem.Erro);
            else
                notificador.ApresentarMensagem("Item editado com sucesso", TipoMensagem.Sucesso);

        }
        public void ExcluirRegistro()
        {
            MostrarTitulo("Excluindo Item");

            bool temItensCadastrados = VisualizarRegistros("Pesquisando");

            if (temItensCadastrados == false)
            {
                notificador.ApresentarMensagem("Nenhum Item cadastrado para poder excluir", TipoMensagem.Atencao);
                return;
            }

            int numeroItem = ObterNumItem();

            Console.WriteLine();

            Tarefa tarefaSelecionada = ObtemTarefa();

            bool conseguiuExcluir = repositorioItem.Excluir(x => x.numero == numeroItem);

            if (!conseguiuExcluir)
                notificador.ApresentarMensagem("Não foi possível excluir.", TipoMensagem.Atencao);
            else
                notificador.ApresentarMensagem("Item excluído com sucesso.", TipoMensagem.Sucesso);
        }
        public bool VisualizarRegistros(string tipo)
        {
            if (tipo == "Tela")
                MostrarTitulo("Visualização de Itens");

            List<Item> Itens = repositorioItem.SelecionarTodos();

            if(Itens.Count == 0)
            {
                notificador.ApresentarMensagem("Não há nenhum item disponível.", TipoMensagem.Atencao);
                return false;
            }

            foreach(Item item in Itens)
                Console.WriteLine(item.ToString());

            Console.ReadLine();

            return true;
        }

        #region Métodos privados
        private Tarefa ObtemTarefa()
        {
            bool temTarefasDisponiveis = telaCadastroTarefa.VisualizarRegistros("");

            if (!temTarefasDisponiveis)
            {
                notificador.ApresentarMensagem("Não há nenhuma Tarefa disponível para cadastrar Itens", TipoMensagem.Atencao);
                return null;
            }

            Console.Write("Digite o número da Tarefa que irá inserir: ");
            int numTarefaSelecionada = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Tarefa tarefaSelecionada = repositorioTarefa.SelecionarRegistro(x => x.numero == numTarefaSelecionada);

            return tarefaSelecionada;
        }
        private Item ObterItem(Tarefa tarefaSelecionada)
        {
            Console.Write("Digite a descrição do Item: ");
            string descricao = Console.ReadLine();

            Console.Write("Status do Item: \n" +
                "1 - Pendente\n" +
                "2 - Concluído\n");
            int statusItem = Convert.ToInt32(Console.ReadLine());

            Item novoItem = new Item(descricao, statusItem, tarefaSelecionada);

            return novoItem;
        }
        private int ObterNumItem()
        {
            int numeroItem;
            bool numeroItemEncontrado;

            do
            {
                Console.Write("Digite o número do Item que deseja selecionar: ");
                numeroItem = Convert.ToInt32(Console.ReadLine());

                numeroItemEncontrado = repositorioItem.ExisteRegistro(x => x.numero == numeroItem);

                if (numeroItemEncontrado == false)
                    notificador.ApresentarMensagem("Número de Item não encontrado, digite novamente", TipoMensagem.Atencao);

            } while (numeroItemEncontrado == false);

            return numeroItem;
        }

        #endregion
    }
}
