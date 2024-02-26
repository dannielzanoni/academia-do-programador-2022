using TestesPDF.Dominio.Compartilhado;
using TestesPDF.Dominio.ModuloDisciplina;

namespace TestesPDF.Dominio.ModuloMateria
{
    public class Materia : EntidadeBase<Materia>
    {
        public Materia()
        {
        }

        public Materia(string nome, Disciplina disciplina)
        {
            Nome = nome;
            Disciplina = disciplina;
        }
        public string Nome { get; set; }
        public Disciplina Disciplina { get; set; } 
        public override void Atualizar(Materia registro)
        {
        }
    }
}
