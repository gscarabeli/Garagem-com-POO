using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2___2º_Bimestre__EC3_
{
    class Moto : Veiculo, IPagarPedagio
    {
        public int capacidadePassageiros { get; set; }

        public string Empinar() 
        {
            return $"Veículo {identificacao} está empinando...";
        }
        public string pagarPedagio()
        {
            return ("Taxa fixa de 3 reais");
            //fixo 3,00 conto
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
