using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeituraNovo.ConsoleApp.Compartilhado
{
    public class Notificador
    {
        public void ApresentarMensagem(string mensagem, TipoMensagem tipoMensagem)
        {
            switch (tipoMensagem)
            {
                case tipoMensagem.Sucesso:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case tipoMensagem.Atencao:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case tipoMensagem.Erro:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                default:
                    break;
            }
            Console.WriteLine();
            Console.WriteLine(mensagem);
            Console.ResetColor();
            Console.WriteLine("Aperte Enter do teclado para proseguir");
            Console.ReadLine();
        }
    }
}
