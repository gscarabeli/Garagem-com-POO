using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2___2º_Bimestre__EC3_
{
    public abstract class Veiculo
    {
        public string identificacao { get; set; }
        public Modelo modelo { get; set; }
        public double velocidadeAtual { get; set; }
        public double peso { get; set; } //Peso total do veículo, totalmente descarregado 
        public string tipo { get; set; }

        public virtual string Acelera()
        {
            return $"A velocidade do veículo {identificacao} é: {Convert.ToInt32(velocidadeAtual + 1)}";
            //(incrementa em 1 a velocidade)
        }
        public virtual string Desacelera()
        {
            return $"A velocidade do veículo {identificacao} é: {Convert.ToInt32(velocidadeAtual - 1)}";
            //(diminui em 1 a velocidade)
        }

    }
}
