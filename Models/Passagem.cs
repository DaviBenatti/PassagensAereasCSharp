using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassagensAereasCSharp.Models
{
    public class Passagem
    {
        public Passagem(string nome, string origem, string destino, string data)
        {
            nomePassageiro = nome;
            origemVoo = origem;
            destinoVoo = destino;
            dataViagem = data;
        }
        public string nomePassageiro;
        public string origemVoo;
        public string destinoVoo;
        public string dataViagem;

        public void exibirDetalhesPassagem()
        {
            Console.WriteLine($"Nome do Passageiro: {nomePassageiro}");
            Console.WriteLine($"Origem do Voo: {origemVoo}");
            Console.WriteLine($"Destino do Voo: {destinoVoo}");
            Console.WriteLine($"Data da Viagem: {dataViagem}");
        }
    }
}