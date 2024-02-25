using ClubeDaLeituraNovo.ConsoleApp.Compartilhado;
using ClubeDaLeituraNovo.ConsoleApp.ModuloCaixa;
using ClubeDaLeituraNovo.ConsoleApp.ModuloAmigo;

namespace ClubeDaLeituraNovo.ConsoleApp
{
    internal class Program
    {
        static Notificador notificador = new Notificador();
        static TelaMenuPrincipal menuPrincipal = new TelaMenuPrincipal();
        static void Main(string[] args)
        {
            while (true)
            {
                TelaBase telaSelecionada = menuPrincipal.

                string opcaoSelecionada = telaSelecionada.MostrarOpcoes
            }
        }
    }
}
