using ControleDeMedicamentos.ConsoleApp.Compartilhado;
using System;


namespace ControleDeMedicamentos.ConsoleApp.ModuloPaciente
{
    public class Paciente : EntidadeBase
    {
        private readonly string _nome;
        private readonly string _cpf;
        private readonly string _nomeDaMae;

        public string Nome { get => _nome; }
        public string Cpf { get => _cpf; }
        public string NomeDaMae { get => _nomeDaMae; }

        public Paciente(string nome, string cpf, string nomeDaMae)
        {
            _nome = nome;
            _cpf = cpf;
            _nomeDaMae = nomeDaMae;
        }
        public override string ToString()
        {
            return "Id: " + id + Environment.NewLine +
                "Nome: " + Nome + Environment.NewLine +
                "Cpf: " + Cpf + Environment.NewLine +
                "Nome da mãe: " + NomeDaMae + Environment.NewLine;
        }
    }
}
