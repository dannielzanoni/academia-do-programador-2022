int x = 0;
int y = 0;
char roboPosicao = '0';

string[] xy = Console.ReadLine().Split(' ');
x = int.Parse(xy[0]);
y = int.Parse(xy[1]);

int[] arrayx = new int[x];
int[] arrayy = new int[y];

int robox = 0;
int roboy = 0;

Console.Write($"{arrayx.Length}, {arrayy.Length}\n");

for (int i = 0; i < 2; i++)
{
    Console.Write($"Posição do robo {i+1} :");
    string[] strPosi = Console.ReadLine().Split(' ');
    robox = int.Parse(strPosi[0]);
    roboy = int.Parse(strPosi[1]);
    roboPosicao = char.Parse(strPosi[2]);
    Console.WriteLine($"Sua posição atual do Robo {i+1}: " + robox + ", " + roboy + ", " + roboPosicao);

    Console.Write("Comando: ");
    string comando = Console.ReadLine();
    char[] arrCaract;
    arrCaract = comando.ToCharArray();

    for (int j = 0; j < arrCaract.Length; j++)
    {
        switch (arrCaract.GetValue(j))
        {
            case 'E':
                if (roboPosicao == 'N')
                {
                    roboPosicao = 'O';
                }
                else if (roboPosicao == 'O')
                {
                    roboPosicao = 'S';
                }
                else if (roboPosicao == 'S')
                {
                    roboPosicao = 'L';
                }
                else if (roboPosicao == 'L')
                {
                    roboPosicao = 'N';
                }
                break;
            case 'D':
                if (roboPosicao == 'N')
                {
                    roboPosicao = 'L';
                }
                else if (roboPosicao == 'O')
                {
                    roboPosicao = 'N';
                }
                else if (roboPosicao == 'S')
                {
                    roboPosicao = 'O';
                }
                else if (roboPosicao == 'L')
                {
                    roboPosicao = 'S';
                }
                break;
            case 'M':
                if (roboPosicao == 'N')
                {
                    roboy = roboy + 1;
                }
                else if (roboPosicao == 'O')
                {
                    robox = robox - 1;
                }
                else if (roboPosicao == 'S')
                {
                    roboy = roboy - 1;
                }
                else if (roboPosicao == 'L')
                {
                    robox = robox + 1;
                }
                break;
            default:
                Console.Write("Digite um comando válido: ");
                comando = Console.ReadLine();
                break;
        }
    }
    Console.WriteLine($"Posição final do Robo {i+1}: " + robox + ", " + roboy + ", " + roboPosicao);
}