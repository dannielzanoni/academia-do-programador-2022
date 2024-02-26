using ControleDeMedicamentos.ConsoleApp.Compartilhado;
using ControleDeMedicamentos.ConsoleApp.ModuloMedicamento;
using ControleDeMedicamentos.ConsoleApp.ModuloPaciente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleApp.ModuloRequisicao
{
    public class Requisicao : EntidadeBase
    {
        public Paciente paciente;
        public Medicamento medicamento;
        public DateTime dataRequisicao;
        
        public Requisicao(Paciente paciente, Medicamento medicamento)
        {
            this.paciente = paciente;
            this.medicamento = medicamento;
        }
        public override string ToString()
        {
            return "ID: " + id + Environment.NewLine +
                "Nome do Medicamento: "+ medicamento.Nome + Environment.NewLine +
                "Nome do Paciente: " + paciente.Nome + Environment.NewLine+
                "Data da requisição: "+dataRequisicao +Environment.NewLine;
        }
    }
}
