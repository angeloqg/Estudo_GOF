using Factory_Method.ConcreteProduct;

namespace Factory_Method.Factory
{
    public class PizzaFactoryRJ : PizzaFactoryMethodCreator
    {
        protected override PizzaProduct CriarPizza(string tipo)
        {
            if (tipo.Equals("M"))
            {
                return new PizzaMussarelaRJConcreteProduct();
            }
            else if (tipo.Equals("C"))
            {
                return new PizzaCalabrezaRJConcreteProduct();
            }
            else return null;
        }
    }
}
