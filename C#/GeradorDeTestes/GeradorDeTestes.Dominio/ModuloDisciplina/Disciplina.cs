using GeradorDeTestes.Dominio.Compartilhado;

namespace GeradorDeTestes.Dominio.ModuloDisciplina
{
    public class Disciplina : EntidadeBase<Disciplina>
    {
        public Disciplina()
        {
        }

        public Disciplina(string t)
        {
            Titulo = t;
        }

        public string Titulo { get; set; }    

        public override void Atualizar(Disciplina registro)
        {
        }
    }
}
