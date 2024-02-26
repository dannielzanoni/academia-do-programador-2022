using FluentValidation;

namespace TestesPDF.Dominio.ModuloDisciplina
{
    public class ValidadorDisciplina : AbstractValidator<Disciplina>
    {
        public ValidadorDisciplina()
        {
            RuleFor(x => x.Nome).NotNull().NotEmpty();
        }
    }
}
