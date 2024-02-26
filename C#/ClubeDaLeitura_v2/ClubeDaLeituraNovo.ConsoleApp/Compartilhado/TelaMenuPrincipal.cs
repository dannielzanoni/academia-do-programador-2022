using ClubeDaLeituraNovo.ConsoleApp.Compartilhado;
using ClubeDaLeituraNovo.ConsoleApp.ModuloAmigo;
using ClubeDaLeituraNovo.ConsoleApp.ModuloCaixa;

namespace ClubeDaLeituraNovo.ConsoleApp.Compartilhado
{
    public class TelaMenuPrincipal
    {
        private string opcaoSelecionada;

        private const int QUANTIDADE_REGISTROS = 10;

        private Notificador notificador;

        //Declaracao de Amigos
        private RepositorioAmigo repositorioAmigo;
        private TelaCadastroAmigo telaCadastroAmigo;

        //Declaracao de Caixas
        private RepositorioCaixa repositorioCaixa;
        private TelaCadastroCaixa telaCadastroCaixa;

        public TelaMenuPrincipal(Notificador notificador)
        {
            this.notificador = notificador;

            repositorioCaixa = new RepositorioCaixa();
            telaCadastroCaixa = new TelaCadastroCaixa(repositorioCaixa, notificador);


        }

        public TelaBase ObterTela()
        {
            string opcao = MostrarOpcoes();

            TelaBase tela = null;

            if (opcao == "1")
                tela = telaCadastroCaixa;

            else if (opcao == "4")
                tela = telaCadastroAmigo;

            return tela;
        }

    }
}
