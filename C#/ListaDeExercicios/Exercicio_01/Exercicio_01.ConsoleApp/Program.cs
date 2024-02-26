double lado;
double comprimento;

Console.WriteLine("Imobiliária Imóbilis");
Console.WriteLine();
Console.Write("Digite o lado do terreno em metros: ");
lado = double.Parse(Console.ReadLine());
Console.Write("Digite o comprimento do terreno em metros: ");
comprimento = double.Parse(Console.ReadLine());
Console.WriteLine();

double area = lado * comprimento;

Console.WriteLine("Área do terreno: "+area+" m²");
