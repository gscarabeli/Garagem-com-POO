using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2___2º_Bimestre__EC3_
{
    class Trem : Veiculo, ILimpador
    {
        public int qtdVagoes { get; set; }
        public int capacidadePassageiros { get; set; }

        public bool ligaLimpador = false;
        public bool desligaLimpador = false;
        public string ligaDesligaLimpador()
        {
            if (ligaLimpador == true)
            {
                desligaLimpador = false;
                return $"Limpador do veículo {identificacao} ligado";
            }
            else if (desligaLimpador == true)
            {
                ligaLimpador = false;
                return $"Limpador do veículo {identificacao} desligado";
            }
            return "O Limpador não está ligado";
        }
        public override string Acelera()
        {
            return $"A velocidade do veículo {identificacao} é: {Convert.ToInt32(velocidadeAtual + 1)}";
            //(incrementa em 1 a velocidade)
        }
        public override string Desacelera()
        {
            return $"A velocidade do veículo {identificacao} é: {Convert.ToInt32(velocidadeAtual - 1)}";
            //(diminui em 1 a velocidade)
        }
    }
}
