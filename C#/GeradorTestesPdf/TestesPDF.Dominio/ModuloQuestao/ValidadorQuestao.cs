using FluentValidation;

namespace TestesPDF.Dominio.ModuloQuestao
{
    public class ValidadorQuestao : AbstractValidator<Questao>
    {
        public ValidadorQuestao()
        {
            RuleFor(x => x.Enunciado).NotNull().NotEmpty();
        }
    }
}
