using Microsoft.VisualStudio.TestTools.UnitTesting;
using ControleMedicamentos.Dominio.ModuloFornecedor;
using ControleMedicamentos.Dominio.ModuloMedicamento;
using System;
using FluentValidation.Results;

namespace ControleMedicamentos.Dominio.Tests.ModuloMedicamento
{
    [TestClass]
    public class MedicamentoTest
    {
        private readonly Fornecedor fornecedor;
        private readonly Medicamento medicamento;
        private readonly MedicamentoTest validador;

        public MedicamentoTest()
        {
            fornecedor = new()
            {
                Nome = "Fornecedor1",
                Telefone = "9999999999",
                Email = "fornecedor@gmail.com",
                Cidade = "Lages",
                Estado = "Santa Catarina"
            };

            medicamento = new()
            {
                Nome = "Decongex",
                Descricao = "Analgésico",
                Lote = "D-001",
                Validade = new DateTime(2022, 04, 10),
                QuantidadeDisponivel = 100,
                Fornecedor = fornecedor
            };

            validador = new();
        }
    }
}

