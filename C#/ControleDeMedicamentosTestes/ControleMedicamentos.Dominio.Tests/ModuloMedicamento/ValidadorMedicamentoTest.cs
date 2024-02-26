using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ControleMedicamentos.Dominio.ModuloMedicamento.Tests
{
    [TestClass]
    public class ValidadorMedicamentoTest
    {
        public ValidadorMedicamentoTest()
        {
            CultureInfo.CurrentUICulture = new CultureInfo("pt-BR");
        }

        [TestMethod]
        public void Nome_do_medicamento_deve_ser_obrigatorio()
        {
            //arrange
            var m = new Medicamento();
            m.Nome = null;

            ValidadorMedicamento validador = new ValidadorMedicamento();

            //action
            var resultado = validador.Validate(m);

            //assert
            Assert.AreEqual("O campo do nome é obrigatório", resultado.Errors[0].ErrorMessage);
        }
        public void Validade_do_medicamento_deve_ser_obrigatorio()
        {
            //arrange
            var m = new Medicamento();
            m.Nome = "Decongex";
            m.Validade = DateTime.MinValue;

            ValidadorMedicamento validador = new ValidadorMedicamento();

            //action
            var resultado = validador.Validate(m);

            //assert
            Assert.AreEqual("O campo de validade é obrigatório", resultado.Errors[0].ErrorMessage);
        }
    }
}
