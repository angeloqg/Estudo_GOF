using Builder.ConcreteBuilder;
using Builder.Director;
using Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public static class PizzariaBuilder
    {
        public static void GeraPizza()
        {
            List<PizzaProduct> pizzas = new List<PizzaProduct>();

            var pizzaria = new PizzariaDirector(new PizzaCalabrezaConcreteBuilder());
            pizzaria.MontaPizzaConstruct();
            pizzas.Add(pizzaria.GetPizza());

            pizzaria = new PizzariaDirector(new PizzaMussarelaConcreteBuilder());
            pizzaria.MontaPizzaConstruct();
            pizzas.Add(pizzaria.GetPizza());

            foreach(var pizza in pizzas)
            {
                pizza.PizzaConteudo();
            }
        }
    }
}
