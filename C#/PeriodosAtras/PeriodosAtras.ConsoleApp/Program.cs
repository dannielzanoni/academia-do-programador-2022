using System;
using PeriodosAtras.ConsoleApp.ModuloCalculaData;

namespace PeriodosAtras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TelaMenuPrincipal menuPrincipal = new TelaMenuPrincipal();

            while (true)
            {
                DateTime dataComparada = menuPrincipal.MostrarOpcoes();

                DateTime dataAgora = DateTime.Now;

                CalculaData calculaData = new CalculaData();
                TimeSpan dataSubtracaoRecebeCalculo = calculaData.CompararDatas(dataComparada, dataAgora);

                Console.WriteLine(dataSubtracaoRecebeCalculo.Days);

                string inputFormtado = calculaData.FormatarData2(dataSubtracaoRecebeCalculo);

                Console.Write("Total de dias: "+ dataSubtracaoRecebeCalculo);
                Console.WriteLine();
                Console.Write(inputFormtado);
                Console.ReadKey();
            }
        }
    }
}
