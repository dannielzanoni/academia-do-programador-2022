using ControleDeMedicamentos.ConsoleApp.Compartilhado;
using System;

namespace ControleDeMedicamentos.ConsoleApp.ModuloMedicamento
{
    public class Medicamento : EntidadeBase
    {
        public Medicamento(string nome, string descricao, int quantidade)
        {
            Nome = nome;
            Descricao = descricao;
            Quantidade = quantidade;    

        }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set;}

        public override string ToString()
        {
            return "Id: " + id + Environment.NewLine +
                "Nome: " + Nome + Environment.NewLine +
                "Quantidade: " + Quantidade + Environment.NewLine;
        }

        public bool TemMedicamentoEmFalta()
        {
            if(Quantidade < 10 || Quantidade == null)
            {
                return true;
            }
            return false;
        }
    }
}
