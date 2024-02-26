using System.Collections.Generic;
using System.Windows.Forms;
using TestesPDF.Dominio.ModuloMateria;
using TestesPDF.Dominio.ModuloDisciplina;
using TestesPDF.WinApp.Compartilhado;

namespace TestesPDF.WinApp.ModuloMateria
{
    public class ControladorMateria : ControladorBase
    {
        private readonly IRepositorioMateria repositorioMateria;
        private readonly IRepositorioDisciplina repositorioDisciplina;

        private TabelaMateriasControl tabelaMaterias;

        public ControladorMateria(IRepositorioMateria repositorioMateria, IRepositorioDisciplina repositorioDisciplina)
        {
            this.repositorioMateria = repositorioMateria;
            this.repositorioDisciplina = repositorioDisciplina;
        }


        public override void Editar()
        {
            Materia materiaSelecionada = ObtemMateriaSelecionado();

            if (materiaSelecionada == null)
            {
                MessageBox.Show("Selecione uma matéria primeiro",
                "Edição de Matérias", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var disciplinas = repositorioDisciplina.SelecionarTodos();

            TelaCadastroMateriaForm tela = new TelaCadastroMateriaForm(disciplinas);

            tela.Materia = materiaSelecionada;

            tela.GravarRegistro = repositorioMateria.Editar;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarMaterias();
            }
        }

        public override void Excluir()
        {
            Materia materiaSelecionda = ObtemMateriaSelecionado();

            if (materiaSelecionda == null)
            {
                MessageBox.Show("Selecione uma máteria primeiro",
                "Exclusão de Matéria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir a matéria?",
                "Exclusão de Matéria", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioMateria.Excluir(materiaSelecionda);
                CarregarMaterias();
            }
        }

        public override void Inserir()
        {
            var disciplinas = repositorioDisciplina.SelecionarTodos();

            TelaCadastroMateriaForm tela = new TelaCadastroMateriaForm(disciplinas);
            tela.Materia = new Materia();

            tela.GravarRegistro = repositorioMateria.Inserir;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarMaterias();
            }
        }

        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxMateria();
        }

        public override UserControl ObtemListagem()
        {
            if (tabelaMaterias == null)
                tabelaMaterias = new TabelaMateriasControl();

            CarregarMaterias();

            return tabelaMaterias;
        }

        private void CarregarMaterias()
        {
            List<Materia> materias = repositorioMateria.SelecionarTodos();

            tabelaMaterias.AtualizarRegistros(materias);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {materias.Count} matérias(s)");
        }

        private Materia ObtemMateriaSelecionado()
        {
            var numero = tabelaMaterias.ObtemNumeroDisciplinaSelecionada();

            return repositorioMateria.SelecionarPorNumero(numero);
        }
    }
}
