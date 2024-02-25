using System;

namespace Calculadora.ConsoleApp
{
    public class Program
    {
        static void Main(String[] args)
        {
            Calculadora calculadora = new Calculadora();
            
            Apresentacao apresentacao = new Apresentacao();
            apresentacao.opcao = " ";
            apresentacao.operadorSelecionado = " ";
            apresentacao.continuar = true;
            apresentacao.contadorOperacoes = 0;
            apresentacao.historicoOperacoes = new string[10];

            apresentacao.apresentarTela();
        }
    }
}


