namespace Factory_Method.ConcreteProduct
{
    public class PizzaCalabrezaRJConcreteProduct : PizzaProduct
    {
        public PizzaCalabrezaRJConcreteProduct()
        {
            Nome = "Pizza de calabreza Carioca com cebola";
            Massa = "Massa tradicional carioca";
            Molho = "Molho de tomate italiano carioca";

            ingredientes.Add("> Fatias de calabreza especial");
            ingredientes.Add("> Queijo parmessão italiano tradicional");
        }
    }
}
