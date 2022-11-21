using Flyweight.ConcreteFlyweight;
using Flyweight.FlyweightFactory;
using System;

namespace Flyweight
{
    public static class ClientFlyweight
    {
        public static void ExecutPattern()
        {
            Console.WriteLine("\n### Círculos Amarelos ");
            for (int i = 0; i < 3; i++)
            {
                var circulo = (Circulo)FormaFactory.GetForma("circulo");
                circulo.SetCor("Amarelo");
                circulo.Desenhar();
            }
            Console.WriteLine("\n### Círculos Verdes ");
            for (int i = 0; i < 3; i++)
            {
                var circulo = (Circulo)FormaFactory.GetForma("circulo");
                circulo.SetCor("Verde");
                circulo.Desenhar();
            }
            Console.WriteLine("\n### Círculos Azuis");
            for (int i = 0; i < 3; ++i)
            {
                var circulo = (Circulo)FormaFactory.GetForma("circulo");
                circulo.SetCor("Azul");
                circulo.Desenhar();
            }
            Console.WriteLine("\n### Círculos Vermelhos");
            for (int i = 0; i < 3; ++i)
            {
                var circulo = (Circulo)FormaFactory.GetForma("circulo");
                circulo.SetCor("Vermelho");
                circulo.Desenhar();
            }
            Console.WriteLine("\n### Círculos Pretos");
            for (int i = 0; i < 3; ++i)
            {
                var circulo = (Circulo)FormaFactory.GetForma("circulo");
                circulo.SetCor("Preto");
                circulo.Desenhar();
            }
        }
    }
}
