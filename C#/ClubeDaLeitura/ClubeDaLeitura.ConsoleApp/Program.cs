namespace ClubeDaLeitura.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.revistas = new Revista[10];
            menu.emprestimos = new Emprestimo[10];
            menu.amigos = new Amigo[10];
            menu.caixas = new Caixa[10];
            menu.apresentarMenu();
        }
    }
}