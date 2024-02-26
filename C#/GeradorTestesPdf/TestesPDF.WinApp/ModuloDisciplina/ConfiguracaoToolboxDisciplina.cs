using TestesPDF.WinApp.Compartilhado;

namespace TestesPDF.WinApp.ModuloDisciplina
{
    public class ConfiguracaoToolboxDisciplina : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Cadastro de Disciplinas";

        public override string TooltipInserir { get { return "Inserir uma nova disciplina"; } }

        public override string TooltipEditar { get { return "Editar uma disciplina já existente"; } }

        public override string TooltipExcluir { get { return "Excluir uma disciplina existente"; } }

    }
}
