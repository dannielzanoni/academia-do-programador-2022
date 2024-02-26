using System;
using System.Collections.Generic;
using eAgenda.ConsoleApp.Compartilhado;

namespace eAgenda.ConsoleApp.ModuloContatos
{
    public class Contato : EntidadeBase
    {
        private readonly string nome;
        private readonly string email;
        private readonly string telefone;
        private readonly string empresa;
        private readonly string cargo;

        public Contato(string nome, string email, string telefone, string empresa, string contato)
        {
            this.nome = nome;
            this.email = email;
            this.telefone = telefone;
            this.empresa = empresa;
            this.cargo = contato;
        }
        public override string ToString()
        {
            return "Número: " + numero + Environment.NewLine +
                "Nome: " + nome + Environment.NewLine +
                "E-mail: " + email + Environment.NewLine +
                "Telefone: " + telefone + Environment.NewLine +
                "Empresa: " + empresa + Environment.NewLine +
                "Cargo: " + cargo + Environment.NewLine;
        }
    }
}
