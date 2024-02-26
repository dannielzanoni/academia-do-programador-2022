using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodosAtras.ConsoleApp.ModuloCalculaData
{
    public class TelaMenuPrincipal
    {
        private DateTime dataParaComparar;

        public DateTime MostrarOpcoes()
        {
            Console.Clear();

            DateTime dataAgora = DateTime.Now;
            Console.WriteLine($"Hoje é dia {dataAgora.Day}/{dataAgora.Month}/{dataAgora.Year}");
            Console.WriteLine();

            Console.WriteLine("Períodos Atrás");
            Console.WriteLine();

            Console.Write("Digite a data que deseja comparar: ");
            dataParaComparar = Convert.ToDateTime(Console.ReadLine());
            
            return dataParaComparar;    
        }
    }
}
