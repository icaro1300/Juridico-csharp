using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AdvocaciaTDD
{
    public class TratamentoDeTextoTDD
    {
        private object contudo;

        [Fact]
        public void RetornarQtdTextoSENAI()
        {
            //Arrange(preparação)
            int esperado = 5; //5 letras
            int resultado = 0;

            //Act(agir)
            TratamentoDeTextoTDD tratamento = new TratamentoDeTextoTDD();
            resultado = tratamento.qtdDeTexto("SENAI");
              
            //Assert(afirmação)
            Assert.Equal(esperado, resultado);
        }

         [Fact]
        public void VerificarSesitrocandoPorSenainoTexto()
        {
            //Arrange(preparação)
            string conteudo = "Escola SESI em Estância";
            string esperado = "Escola SENAI em Estância";
            string resultado;

            //Act(agir)
            TratamentoDeTextoTDD tratamento = new TratamentoDeTextoTDD();
            resultado = tratamento.TextoAlterado(conteudo);

            //Assert(afirmação)
            Assert.Equal(esperado, resultado);

        }

        private string TextoAlterado(object contudo)
        {
            throw new NotImplementedException();
        }

        private int qtdDeTexto(string v)
        {
            throw new NotImplementedException();
        }
    }
}
