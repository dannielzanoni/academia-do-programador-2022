using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class Amigo
    {
        public int idAmigo;
        public string nomeAmigo;
        public string nomeResponsavelAmigo;
        public string telefoneAmigo;
        public string enderecoAmigo;
        public bool amigoPossuiEmprestimo;
        public void formataVizualizadorAmigo()
        {
            Console.WriteLine("{0,-10} | {1,-15} | {2,-15} | {3,-15} | {4,-15}", idAmigo, nomeAmigo, nomeResponsavelAmigo, telefoneAmigo, enderecoAmigo);
        }
        public bool verificaIdAmigo(int idAmigoPassado)
        {
            bool statusAmigoExiste;

            if (idAmigoPassado == idAmigo)
            {
                statusAmigoExiste = true;
                return statusAmigoExiste;
            }
            else
            {
                statusAmigoExiste = false;
            }
            return statusAmigoExiste;
        }
        public bool verificaIdAmigoExistente(int idAmigoPassado, bool status)
        {
            bool statusAmigoExistente = status;

            if (statusAmigoExistente && amigoPossuiEmprestimo)
            {
                statusAmigoExistente = true;
                return statusAmigoExistente;
            }
            else
            {
                statusAmigoExistente = false;
            }
            return statusAmigoExistente;
        }
    }
}
