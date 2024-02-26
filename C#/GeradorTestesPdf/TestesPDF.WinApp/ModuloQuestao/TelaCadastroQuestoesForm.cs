using FluentValidation.Results;
using System;
using System.Windows.Forms;
using TestesPDF.Dominio.ModuloQuestao;
using TestesPDF.Dominio.ModuloDisciplina;
using TestesPDF.Dominio.ModuloMateria;
using System.Collections.Generic;

namespace TestesPDF.WinApp.ModuloQuestao
{
    public partial class TelaCadastroQuestoesForm : Form
    {
        private Questao questao;
        private readonly ControladorQuestao controladorQuestao;

        public TelaCadastroQuestoesForm(List<Disciplina> disciplinas, List<Materia> materias)
        {
            InitializeComponent();

            CarregarDisciplinasEMaterias(disciplinas, materias);
        }

        private void CarregarDisciplinasEMaterias(List<Disciplina> disciplinas, List<Materia> materias)
        {
            cmbDisciplinas.Items.Clear();

            foreach (var item in disciplinas)
            {
                cmbDisciplinas.Items.Add(item);
            }

            cmbMaterias.Items.Clear();

            foreach (var item in materias)
            {
                cmbMaterias.Items.Add(item);
            }
        }

        public Func<Questao, ValidationResult> GravarRegistro { get; set; }

        public Questao Questao
        {
            get { return questao; }
            set{
                questao = value;
                txtNumero.Text = questao.Numero.ToString();
                txtRichEnunciado.Text = questao.Enunciado;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            questao.Enunciado = txtRichEnunciado.Text;
            questao.Disciplina = (Disciplina)cmbDisciplinas.SelectedItem;
            questao.Materia = (Materia)cmbMaterias.SelectedItem;

            var resultadoValidacao = GravarRegistro(questao);

            if (resultadoValidacao.IsValid == false)
            {
                string erro = resultadoValidacao.Errors[0].ErrorMessage;

                TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

        }
    }
}
