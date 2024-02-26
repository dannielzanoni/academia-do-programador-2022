using System;
using System.Collections.Generic;
using eAgenda.ConsoleApp.Compartilhado;
using eAgenda.ConsoleApp.ModuloItem;

namespace eAgenda.ConsoleApp.ModuloTarefa
{
    public class Tarefa : EntidadeBase
    {
        private readonly string tituloTarefa;
        protected DateTime dataCriacao;
        private readonly DateTime dataConclusao;
        private readonly int percentualTarefa;
        private readonly int prioridade;
        private string statusTarefa;

        public Item item;

        public string TituloTarefa => tituloTarefa;

        public bool estaPendente;

        private readonly List<Tarefa> historicoTarefaPendente = new List<Tarefa>();
        private readonly List<Tarefa> historicoTarefaConcluida = new List<Tarefa>();


        public Tarefa(string tituloTarefa, DateTime dataCriacao, DateTime dataConclusao, int prioridade)
        {
            this.tituloTarefa = tituloTarefa;
            this.dataCriacao = dataCriacao;
            this.dataConclusao = dataConclusao;
            this.prioridade = prioridade;
        }

        public void DefinirVariaveis()
        {
            statusTarefa = DefinirPercentualStatusTarefa(statusTarefa);

            RegistrarTarefaConcluida(this);
            RegistrarTarefaPendente(this);
            
        }

        public string DefinirPrioridade()
        {
            string stgPrioridade = DefinirPrioridadeTarefa(prioridade);

            if (stgPrioridade == "Concluído")
                estaPendente = false;

            else if (stgPrioridade == "Pendente")
                estaPendente = true;

            RegistrarTarefaPendente(this);
            RegistrarTarefaConcluida(this);


            return stgPrioridade;
        }

        public override string ToString()
        {
            string stgPrioridade = DefinirPrioridade();
            DefinirVariaveis();

            return "Número: " + numero + Environment.NewLine +
                "Título da tarefa: " + tituloTarefa + Environment.NewLine +
                "Data de criação: " + dataCriacao.Day + "/" + dataConclusao.Month + "/" + dataCriacao.Year + Environment.NewLine +
                "Data de conclusão: "+dataConclusao.Day + "/" + dataConclusao.Month + "/" + dataConclusao.Year + Environment.NewLine +
                "Status da Tarefa: " + statusTarefa + " (" + percentualTarefa + "%)" + Environment.NewLine +
                "Prioridade: " + prioridade + " - " + stgPrioridade + Environment.NewLine;
        }
        public void RegistrarTarefaPendente(Tarefa tarefa)
        {
           if(tarefa.estaPendente)
                historicoTarefaPendente.Add(tarefa);
        }
        public void RegistrarTarefaConcluida(Tarefa tarefa)
        {
            if (tarefa.estaPendente == false)
                historicoTarefaConcluida.Add(tarefa);
        }

        public void Concluir()
        {
            if (!estaPendente)
            {
                estaPendente = true;
            }
        }
        public void Pendente()
        {
            if (estaPendente)
                estaPendente = false;
        }
        public bool TemTarefaPedente()
        {
            bool temTarefaPedente = false;

            foreach (Tarefa tarefa in historicoTarefaPendente)
            {
                if (tarefa.estaPendente)
                {
                    temTarefaPedente = true;
                    break;
                }
            }
            return temTarefaPedente;
        }
        public bool TemTarefaConcluida()
        {
            bool temTarefaConcluida = false;

            foreach (Tarefa tarefa in historicoTarefaConcluida)
            {
                if (tarefa.estaPendente == false)
                {
                    temTarefaConcluida = true;
                    break;
                }
            }
            return temTarefaConcluida;
        }
        public string DefinirPercentualStatusTarefa(string status)
        {
            if (percentualTarefa == 100)
                status = "Concluído";
            else
                status = "Pendente";

            return status;
        }
        public string DefinirPrioridadeTarefa(int prioridade)
        {
            string stgPrioridade = "";

            if (prioridade == 1)
            {
                stgPrioridade = "Baixa";
                return stgPrioridade;
            }
            if (prioridade == 2)
            {
                stgPrioridade = "Normal";
                return stgPrioridade;
            }
            if (prioridade == 3)
            {
                stgPrioridade = "Alta";
                return stgPrioridade;
            }

            return null;
        }

    }
}
