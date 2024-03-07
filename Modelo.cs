using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2___2º_Bimestre__EC3_
{
    public class Modelo
    {
        public int codigo { get; set; }
        public string descricao { get; set; }
        public string descMarca { get; set; }
        public Marca marca { get; set; }
    }
}
