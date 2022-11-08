using Factory_Method.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public static class PizzariaSimpleFactory
    {
        public static PizzaFactoryMethodCreator SelecionarPizzaria(string local)
        {
            PizzaFactoryMethodCreator pizzaria;

            switch (local)
            {
                case "S":
                    pizzaria = new PizzaFactorySP();
                    break;
                case "R":
                    pizzaria = new PizzaFactoryRJ();
                    break;
                default:
                    throw new ApplicationException("A pizzaria não foi informada");
            }


            return pizzaria;
        }
    }
}
