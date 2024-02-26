using TestesPDF.WinApp.Compartilhado;

namespace TestesPDF.WinApp.ModuloQuestao
{
    public class ConfiguracaoToolboxQuestao : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Cadastro de Questões";

        public override string TooltipInserir { get { return "Inserir uma nova questão"; } }

        public override string TooltipEditar { get { return "Editar uma nova questão"; } }

        public override string TooltipExcluir { get { return "Excluir uma nova questão"; } }
    }
}
