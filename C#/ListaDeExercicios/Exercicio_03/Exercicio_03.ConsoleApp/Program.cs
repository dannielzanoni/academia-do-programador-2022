string nome;
int idade;
int dias;

Console.Write("Digite seu nome: ");
nome = Console.ReadLine();
Console.Write("Digite sua idade: ");
idade = int.Parse(Console.ReadLine());
Console.WriteLine();
dias = 365 * idade;

Console.WriteLine(nome + ", você já viveu " + dias + " dias");
