using Factory_Method.ConcreteProduct;

namespace Factory_Method.Factory
{
    public class PizzaFactorySP : PizzaFactoryMethodCreator
    {
        protected override PizzaProduct CriarPizza(string tipo)
        {
            if (tipo.Equals("M"))
            {
                return new PizzaCalabrezaSPConcreteProduct();
            }
            else if (tipo.Equals("C"))
            {
                return new PizzaCalabrezaSPConcreteProduct();
            }
            else return null;
        }
    }
}
