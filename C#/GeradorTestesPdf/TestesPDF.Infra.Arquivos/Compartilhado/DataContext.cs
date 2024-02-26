using System;
using System.Collections.Generic;
using System.Linq;
using TestesPDF.Dominio.ModuloDisciplina;
using TestesPDF.Dominio.ModuloMateria;
using TestesPDF.Dominio.ModuloQuestao;

namespace TestesPDF.Infra.Arquivos
{
    [Serializable]
    public class DataContext
    {
        private readonly ISerializador serializador;
        public DataContext()
        {
            Disciplinas = new List<Disciplina>();

            Materias = new List<Materia>();

            Questoes = new List<Questao>();
        }
        public DataContext(ISerializador serializador) : this()
        {
            this.serializador = serializador;

            CarregarDados();
        }

        public List<Disciplina> Disciplinas { get; set; }   

        public List<Materia> Materias { get; set; } 

        public List<Questao> Questoes { get; set; }

        public void CarregarDados()
        {
            var ctx = serializador.CarregarDadosDoArquivo();

            if (ctx.Disciplinas.Any())
                this.Disciplinas.AddRange(ctx.Disciplinas);
        }

        public void GravarDados()
        {
            serializador.GravarDadosEmArquivo(this);
        }
    }
}
