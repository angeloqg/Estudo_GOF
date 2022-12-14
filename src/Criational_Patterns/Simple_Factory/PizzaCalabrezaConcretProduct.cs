using System;

namespace Simple_Factory
{
    public class PizzaCalabrezaConcretProduct : PizzaAbstractProduct
    {
        public PizzaCalabrezaConcretProduct()
        {
            Nome = "Calabreza";
        }

        public override void Preparar()
        {
            Console.WriteLine($"1) Preparando a pizza de {Nome}");
        }
        public override void Assar(int tempo)
        {
            Console.WriteLine($"2) Pizza de {Nome} assando por {tempo} minutos");
        }

        public override void Embalar()
        {
            Console.WriteLine($"3) Embalado pizza de {Nome}");
        }
    }
}
