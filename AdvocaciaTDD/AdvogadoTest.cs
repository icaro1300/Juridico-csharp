using AdvocaciaPrincipal.Modelos;
using System;
using Xunit;

namespace AdvocaciaTDD
{
    public class AdvogadoTest
    {
        [Fact]
        public void Test1()
        {
            Advogado ad = new Advogado();
            ad.Idade = 20;
            bool esperado = true;
            bool resultado = false;
            //act 
          resultado =  ad.verificarSeAdvogadoEMaiorIdade();

            //assert
            Assert.Equal(esperado, resultado);

        }
    }
}
