using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2___2º_Bimestre__EC3_
{
    class Caminhao : Veiculo, ILimpador, IPagarPedagio
    {

        public double pesoCarregado { get; set; } //kg
        public int qtdEixos { get; set; }
        public int capacidadePassageiros { get; set; }
        public double capacidadeMaximaCarregavel { get; set; } //kg
                                                               //Se ultrapassada, o veículo não deve acelerar, sendo indicado gerar uma uma exceção

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
            double total = 8.5 * qtdEixos;
            return $"Taxa de 8,50 reais por eixo, total de: {Convert.ToString(total)}";
            //8,50 conto por eixo
        }
        public string Carregar(double peso)
        {
            pesoCarregado += peso;
            return $"O peso do veículo {identificacao} é de {pesoCarregado} kg";

            //carrega o caminhão com um determinado peso, acumulando.
        }
        public string Descarregar(double peso)
        {
            pesoCarregado *= peso;
            return "Caminhão descarregado";
            //retira todo o peso do caminhão
        }

        public override string Acelera()
        {
            try
            {

                if (pesoCarregado > capacidadeMaximaCarregavel)
                {
                    throw new Exception("O caminhão não acelerará, pois está sobrecarregado");
                }
                else
                {
                    return $"A velocidade do veículo {identificacao} é: {Convert.ToInt32(velocidadeAtual += 1)} km/h";
                }
            }
            catch (Exception erro)
            {
                return erro.Message;
            }
        }
        public override string Desacelera()
        {
            return $"A velocidade do veículo {identificacao} é: {Convert.ToInt32(velocidadeAtual -= 1)} km/h";
        }
    }
}
