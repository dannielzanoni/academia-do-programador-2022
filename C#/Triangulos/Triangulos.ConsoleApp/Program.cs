int x = 0;
int y = 0;
int z = 0;
bool opcao = true;
bool triangInvalido = true;
string comando;
do
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Verificação de Triângulos!");
    Console.ResetColor();
    Console.WriteLine("Digite 1 Para verificar o Tipo do Triângulo");
    Console.WriteLine("Digite \"s\" para sair\n");
    comando = Console.ReadLine();

    if (comando == "s")
        break;

    if(comando == "1")
    {
        opcao = true;
        do
        {
            Console.Write("Digite o valor de X: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de Y: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de Z: ");
            z = int.Parse(Console.ReadLine());
            if ((x > y + z) || (y > x + z) || (z > x + y))
            {
                triangInvalido = true;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nTriângulo Inválido! Digite novamente\n");
                Console.ResetColor();
            }
            else
            {
                triangInvalido = false;
            }
            
        } while (triangInvalido == true);

        if (x == y && x == z && z == y)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nTriângulo equilátero: Todos os lados iguais!\n");
            Console.ResetColor();
        }
        else if ((x == y) || (y == z) || (z == x))
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nIsósceles: Dois lados iguais!\n");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nEscaleno: Todos os lados diferentes!\n");
            Console.ResetColor();
        }
    }
} while (opcao == true);