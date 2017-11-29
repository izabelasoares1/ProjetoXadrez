using System;
using Tabuleiro;

namespace projeto_final_part1 {
    class Program {
        static void Main(string[] args) {

            Posicao P;

            P = new Tabuleiro.Posicao(3, 4);

            Console.WriteLine("Posição: " + P);

            Console.ReadLine();
        }
    }
}
