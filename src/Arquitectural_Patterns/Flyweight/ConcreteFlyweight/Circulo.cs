using Flyweight.Flyweight;
using System;

namespace Flyweight.ConcreteFlyweight
{
    public class Circulo : IForma
    {
        // Estado extrínseco
        public string Cor { get; set; }

        // Estado intrínseco
        private const int x = 10;
        private const int y = 20;
        private const int raio = 30;

        public void SetCor(string cor)
        {
            this.Cor = cor;
        }

        public void Desenhar()
        {
            Console.WriteLine($"Círculo: Desenhar() [Cor: {Cor}] x:{x}, y:{y}, raio:{raio}");
        }
    }
}
