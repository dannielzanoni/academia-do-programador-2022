using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TestesPDF.Dominio.ModuloQuestao;
using TestesPDF.WinApp.Compartilhado;
using TestesPDF.Dominio.ModuloDisciplina;
using TestesPDF.Dominio.ModuloMateria;  

namespace TestesPDF.WinApp.ModuloQuestao
{
    class ControladorQuestao : ControladorBase
    {
        private readonly IRepositorioQuestao repositorioQuestao;
        private readonly IRepositorioDisciplina repositorioDisciplina;
        private readonly IRepositorioMateria repositorioMateria;

        private TabelaQuestoesControl tabelaQuestoes;

        public ControladorQuestao(IRepositorioQuestao repositorioQuestao, IRepositorioDisciplina repositorioDisciplina,
            IRepositorioMateria repositorioMateria)
        {
            this.repositorioQuestao = repositorioQuestao;
            this.repositorioMateria = repositorioMateria;
            this.repositorioDisciplina = repositorioDisciplina;
        }

        public override void Editar()
        {
            Questao questaoSelecionada = ObtemQuestaoSelecionado();

            if (questaoSelecionada == null)
            {
                MessageBox.Show("Selecione uma questão primeiro",
                "Edição de Questão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            var disciplinas = repositorioDisciplina.SelecionarTodos();

            var materias = repositorioMateria.SelecionarTodos();

            TelaCadastroQuestoesForm tela = new TelaCadastroQuestoesForm(disciplinas, materias);

            tela.Questao = questaoSelecionada;

            tela.GravarRegistro = repositorioQuestao.Editar;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarQuestoes();
            }
        }

        private void CarregarQuestoes()
        {
            List<Questao> questoes = repositorioQuestao.SelecionarTodos();

            tabelaQuestoes.AtualizarRegistros(questoes);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {questoes.Count} questões(s)");
        }

        private Questao ObtemQuestaoSelecionado()
        {
            var numero = tabelaQuestoes.ObtemNumeroQuestaoSelecionada();

            return repositorioQuestao.SelecionarPorNumero(numero);
        }

        public override void Excluir()
        {
            Questao questaoSelecionada = ObtemQuestaoSelecionado();

            if (questaoSelecionada == null)
            {
                MessageBox.Show("Selecione uma questão primeiro",
                    "Exclusão de Questão", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir a questão?",
                "Exclusão de Questão", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioQuestao.Excluir(questaoSelecionada);
                CarregarQuestoes();
            }
        }

        public override void Inserir()
        {
            var disciplinas = repositorioDisciplina.SelecionarTodos();

            var materias = repositorioMateria.SelecionarTodos();

            TelaCadastroQuestoesForm tela = new TelaCadastroQuestoesForm(disciplinas, materias);
            tela.Questao = new Questao();

            tela.GravarRegistro = repositorioQuestao.Inserir;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarQuestoes();
            }
        }

        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxQuestao();
        }

        public override UserControl ObtemListagem()
        {
            if (tabelaQuestoes == null)
                tabelaQuestoes = new TabelaQuestoesControl();

            CarregarQuestoes();

            return tabelaQuestoes;
        }
      }
}

