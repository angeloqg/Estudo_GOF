using Builder.Product;

namespace Builder.Builder
{
    public abstract class PizzaBuilder
    {
        protected PizzaProduct pizza;

        public void CriaPizza()
        {
            pizza = new PizzaProduct();
        }

        public PizzaProduct GetPizza()
        {
            return pizza;
        }

        public abstract void PreparaPizza();
        public abstract void IncluiIngredientes();
    }
}
