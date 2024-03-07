using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2___2º_Bimestre__EC3_
{
    class AviaoGuerra : Veiculo, IAtacar
    {
        public int capacidadePassageiros { get; set; }
        public string Pousar()
        {
            return $"Veículo {identificacao} pousado";
        }
        public string Arremeter()
        {
            return $"Veículo {identificacao} arremetido";
        }
        public string Decolar()
        {
            return $"Veículo {identificacao} decolado";
        }
        public string Atacar()
        {
            return $"Veículo {identificacao} atacando...";
        }
        public string Ejetar()
        {
            return $"O passageiro do veículo {identificacao} foi ejetado";
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
