using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juridico
{
   public class Escritorio
    {
        public int Numero { get; set; }
        public string Endereco { get; set; }
        public int cnpj { get; set; }
        public char Tipo { get; set; }//M = Matriz, F = Filial
    }
}
