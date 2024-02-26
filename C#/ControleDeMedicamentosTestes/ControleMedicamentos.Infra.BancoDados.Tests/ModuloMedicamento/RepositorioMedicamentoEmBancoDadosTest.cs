using Microsoft.VisualStudio.TestTools.UnitTesting;
using ControleMedicamento.Infra.BancoDados.ModuloMedicamento;
using ControleMedicamentos.Dominio.ModuloMedicamento;
using ControleMedicamentos.Dominio.ModuloFornecedor;
using System.Data.SqlClient;
using ControleMedicamentos.Infra.BancoDados;
using System;

namespace ControleMedicamento.Infra.BancoDados.Tests.ModuloMedicamento
{
    [TestClass]
    public class RepositorioMedicamentoEmBancoDadosTest
    {
        private readonly Fornecedor fornecedor;
        private readonly Medicamento medicamento;

        public RepositorioMedicamentoEmBancoDadosTest()
        {
            string sql = 
            @"DELETE FROM TBMEDICAMENTO;
            DBCC CHECKIDENT (TBMedicamento, RESSED, 0)
            
            DELETE FROM TBFORNECEDOR;
            DBCC CHECKIDENT (TBFornecedor, RESSED, 0)
            ";

            Db.ExecutarSql(sql);
        }

        [TestMethod]
        public void Deve_Inserir_Medicamento()
        {
            //arrange 
            Medicamento novoMedicamento = new Medicamento();

            var repositorio = new RepositorioMedicamentoEmBancoDados();

            //action
            repositorio.Inserir(novoMedicamento);

            //assert
            Medicamento medicamentoEncontrado = repositorio.SelecionarPorId(novoMedicamento.Id);

            Assert.IsNotNull(medicamentoEncontrado);
            Assert.AreEqual(novoMedicamento.Id, medicamentoEncontrado.Id);
            Assert.AreEqual(novoMedicamento.Nome, medicamentoEncontrado.Nome);
            Assert.AreEqual(novoMedicamento.Descricao, medicamentoEncontrado.Descricao);
            Assert.AreEqual(novoMedicamento.Lote, medicamentoEncontrado.Lote);
            Assert.AreEqual(novoMedicamento.Validade, medicamentoEncontrado.Validade);
            Assert.AreEqual(novoMedicamento.Fornecedor, medicamentoEncontrado.Fornecedor);
        }

        [TestMethod]
        public void Deve_Editar_Medicamento()
        {
            //arrange
            Medicamento novoMedicamento = new Medicamento();
            var repositorio = new RepositorioMedicamentoEmBancoDados();

            repositorio.Inserir(novoMedicamento);

            Medicamento medicamentoAtualizado = repositorio.SelecionarPorId(novoMedicamento.Id);
            medicamentoAtualizado.Nome = "Iboprofeno";
            medicamentoAtualizado.Lote = "I-001";

            //action
            repositorio.Editar(medicamentoAtualizado);

            //assert
            Medicamento medicamentoEncontrado = repositorio.SelecionarPorId(novoMedicamento.Id);

            Assert.IsNotNull(medicamentoEncontrado);
            Assert.AreEqual(medicamentoAtualizado.Id, medicamentoEncontrado.Id);
            Assert.AreEqual(medicamentoAtualizado.Nome, medicamentoEncontrado.Nome);
            Assert.AreEqual(medicamentoAtualizado.Descricao, medicamentoEncontrado.Descricao);
            Assert.AreEqual(medicamentoAtualizado.Lote, medicamentoEncontrado.Lote);
            Assert.AreEqual(medicamentoAtualizado.Validade, medicamentoEncontrado.Validade);
            Assert.AreEqual(medicamentoAtualizado.Fornecedor, medicamentoEncontrado.Fornecedor);
        }

        [TestMethod]
        public void Deve_Selecionar_Todos_Medicamentos()
        {
            //arange
            var repositorio = new RepositorioMedicamentoEmBancoDados();

            Medicamento m1 = new Medicamento("Decongex", "Analgésico", "D-001", new DateTime(2025, 12, 20));
            repositorio.Inserir(m1);

            Medicamento m2 = new Medicamento("Enax", "Preventivo", "ENX-001", new DateTime(2022, 12, 20));
            repositorio.Inserir(m2);

            //action
            var medicamentos = repositorio.SelecionarTodos();

            //assert
            Assert.AreEqual(2, medicamentos.Count);

            Assert.AreEqual("Decongex", medicamentos[0].Nome);
            Assert.AreEqual("Enax", medicamentos[1].Nome);
        }
    }
}
