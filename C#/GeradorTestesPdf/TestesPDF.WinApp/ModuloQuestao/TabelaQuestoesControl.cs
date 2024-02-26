using System.Collections.Generic;
using System.Windows.Forms;
using TestesPDF.WinApp.Compartilhado;
using TestesPDF.Dominio.Compartilhado;
using TestesPDF.Dominio.ModuloQuestao;

namespace TestesPDF.WinApp.ModuloQuestao
{
    public partial class TabelaQuestoesControl : UserControl
    {
        public TabelaQuestoesControl()
        {
            InitializeComponent();

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
            grid.Columns.AddRange(ObterColunas());
        }
        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Numero", HeaderText = "Número"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Enunciado", HeaderText = "Enunciado"},

                new DataGridViewTextBoxColumn {DataPropertyName = "Disciplina", HeaderText = "Disciplina"},

                new DataGridViewTextBoxColumn {DataPropertyName = "Matéria", HeaderText = "Matéria"}
            };

            return colunas;
        }
        public int ObtemNumeroQuestaoSelecionada()
        {
            return grid.SelecionarNumero<int>();
        }

        internal void AtualizarRegistros(List<Questao> questoes)
        {
            grid.DataSource = questoes;

        }
    }
}
