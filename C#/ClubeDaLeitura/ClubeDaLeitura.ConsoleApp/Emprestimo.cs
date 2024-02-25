using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class Emprestimo
    {
        public int idAmigoEmprestimo;
        public string amigoRevistaPega;
        public int numeroRevistaEmprestimo;
        public DateTime dataEmprestimo;
        public DateTime dataDevolucao;
        public void formatarVizualizarEmprestimo()
        {
            string dataIntegradaEmprestimo = $"{dataEmprestimo.Day}/{dataEmprestimo.Month}/{dataEmprestimo.Year}";
            string dataIntegradaDevolucao = $"{dataDevolucao.Day}/{dataDevolucao.Month}/{dataDevolucao.Year}";

            Console.WriteLine("{0,-20} | {1,-15} | {2,-20} | {3,-20}", amigoRevistaPega,
                numeroRevistaEmprestimo, dataIntegradaEmprestimo, dataIntegradaDevolucao);
        }
        public void formatarVizualizarEmprestimoAberto()
        {
            var dataAgora = DateTime.Now;
            string dataIntegradaEmprestimo = $"{dataEmprestimo.Day}/{dataEmprestimo.Month}/{dataEmprestimo.Year}";
            string dataIntegradaDevolucao = $"{dataDevolucao.Day}/{dataDevolucao.Month}/{dataDevolucao.Year}";

            if (dataDevolucao > dataAgora)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("{0,-20} | {1,-15} | {2,-20} | {3,-20}", amigoRevistaPega,
                    numeroRevistaEmprestimo, dataIntegradaEmprestimo, dataDevolucao);
            }
        }
    }
}
