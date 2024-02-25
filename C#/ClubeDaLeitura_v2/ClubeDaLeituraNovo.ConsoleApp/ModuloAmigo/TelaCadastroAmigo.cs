using ClubeDaLeituraNovo.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;

namespace ClubeDaLeituraNovo.ConsoleApp.ModuloAmigo
{
    public class TelaCadastroAmigo : TelaBase, ICadastroBasico
    {
        private readonly Notificador notificador;
        private readonly RepositorioAmigo repositorioAmigo;

        public TelaCadastroAmigo(RepositorioAmigo repositorioAmigo, Notificador notificador): base("Cadastro de Amigos")
        {
            this.notificador = notificador; 
            this.repositorioAmigo = repositorioAmigo;
        }

        public override string MostrarOpcoes()
        {
            Console.WriteLine(Titulo);

            Console.WriteLine("Digite 1 para Inserir");
            Console.WriteLine("Digite 2 para Editar");
            Console.WriteLine("Digite 3 para Excluir");
            Console.WriteLine("Digite 4 para Visualizar");
            Console.WriteLine("Digite 5 para Visualizar Amigos com Multa");
            Console.WriteLine("Digite 6 para Pagar Multas");
            Console.WriteLine("Digite s para sair");

            string opcao = Console.ReadLine();

            return opcao;
        }
    }
}
