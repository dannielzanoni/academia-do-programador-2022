using eAgenda.ConsoleApp.Compartilhado;
using eAgenda.ConsoleApp.ModuloTarefa;
using System;
using System.Collections.Generic;

namespace eAgenda.ConsoleApp.ModuloItem
{
    public class Item : EntidadeBase
    {
        private readonly string descricao;
        private readonly int statusItem;
        private bool estaPendente;

        public Tarefa tarefa;

        public string Descricao => descricao;
        public bool EstaPendente => estaPendente;

        public Item(string descricao, int statusItem, Tarefa tarefaSelecionada)
        {
            this.descricao = descricao;
            this.statusItem = statusItem;

            tarefa = tarefaSelecionada;
        }
        public override string ToString()
        {
            string stgStatusItem = DefinirStatusItem(estaPendente);

            return "Número: " + numero + Environment.NewLine +
                "Descrição: " + descricao + Environment.NewLine +
                "Status: " + stgStatusItem + Environment.NewLine +
                "Tarefa: " + tarefa.TituloTarefa + Environment.NewLine;
        }
        public string DefinirStatusItem(bool estaPendente)
        {
            string stgStatusItem = "";

            if (statusItem == 1)
            {
                stgStatusItem = "Pendente";
                return stgStatusItem;
            }else if(statusItem == 2)
            {
                stgStatusItem = "Concluído";
                return stgStatusItem;
            }

            return stgStatusItem;
        }        

        public ResultadoValidacao Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(descricao))
                erros.Add("É necessário incluir uma descrição");

            return new ResultadoValidacao(erros);
        }
    }
}
