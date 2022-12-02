using Projeto_Teste;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace TestMSTest
{
    [TestClass]
    public class TesteUnitario
    {
        [TestMethod]
        public void SomarDoisNumeros()
        {
            //Arrange - Preparacao
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            //Act - Acao/Exeecusao
            var Resultado = Operacoes.Somar(pNum, sNum);

            //Assert - Verificacao
            Assert.AreEqual(rNum, Resultado);
        }

        //Arrange 2
        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 1, 3)]
        [DataRow(2, 2, 4)]
        [DataRow(2, 3, 5)]
        [DataRow(3, 1, 4)]
        [DataRow(4, 1, 5)]

        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //Act
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert 2
            Assert.AreEqual(rNum, resultado);
        }

    }
}
