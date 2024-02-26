using ClubeDaLeituraNovo.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;

namespace ClubeDaLeituraNovo.ConsoleApp.ModuloCaixa
{
    public class TelaCadastroCaixa : TelaBase, ICadastroBasico
    {
        private readonly Notificador notificador;
        private readonly RepositorioCaixa repositorioCaixa;

        public TelaCadastroCaixa(RepositorioBase repositorioCaixa, Notificador notificador) : base("Cadastro de Caixas")
        {

        }
    }
}
