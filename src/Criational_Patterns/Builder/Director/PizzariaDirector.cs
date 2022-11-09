using Builder.Builder;
using Builder.Product;

namespace Builder.Director
{
    public class PizzariaDirector
    {
        private readonly PizzaBuilder builder;

        public PizzariaDirector(PizzaBuilder builder)
        {
            this.builder = builder;
        }

        public void MontaPizzaConstruct()
        {
            builder.CriaPizza();
            builder.PreparaPizza();
            builder.IncluiIngredientes();
        }

        public PizzaProduct GetPizza()
        {
            return builder.GetPizza();
        }
    }
}
