int n;
string comando;

do
{
    char direcaoRecruta = 'N';
    Console.Write("Digite N: ");
    n = int.Parse(Console.ReadLine());
    
    while (n < 0 || n >= 1000)
    {
            
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Digite N válido: ");
        n = int.Parse(Console.ReadLine());
        Console.ResetColor();
    }   
  
    if (n == 0)
        break;

    Console.Write("Digite a linha de comandos: ");
    comando = Console.ReadLine();

    char[] arrayCaracteres;
    arrayCaracteres = comando.ToCharArray();

    for(int i = 0; i < arrayCaracteres.Length; i++)
    {
        switch (arrayCaracteres.GetValue(i))
        {
            case 'D':
                if (direcaoRecruta == 'N')
                {
                    direcaoRecruta = 'L';
                }
                else if (direcaoRecruta == 'O')
                {
                    direcaoRecruta = 'N';
                }
                else if (direcaoRecruta == 'S')
                {
                    direcaoRecruta = 'O';
                }
                else if (direcaoRecruta == 'L')
                {
                    direcaoRecruta = 'S';
                }
                break;
            case 'E':
                if (direcaoRecruta == 'N')
                {
                    direcaoRecruta = 'O';
                }
                else if (direcaoRecruta == 'O')
                {
                    direcaoRecruta = 'S';
                }
                else if (direcaoRecruta == 'S')
                {
                    direcaoRecruta = 'L';
                }
                else if (direcaoRecruta == 'L')
                {
                    direcaoRecruta = 'N';
                }
                break;
        }
    }
    Console.WriteLine("Direção final do recruta: "+direcaoRecruta);
}while (true);