double salario;
double salarioAumento;
double salarioFinal;

Console.Write("Digite seu salário: R$ ");
salario = double.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Salário inicial: R$ "+salario);

salarioAumento = salario * 1.15;
Console.WriteLine("Salário com aumento de 15%: R$ "+ salarioAumento);

salarioFinal = salarioAumento * 0.92;
Console.WriteLine("Salário final com 8% de desconto: R$ " + salarioFinal);
