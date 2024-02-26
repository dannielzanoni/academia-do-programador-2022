using FluentValidation;
using System.Collections.Generic;
using System.Linq;
using TestesPDF.Dominio.ModuloMateria;

namespace TestesPDF.Infra.Arquivos.ModuloMateria
{
    public class RepositorioMateriaEmArquivo : RepositorioEmArquivoBase<Materia>, IRepositorioMateria
    {
        public RepositorioMateriaEmArquivo(DataContext context) : base(context)
        {
            if (dataContext.Materias.Count > 0)
                contador = dataContext.Materias.Max(x => x.Numero);
        }
        public override List<Materia> ObterRegistros()
        {
            return dataContext.Materias;
        }
        public override AbstractValidator<Materia> ObterValidador()
        {
            return new ValidadorMateria();
        }
    }
}
