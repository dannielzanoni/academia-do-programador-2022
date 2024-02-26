using TestesPDF.Dominio.Compartilhado;
using TestesPDF.Dominio.ModuloDisciplina;
using TestesPDF.Dominio.ModuloMateria;

namespace TestesPDF.Dominio.ModuloQuestao
{
    public class Questao : EntidadeBase<Questao>
    {
        public Questao()
        {
        }

        public Questao(string enunciado, Disciplina disciplina, Materia materia)
        {
            Enunciado = enunciado;
            Disciplina = disciplina;
            Materia = materia;
        }
        public string Enunciado { get; set; }

        public Disciplina Disciplina { get; set; }

        public Materia Materia { get; set; }    

        public override void Atualizar(Questao registro)
        {
        }
    }
}
