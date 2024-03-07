using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2___2º_Bimestre__EC3_
{
    class Carro : Veiculo, ILimpador, IPagarPedagio
    {
        public int qtdPortas { get; set; }
        public int capacidadePassageiros { get; set; }
        public bool veiculoOficial { get; set; } //isento de pedágio

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

        public string pagarPedagio() 
        {
            if (veiculoOficial == true)
            {
                return "Veículos oficiais são isentos de pedágio";
            }
            else 
            {
                return $"Taxa fixa de 7 reais paga para {identificacao}";
            }
            //fixo 7,00 conto
        }
        public override string Acelera()
        {
            return $"A velocidade do veículo {identificacao} é: {Convert.ToInt32(velocidadeAtual += 1)} km/h";
            //(incrementa em 1 a velocidade)
        }
        public override string Desacelera()
        {

            return $"A velocidade do veículo {identificacao} é: {Convert.ToInt32(velocidadeAtual -= 1)} km/h";
            //(diminui em 1 a velocidade)
        }
    }
}
