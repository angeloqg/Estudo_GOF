using System;

namespace Simple_Factory
{
    public sealed class PizzariaSimpleFactory
    {
        public static PizzaAbstractProduct CriarPizza(string tipo)
        {
            PizzaAbstractProduct pizza;

            switch (tipo)
            {
                case "C":
                    pizza = new PizzaCalabrezaConcretProduct();
                    break;
                case "M":
                    pizza = new PizzaMussarelaConcretProduct();
                    break;
                default: 
                    throw new ApplicationException("A pizza solicitada não está disponível");
            }

            return pizza;
        }
    }
}
