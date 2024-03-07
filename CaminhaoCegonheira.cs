using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2___2º_Bimestre__EC3_
{
    class CaminhaoCegonheira : Caminhao
    {
        //Este é um tipo de caminhão com 2 eixos cujo objetivo é carregar até 11 veículos do tipo “Carro”.
        //Os veículos são carregados em uma ordem cuja retirada deve obedecer a ordem inversa em que foram carregados,
        //logo o primeiro veículo carregado será o último a ser descarregado. Esta forma de organizar a informação na computação
        //é conhecida como Pilha (stack) e pode ser utilizada como forma de se armazenar os carros carregados, no lugar de uma lista.
        Stack<Carro> listaDeCarros = new Stack<Carro>();
        public string CarregarVeiculo(Carro carro)
        {
            try
            {
                listaDeCarros.Push(carro);

                if (listaDeCarros.Count() > 11)
                {
                    throw new Exception("Só é permitido carregar até 11 carros");
                }
                else
                {
                    listaDeCarros.Push(carro);
                }
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }
            return "";
            //método que carrega um carro e deve gerar uma exceção caso tenha sido ultrapassada a capacidade de carregamento do caminhão
        }

        public string DescarregarVeiculo()
        {
            listaDeCarros.Pop();
            return "";
            //descarrega um carro, na ordem inversa a que foi carregado(sistema de pilha)
        }

        public string CarregarPeso()
        {
            return ("Para este tipo de veículo, é necessário usar o método Carregar Veículo");
            //deve gerar uma exceção caso seja executado, informando que neste tipo de veículo deve-se usar o CarregarVeiculo()
        }

        public string Descarregar()
        {
            listaDeCarros.Clear();
            string nomeCarro = null;
            foreach (Carro listaVeic in listaDeCarros)
            {
                nomeCarro += listaVeic.identificacao;
            }
            return "Todos os carros foram descarregados: " + nomeCarro;
            //deverá descarregar todos os veículos carregados, exibindo em vídeo os dados dos veículos descarregados.
        }

        public string Lista() 
        {
            string nomeCarro = null;
            foreach (Carro listaVeic in listaDeCarros)
            {
                nomeCarro += listaVeic.identificacao + Environment.NewLine
                    + "----------------------------------------------------------"
                    + Environment.NewLine;
            }
            return nomeCarro;
        }
        //Configure o formulário para que seja possível executar os métodos da cegonheira,
        //além de permitir listar todos os veículos que foram carregados.
    }
}
