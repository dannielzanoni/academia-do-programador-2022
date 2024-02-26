int quantidadeDeX = 0;
int contador = 1;

Console.Write("Digite a quantidade de valores a serem lidos: ");
quantidadeDeX = int.Parse(Console.ReadLine());
if (quantidadeDeX <= 0 || quantidadeDeX >= 2000)
{
    do
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Digite um valor válido: ");
        quantidadeDeX = int.Parse(Console.ReadLine());
        Console.ResetColor();
    }while(1 <= quantidadeDeX && quantidadeDeX >= 2000);
}

int[] numeros = new int [quantidadeDeX];
var lista = new Dictionary<int, int>();

for (int i = 0; i < quantidadeDeX; i++)
{
    Console.Write($"Digite o {i+1}º número: ");
    numeros[i] = int.Parse(Console.ReadLine());
    
}
Array.Sort(numeros);

foreach (var valor in numeros)
{
    lista.TryGetValue(valor, out contador);
    lista[valor] = contador+1;
}

foreach (var pair in lista)
{
    Console.WriteLine("{0} aparece {1} vez(es)", pair.Key, pair.Value);
}