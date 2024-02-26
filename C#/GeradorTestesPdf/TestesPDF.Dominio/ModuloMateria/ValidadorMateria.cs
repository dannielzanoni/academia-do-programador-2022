using FluentValidation;

namespace TestesPDF.Dominio.ModuloMateria
{
    public class ValidadorMateria : AbstractValidator<Materia>
    {
        public ValidadorMateria()
        {
            RuleFor(x => x.Nome).NotNull().NotEmpty();
        }
    }
}
