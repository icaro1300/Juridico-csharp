using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juridico
{
    public class Processo
    {
        public int Numero { get; set; }
        public DateTime DataCriacao { get; set; }
        public Pessoa Solicitante { get; set; }
        public Pessoa Acusado { get; set; }
        public Pedido Pedidos { get; set; }

        public double getValorTotalPedidos()
        {
            return 2;
        }
        public int getQuantidadePedidos()
        {
            return 1;
        }
        public int getDistribuicaoDeProcessos()
        {
            return 1;
        }


        public List<Processo> getProcessosPorEscritorio()
        {
            return null;
        }







    }
}
