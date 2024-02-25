using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.ConsoleApp
{
    internal class Apresentacao
    {
        public string opcao;
        public string operadorSelecionado;
        public bool continuar;
        public int contadorOperacoes;
        public string[] historicoOperacoes;

        public void apresentarTela()
        {
            Calculadora calculadora = new Calculadora();
            contadorOperacoes = 0;

            while (continuar == true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Calculadora 1.0");
                Console.ResetColor();
                Console.WriteLine("======================================");
                Console.WriteLine("Digite 1 para somar");
                Console.WriteLine("Digite 2 para subtrair");
                Console.WriteLine("Digite 3 para multiplicar");
                Console.WriteLine("Digite 4 para dividir");
                Console.WriteLine("Digite 5 para visualizar operações");
                Console.WriteLine("Digite s para sair");
                Console.WriteLine("======================================");
                Console.WriteLine();
                Console.Write("Comando: ");
                opcao = Console.ReadLine();
                Console.WriteLine();

                if ((opcao != "s") && (opcao != "1") && (opcao != "2")
                   && (opcao != "3") && (opcao != "4") && (opcao != "5"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Opção inválida: tente novamente ");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.WriteLine();
                    Console.Clear();
                    continue;
                }

                if (opcao == "s")
                    break;

                if(opcao == "5")
                {
                    mostrarHistorico();
                    continue;
                }

                Console.Write("Digite o primeiro número: ");
                calculadora.n1 = double.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                calculadora.n2 = double.Parse(Console.ReadLine());

                double resultadoOperacao = 0;

                if(opcao == "1")
                {
                    operadorSelecionado = "+";
                    resultadoOperacao = calculadora.soma(calculadora.n1, calculadora.n2);
                    ApresentarMensagemParaVoltar();
                    continuar = true;
                }
                else if (opcao == "2")
                {
                    operadorSelecionado = "-";
                    resultadoOperacao = calculadora.subtracao(calculadora.n1, calculadora.n2);
                    ApresentarMensagemParaVoltar();
                    continuar = true;
                }
                else if (opcao == "3")
                {
                    operadorSelecionado = "*";
                    resultadoOperacao = calculadora.multiplicacao(calculadora.n1, calculadora.n2);
                    ApresentarMensagemParaVoltar();
                    continuar = true;
                }
                else if (opcao == "4")
                {
                    operadorSelecionado = "/";
                    resultadoOperacao = calculadora.divisao(calculadora.n1, calculadora.n2);
                    ApresentarMensagemParaVoltar();
                    continuar = true;
                }

                historicoOperacoes[contadorOperacoes] = calculadora.n1 + " " + operadorSelecionado + " "+ 
                    calculadora.n2 + " = " + calculadora.resultado.ToString("f2");

                contadorOperacoes++;
                Console.WriteLine("======================================");
            }
        }
        public void mostrarHistorico()
        {
            if (contadorOperacoes == 0)
            {
                Console.WriteLine("Nenhuma operação realizada! Realize uma nova operação");
            }
            else
            {
                for (int i = 0; i < historicoOperacoes.Length; i++)
                {
                    if (historicoOperacoes[i] != null)
                    {
                        if (historicoOperacoes[i].Contains("+"))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else if (historicoOperacoes[i].Contains("-"))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        else if (historicoOperacoes[i].Contains("*"))
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                        }
                        else if (historicoOperacoes[i].Contains("/"))
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                        }
                        Console.WriteLine(historicoOperacoes[i]);
                    }
                }
            }
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
        }
        public void ApresentarMensagemParaVoltar()
        {
            Console.ResetColor();
            Console.Write("\nDigite qualquer tecla para voltar para a Calculadora Básica: ");
            Console.ReadKey();
            Console.Clear();
        }

        //public double formataResultado(double resultadoOperacao)
        //{
        //    double resultadoFormatado;

        //    if (resultadoOperacao.ToString().Contains(",00"))
        //    {
        //        resultadoFormatado = (int)resultadoOperacao;
        //        return resultadoFormatado;
        //    }

        //    return resultadoOperacao;
        //}
    }
}
