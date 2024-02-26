int[] valores = new int[10] { 1, 2, 4, 3, 5, 5, 7, 8, 11, 0 };

int maiorValor = MaiorValor(ref valores);
int menorValor = MenorValor(out valores);
float medioValor = MedioValor(ref valores);

static int MaiorValor(ref int[] valores)
{
    int maiorValor = valores.Max();
    int maiorI = valores.ToList().IndexOf(maiorValor);
    return maiorValor;
}
static int MenorValor(out int[] valores)
{
    valores = new int[10] { 1, 2, 4, 3, 5, 5, 7, 8, 11, 0 };
    int menorValor = valores.Min();
    int menorI = valores.ToList().IndexOf(menorValor);
    return menorValor;
}
static float MedioValor(ref int[] valores)
{
    float soma = 0;
    float media = 0;
    for (int i = 0; i < 10; i++)
    {
        soma = soma + valores[i];
    }
    media = soma / valores.Length;
    return media;
}
static void MostrarValores(int[] valores)
{
    for (int i = 0; i < valores.Length; i++)
    {
        Console.Write(valores[i] + " ");
    }
    Console.WriteLine();
}
static void TresMaiores(int[] valores)
{
    Array.Sort(valores);
    Array.Reverse(valores);
    Console.Write("Três maiores valores: ");
    for(int i = 0; i < 3; i++)
    {
        Console.Write(valores[i]+" ");
    }
    Console.WriteLine();
    
}
static void RemoverValor(int[] valores)
{
    Console.Write("Digite o número a ser removido: ");
    int numeroParaRemover = int.Parse(Console.ReadLine());
    var Lista = valores.ToList();
    for (int i = 0; i < numeroParaRemover; i++)
    {
        if (valores.Contains(numeroParaRemover))
        {
            Lista.Remove(numeroParaRemover);
        }
    }
    valores = Lista.ToArray();
    Console.Write("Sequência atualizada: ");
    MostrarValores(valores);
}

Console.WriteLine("Maior valor: " + maiorValor);
Console.WriteLine("Menor valor: " + menorValor);
Console.WriteLine("Valor médio: " + MedioValor(ref valores));
Console.Write("Valores da sequência: "); 
MostrarValores(valores);
TresMaiores(valores);
RemoverValor(valores);