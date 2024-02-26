using System.Collections.Generic;
using System.Windows.Forms;
using TestesPDF.Dominio.ModuloDisciplina;
using TestesPDF.WinApp.Compartilhado;

namespace TestesPDF.WinApp.ModuloDisciplina
{
    internal class ControladorDisciplina : ControladorBase
    {
        private readonly IRepositorioDisciplina repositorioDisciplina;
        private TabelaDisciplinasControl tabelaDisciplinas;
        public ControladorDisciplina(IRepositorioDisciplina repositorioContato)
        {
            this.repositorioDisciplina = repositorioContato;
        }
        public override void Editar()
        {
            Disciplina disciplinaSelecionada = ObtemDisciplinaSelecionado();

            if (disciplinaSelecionada == null)
            {
                MessageBox.Show("Selecione uma disciplina primeiro",
                "Edição de Disciplinas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaCadastroDisciplinaForm tela = new TelaCadastroDisciplinaForm();

            tela.Disciplina = disciplinaSelecionada;

            tela.GravarRegistro = repositorioDisciplina.Editar;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarDisciplinas();
            }
        }

        private Disciplina ObtemDisciplinaSelecionado()
        {
            var numero = tabelaDisciplinas.ObtemNumeroDisciplinaSelecionada();

            return repositorioDisciplina.SelecionarPorNumero(numero);
        }

        public override void Excluir()
        {
            Disciplina disciplinaSelecionada = ObtemDisciplinaSelecionado();

            if (disciplinaSelecionada == null)
            {
                MessageBox.Show("Selecione uma disciplinaa primeiro",
                "Exclusão de Disciplina", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir a disciplina?",
                "Exclusão de Contatos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioDisciplina.Excluir(disciplinaSelecionada);
                CarregarDisciplinas();
            }
        }

        public override void Inserir()
        {
            TelaCadastroDisciplinaForm tela = new TelaCadastroDisciplinaForm();
            tela.Disciplina = new Disciplina();

            tela.GravarRegistro = repositorioDisciplina.Inserir;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarDisciplinas();
            }
        }

        private void CarregarDisciplinas()
        {
            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();

            tabelaDisciplinas.AtualizarRegistros(disciplinas);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {disciplinas.Count} disciplina(s)");
        }

        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxDisciplina();
        }

        public override UserControl ObtemListagem()
        {
            if (tabelaDisciplinas == null)
                tabelaDisciplinas = new TabelaDisciplinasControl();

            CarregarDisciplinas();

            return tabelaDisciplinas;
        }
    }
}
