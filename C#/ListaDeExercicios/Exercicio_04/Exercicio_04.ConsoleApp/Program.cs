double tempCels;
double resultado;

Console.WriteLine("Conversor Celsius - Fahrenheit");
Console.WriteLine();
Console.Write("Digite a temperatura em graus Celsius: ");
tempCels = double.Parse(Console.ReadLine());
Console.WriteLine();

resultado = (tempCels * 1.8) + 32;

Console.WriteLine("Temperatura em Fahrenheit: "+resultado);
