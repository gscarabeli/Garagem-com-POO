using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2___2º_Bimestre__EC3_
{
    class Pedagio
    {        
        public string identificacao { get; set; }
        public string localizacao { get; set; }
        public double lucroTotal { get; set; }
        
        public void Receber(IPagarPedagio veiculo)
        {
            lucroTotal += Convert.ToDouble(veiculo.pagarPedagio());
        }
    }
}
