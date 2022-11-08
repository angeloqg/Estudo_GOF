using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public abstract class PizzaFactoryMethodCreator
    {
        protected abstract PizzaProduct CriarPizza(string tipo);

        public PizzaProduct MontaPizza(string tipo)
        {
            PizzaProduct pizza = CriarPizza(tipo);
            return pizza;
        }
    }
}
