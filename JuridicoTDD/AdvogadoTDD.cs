using System;
using Xunit;

namespace JuridicoTDD
{
    public class AdvogadoTDD
    {
        [Fact]
        public void AdvogadoRetornarNomeCompletoTrue()
        {
            //Arrange - Preparação
            Advogado adv = new Advogado();
            adv.Nome = "Vinicius";
            adv.SobreNome = "Reginaldo";
            string esperado = "Vinicius Reginaldo";
            string resultado;
            //Act
            resultado = adv.getNomeCompleto();

            ///Assert
            Assert.Equal(esperado, resultado);
        }
        [Theory]
        [InlineData ("Reginaldo", "Vinicius", "Reginaldo Vinicius")]
        [InlineData ("José", "Santos", "José Santos")]
        [InlineData ("Bozo", "Vai ser preso", "Bozo Vai ser preso")]
        public void AdvogadoRetornarNomeCompletoVariosCenarios(string nome, string sob, string esperado)
        {
            //Arrange
            Advogado adv= new Advogado();
            adv.Nome = nome;
            adv.SobreNome = sob;
            //Act
            string resultado = adv.getNomeCompleto();

            Assert.Equal(esperado, resultado);
        }
    }
}
