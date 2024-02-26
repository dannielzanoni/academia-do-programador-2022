using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestesPDF.Dominio.ModuloDisciplina;
using TestesPDF.WinApp.Compartilhado;

namespace TestesPDF.WinApp.ModuloDisciplina
{
    public partial class TabelaDisciplinasControl : UserControl
    {
        public TabelaDisciplinasControl()
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

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},
            };

            return colunas;
        }
        public int ObtemNumeroDisciplinaSelecionada()
        {
            return grid.SelecionarNumero<int>();
        }

        internal void AtualizarRegistros(List<Disciplina> disciplinas)
        {
            grid.DataSource = disciplinas;

        }
    }
}
