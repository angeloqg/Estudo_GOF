namespace Factory_Method.ConcreteProduct
{
    public class PizzaMussarelaSPConcreteProduct : PizzaProduct
    {
        public PizzaMussarelaSPConcreteProduct()
        {
            Nome = "Pizza de mussarela Paulista";
            Massa = "Massa fina crocante paulista";
            Molho = "Molho de tomate italiano paulista";

            ingredientes.Add("> Queijo parmessão");
            ingredientes.Add("> Azeitonas verdes");
        }
    }
}
