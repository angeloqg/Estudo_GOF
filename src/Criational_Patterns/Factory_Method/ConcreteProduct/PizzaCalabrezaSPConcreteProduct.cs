namespace Factory_Method.ConcreteProduct
{
    public class PizzaCalabrezaSPConcreteProduct : PizzaProduct
    {
        public PizzaCalabrezaSPConcreteProduct()
        {
            Nome = "Pizza de calabreza Paulista com muita calabreza";
            Massa = "Massa fina crocante";
            Molho = "Molho de tomate italiano";

            ingredientes.Add("> Fatias de calabreza defumada especial");
            ingredientes.Add("> Queijo parmessão italiano tradicional");
        }
    }
}
