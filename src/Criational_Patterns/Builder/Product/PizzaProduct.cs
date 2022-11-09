using Builder.Product.Enums;
using System;
using System.Collections.Generic;

namespace Builder.Product
{
    public class PizzaProduct
    {
        public ETipoMassa TipoMassa { get; set; }
        public ETipoBorda TipoBorda { get; set; }
        public ETamanho Tamanho { get; set; }
        public List<string> Ingredientes { get; set; }

        public void PizzaConteudo()
        {
            Console.WriteLine($"Pizza com massa: {TipoMassa}");
            Console.WriteLine($"Tipo de borda: {TipoBorda}");
            Console.WriteLine($"Tamanho: {Tamanho}");

            foreach(var item in Ingredientes)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("\n\n");
        }
    }
}
