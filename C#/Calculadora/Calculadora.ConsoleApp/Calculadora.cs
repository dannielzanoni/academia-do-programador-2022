using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.ConsoleApp
{
    internal class Calculadora
    {
        public double n1;
        public double n2;
        public double resultado;
       
        public double soma(double n1, double n2)
        {
            resultado = n1 + n2;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Resultado da soma: "+resultado.ToString("f2"));
            Console.ResetColor();
            return resultado;
        }
        public double subtracao(double n1, double n2)
        {
            resultado = n1 - n2;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Resultado da subtração: "+resultado.ToString("f2"));
            Console.ResetColor();
            return resultado;
        }
        public double multiplicacao(double n1, double n2)
        {
            resultado = n1 * n2;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Resultado da multiplicação: "+resultado.ToString("f2"));
            Console.ResetColor();
            return resultado;
        }
        public double divisao(double n1, double n2)
        {
            while(n2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Segundo número inválido! Divisão por zero");
                Console.ResetColor();
                Console.WriteLine();
                Console.Write("Digite um segundo número válido: ");
                n2 = double.Parse(Console.ReadLine());
                Console.WriteLine();
                continue;
            }
            resultado = n1 / n2;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Resultado da divisão: "+resultado.ToString("f2"));
            return resultado;
        }
    }
}
