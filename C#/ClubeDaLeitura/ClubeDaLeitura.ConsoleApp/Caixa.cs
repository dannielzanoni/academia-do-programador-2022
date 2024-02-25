using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    public class Caixa
    {
        public string corCaixa;
        public string etiquetaCaixa;
        public int numeroCaixa;
        public void formataVizualizadorCaixa()
        {
            Console.WriteLine("{0,-20} | {1,-15} | {2,-15}", numeroCaixa, etiquetaCaixa, corCaixa);
        }
        public bool verificaNumeroCaixaValido(int numeroCaixaPassado, bool status)
        {
            bool statusCaixaExiste;

            if (numeroCaixa == numeroCaixaPassado)
            {
                statusCaixaExiste = true;
                return statusCaixaExiste;
            }
            else
            {
                statusCaixaExiste = false;
            }
            return statusCaixaExiste;
        }
    }
}