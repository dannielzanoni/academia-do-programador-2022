using System;
using System.Collections.Generic;
using TestesPDF.Infra.Arquivos;
using TestesPDF.Infra.Arquivos.ModuloDisciplina;
using TestesPDF.Infra.Arquivos.ModuloMateria;
using TestesPDF.Infra.Arquivos.ModuloQuestao;
using TestesPDF.WinApp.ModuloDisciplina;
using TestesPDF.WinApp.ModuloMateria;
using TestesPDF.WinApp.ModuloQuestao;
using TestesPDF.WinApp.Compartilhado;
using System.Windows.Forms;

namespace TestesPDF.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;
        private Dictionary<string, ControladorBase> controladores;
        private DataContext contextoDados;
        public TelaPrincipalForm(DataContext contextoDados)
        {
            InitializeComponent();
            Instancia = this;

            labelRodape.Text = string.Empty;
            labelTipoCadastro.Text = string.Empty;

            this.contextoDados = contextoDados;

            InicializarControladores();
        }

        public static TelaPrincipalForm Instancia
        {
            get;
            private set;
        }

        private void disciplinasMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }
        private void materiasMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }
        public void AtualizarRodape(string mensagem)
        {
            labelRodape.Text = mensagem;
        }
        private void ConfigurarTelaPrincipal(ToolStripMenuItem opcaoSelecionada)
        {
            var tipo = opcaoSelecionada.Text;

            controlador = controladores[tipo];

            ConfigurarToolbox();

            ConfigurarListagem();
        }

        private void ConfigurarToolbox()
        {
            ConfiguracaoToolboxBase configuracao = controlador.ObtemConfiguracaoToolbox();

            if (configuracao != null)
            {
                toolbox.Enabled = true;

                labelTipoCadastro.Text = configuracao.TipoCadastro;

                ConfigurarTooltips(configuracao);

                ConfigurarBotoes(configuracao);
            }
        }
        private void ConfigurarTooltips(ConfiguracaoToolboxBase configuracao)
        {
            btnInserir.ToolTipText = configuracao.TooltipInserir;
            btnEditar.ToolTipText = configuracao.TooltipEditar;
            btnExcluir.ToolTipText = configuracao.TooltipExcluir;
            btnAdicionarQuestoes.ToolTipText = configuracao.TooltipAdicionarItens;
            btnAtualizarQuestoes.ToolTipText = configuracao.TooltipAtualizarItens;
            btnGerarPDF.ToolTipText = configuracao.TooltipFiltrar;
            
        }
        private void ConfigurarBotoes(ConfiguracaoToolboxBase configuracao)
        {
            btnInserir.Enabled = configuracao.InserirHabilitado;
            btnEditar.Enabled = configuracao.EditarHabilitado;
            btnExcluir.Enabled = configuracao.ExcluirHabilitado;
            btnAdicionarQuestoes.Enabled = configuracao.AdicionarItensHabilitado;
            btnAtualizarQuestoes.Enabled = configuracao.AtualizarItensHabilitado;
            btnGerarPDF.Enabled = configuracao.FiltrarHabilitado;
            
        }

        private void ConfigurarListagem()
        {
            AtualizarRodape("");

            var listagemControl = controlador.ObtemListagem();

            panelRegistros.Controls.Clear();

            listagemControl.Dock = DockStyle.Fill;

            panelRegistros.Controls.Add(listagemControl);
        }

        private void InicializarControladores()
        {
            var repositorioDisciplina = new RepositorioDisciplinaEmArquivo(contextoDados);
            var repositorioMateria = new RepositorioMateriaEmArquivo(contextoDados);
            var repositorioQuestao = new RepositorioQuestaoEmArquivo(contextoDados);

            controladores = new Dictionary<string, ControladorBase>();

            controladores.Add("Disciplinas", new ControladorDisciplina(repositorioDisciplina));
            controladores.Add("Materias", new ControladorMateria(repositorioMateria, repositorioDisciplina));
            controladores.Add("Questoes", new ControladorQuestao(repositorioQuestao ,repositorioDisciplina, repositorioMateria));
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

        private void questaoMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }
    }
}
