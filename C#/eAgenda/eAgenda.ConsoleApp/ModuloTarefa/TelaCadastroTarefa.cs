using eAgenda.ConsoleApp.Compartilhado;
using eAgenda.ConsoleApp.ModuloItem;
using System;
using System.Collections.Generic;

namespace eAgenda.ConsoleApp.ModuloTarefa
{
    public class TelaCadastroTarefa : TelaBase, ITelaCadastrvel
    {
        private readonly Notificador notificador;
        private readonly IRepositorio<Tarefa> repositorioTarefa;
        public Item item;
        

        public TelaCadastroTarefa(IRepositorio<Tarefa> repositorioTarefa, Notificador notificador)
            : base("Cadastro de Tarefas") 
        {
            this.notificador = notificador;
            this.repositorioTarefa = repositorioTarefa;
        }

        public override string MostrarOpcoes()
        {
            MostrarTitulo(Titulo);

            Console.WriteLine("Digite 1 para Inserir");
            Console.WriteLine("Digite 2 para Editar");
            Console.WriteLine("Digite 3 para Excluir");
            Console.WriteLine("Digite 4 para Visualizar todas as tarefas");
            Console.WriteLine("Digite 5 para Visualizar tarefas pendentes");
            Console.WriteLine("Digite 6 para Visualizar tarefas concluídas");
            
            Console.WriteLine("Digite s para sair");

            string opcao = Console.ReadLine();

            return opcao;
        }

        private Tarefa ObterTarefa()
        {
            Console.Write("Digite o Título: ");
            string titulo = Console.ReadLine();

            Console.Write("Digite a data de criação: ");
            DateTime dataCriacao = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Digite a data de conclsão: ");
            DateTime dataConclusao = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Digite a prioridade da tarefa: \n" +
                "3 - Alta\n" +
                "2 - Normal\n" +
                "1 - Baixa\n");
            int prioridade = Convert.ToInt32(Console.ReadLine());

            Tarefa tarefa = new Tarefa(titulo, dataCriacao, dataConclusao, prioridade);

            return tarefa;
        }

        public void InserirRegistro()
        {
            MostrarTitulo("Inserindo nova Tarefa");

            Tarefa novaTarefa = ObterTarefa();
            
            repositorioTarefa.Inserir(novaTarefa);

            notificador.ApresentarMensagem("Tarefa inserida com sucesso!", TipoMensagem.Sucesso);

        }
        public void EditarRegistro()
        {
            MostrarTitulo("Editando Tarefa");

            bool temTarefasCadastradas = VisualizarRegistros("Pesquisando");

            if(temTarefasCadastradas == false)
            {
                notificador.ApresentarMensagem("Nenhuma Tarefa cadastrada para editar", TipoMensagem.Atencao);
                return;
            }
            int numeroTarefa = ObterNumeroTarefa();

            Tarefa tarefaAtualizada = ObterTarefa();

            bool conseguiuEditar = repositorioTarefa.Editar(x => x.numero == numeroTarefa, tarefaAtualizada);

            if (!conseguiuEditar)
                notificador.ApresentarMensagem("Não foi possível editar.", TipoMensagem.Erro);
            else
                notificador.ApresentarMensagem("Tarefa editada com sucesso.", TipoMensagem.Sucesso);

        }
        public void ExcluirRegistro()
        {
            MostrarTitulo("Excluindo Tarefa");

            bool temTarefasCadastradas = VisualizarRegistros("Pesquisando");

            if(temTarefasCadastradas == false)
            {
                notificador.ApresentarMensagem("Nenhuma tarefa cadastrada para excluir", TipoMensagem.Atencao);
                return;
            }

            int numeroTarefa = ObterNumeroTarefa();

            bool conseguiuExcluir = repositorioTarefa.Excluir(x => x.numero == numeroTarefa);

            if (!conseguiuExcluir)
                notificador.ApresentarMensagem("Não foi possível excluir", TipoMensagem.Erro);
            else
                notificador.ApresentarMensagem("Tarefa excluída com sucesso", TipoMensagem.Sucesso);

        }
        public bool VisualizarRegistros(string tipo)
        {
            if (tipo == "Tela")
                MostrarTitulo("Visualização de Tarefas");

            List<Tarefa> tarefas = repositorioTarefa.SelecionarTodos();

            if (tarefas.Count == 0)
            {
                notificador.ApresentarMensagem("Não há nenhuma tarefa disponível.", TipoMensagem.Atencao);
                return false;
            }

            foreach (Tarefa tarefa in tarefas)
                Console.WriteLine(tarefa.ToString());

            Console.ReadLine();

            return true;
        }

        public bool VisualizarTarefasPendentes(string tipo)
        {
            if (tipo == "Tela")
                MostrarTitulo("Visualização de Tarefas Pendentes");

            List<Tarefa> tarefasPendentes = repositorioTarefa.Filtrar(x => x.TemTarefaPedente());

            if(tarefasPendentes.Count == 0)
            {
                notificador.ApresentarMensagem("Não há nenhuma tarefa Pendente disponível para visualização.", TipoMensagem.Atencao);
                return false;
            }

            foreach (Tarefa tarefa in tarefasPendentes)
            {
                if (tarefa.estaPendente)
                    Console.WriteLine(tarefa.ToString());
            }
            
            Console.ReadLine();

            return true;
        }
        public bool VisualizarTarefasConcluidas(string tipo)
        {
            if (tipo == "Tela")
                MostrarTitulo("Visualização de Tarefas Concluidas");

            List<Tarefa> tarefasConcluidas = repositorioTarefa.Filtrar(x => x.TemTarefaConcluida());

            if (tarefasConcluidas.Count == 0)
            {
                notificador.ApresentarMensagem("Não há nenhuma tarefa concluída disponível para visualização.", TipoMensagem.Atencao);
                return false;
            }

            foreach (Tarefa tarefa in tarefasConcluidas)
                Console.WriteLine(tarefa.ToString());

            Console.ReadLine();

            return true;
        }

        private int ObterNumeroTarefa()
        {
            int numeroTarefa;
            bool numeroCadastradoEncontrado;

            do
            {
                Console.Write("Digite o número da tarefa que deseja selecionar: ");
                numeroTarefa = Convert.ToInt32(Console.ReadLine());

                numeroCadastradoEncontrado = repositorioTarefa.ExisteRegistro(x => x.numero == numeroTarefa);

                if (numeroCadastradoEncontrado == false)
                    notificador.ApresentarMensagem("Número de cadastro não encontrado, digite novamente", TipoMensagem.Atencao);
                    
            } while (numeroCadastradoEncontrado == false);

            return numeroTarefa;
        }

    }
}
