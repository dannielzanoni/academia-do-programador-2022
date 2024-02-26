using FluentValidation.Results;
using System;
using System.Windows.Forms;
using TestesPDF.Dominio.ModuloMateria;
using TestesPDF.Dominio.ModuloDisciplina;
using System.Collections.Generic;

namespace TestesPDF.WinApp.ModuloMateria
{
    public partial class TelaCadastroMateriaForm : Form
    {
        private Materia materia;
        private readonly ControladorMateria controladorMateria;
        public TelaCadastroMateriaForm(List<Disciplina> disciplinas)
        {
            InitializeComponent();

            CarregarDisciplinas(disciplinas);   
        }

        private void CarregarDisciplinas(List<Disciplina> disciplinas)
        {
            cmbDisciplinas.Items.Clear();

            foreach (var item in disciplinas)
            {
                cmbDisciplinas.Items.Add(item);
            }
        }

        public Func<Materia, ValidationResult> GravarRegistro { get; set; }

        public Materia Materia
        {
            get { return materia; }
            set
            {
                materia = value;

                txtNumero.Text = materia.Numero.ToString();

                txtNome.Text = materia.Nome;

                cmbDisciplinas.SelectedItem = materia.Disciplina != null;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            materia.Nome = txtNome.Text;
            materia.Disciplina = (Disciplina)cmbDisciplinas.SelectedItem;

            var resultadoValidacao = GravarRegistro(materia);

            if (resultadoValidacao.IsValid == false)
            {
                string erro = resultadoValidacao.Errors[0].ErrorMessage;

                TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }

        private void TelaCadastroMateriasForm_Load(object sender, EventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }

        private void TelaCadastroMateriasForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }

        private void btnGravar_Click_1(object sender, EventArgs e)
        {
            materia.Nome = txtNome.Text;
            materia.Disciplina = (Disciplina)cmbDisciplinas.SelectedItem;

            var resultadoValidacao = GravarRegistro(materia);

            if (resultadoValidacao.IsValid == false)
            {
                string erro = resultadoValidacao.Errors[0].ErrorMessage;

                TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }
    }
}
