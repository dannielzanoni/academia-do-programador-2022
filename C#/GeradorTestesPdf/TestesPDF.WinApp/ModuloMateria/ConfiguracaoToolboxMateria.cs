using TestesPDF.WinApp.Compartilhado;

namespace TestesPDF.WinApp.ModuloMateria
{
    public class ConfiguracaoToolboxMateria : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Controle de Matérias";

        public override string TooltipInserir => "Inserir uma nova matéria";

        public override string TooltipEditar => "Editar uma matéria existente";

        public override string TooltipExcluir => "Excluir uma matéria existente";
    }
}
