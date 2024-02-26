using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeradorDeTestes.Compartilhado;

namespace GeradorDeTestes
{
    public partial class TelaPrincipalForm : Form
    {

        //Controladores
        private ControladorBase controlador;
        private Dictionary<string, ControladorBase> controladores;

        public TelaPrincipalForm()
        {
            InitializeComponent();
           
        }
        
        private void btnDisciplinas_Click(object sender, EventArgs e)
        {
           
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }
        private void InicializarControladores()
        {
            
        }
    }
}
