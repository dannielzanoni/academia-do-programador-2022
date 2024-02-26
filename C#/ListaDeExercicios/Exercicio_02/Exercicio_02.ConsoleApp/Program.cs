double valorPao = 0.12;
double valorBroa = 1.50;
double quantPao = 0;
double quantBroa = 0;
string opcao;

do
{
    Console.WriteLine("Padaria Hotpão");
    Console.WriteLine();
    Console.WriteLine("Digite um comando para continuar");
    Console.WriteLine("1 - Calcular vendas do dia;");
    Console.WriteLine("s - Sair do programa.");
    Console.WriteLine();
    Console.Write("Comando: ");
    opcao = Console.ReadLine();
    Console.WriteLine();

    if (opcao == "s"){
        break;
    }

    Console.Write("Digite a quantidade de pães vendidos: ");
    quantPao = double.Parse(Console.ReadLine());
    Console.Write("Digite a quantidade de broas vendidas: ");
    quantBroa = double.Parse(Console.ReadLine());
    Console.WriteLine();

    double total = (quantPao * valorPao) + (quantBroa * valorBroa);
    double poupanca = total * 0.1;

    Console.WriteLine("Total arrecadado: R$ " + Math.Round(total, 2));
    Console.WriteLine("Dinheiro na poupança: R$ " + Math.Round(poupanca, 2));
    Console.WriteLine();
    Console.WriteLine("===========================================");
    Console.WriteLine();
} while (opcao == "1");