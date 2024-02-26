int numero = 0;
Console.Write("Digite um número: ");
numero = int.Parse(Console.ReadLine());

if(numero % 2 == 0)
{
    do
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Erro! Digite um número ímpar: ");
        numero = int.Parse(Console.ReadLine());
        Console.ResetColor();
    } while (numero % 2 == 0);
}
int divisoria = (numero - 1) / 2;

for (int i = 0; i <= numero; i++)
{
    if (i % 2 != 0)
    {
        for (int j = 1; j <= divisoria; j++)
        {
            Console.Write(" ");
        }
        for (int k = 1; k <= i; k++)
        {
            Console.Write("x");
        }
        Console.WriteLine();
        divisoria--;
    }
}
//int j = n - 1: para não fazer a linha central de n
for (int j = numero - 1; j >= 1; j--)
{
    if (j % 2 != 0)
    {
        for (int k = -1; k >= divisoria; k--)
        {
            Console.Write(" ");
        }
        for (int m = 1; m <= j; m++)
        {
            Console.Write("x");
        }
        Console.WriteLine();
        divisoria--;
    }
}