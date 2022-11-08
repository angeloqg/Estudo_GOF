namespace Factory_Method.ConcreteProduct
{
    public class PizzaMussarelaRJConcreteProduct : PizzaProduct
    {
        public PizzaMussarelaRJConcreteProduct()
        {
            Nome = "Pizza de mussarela Carioca";
            Massa = "Massa tradicional carioca";
            Molho = "Molho de tomate italiano carioca";

            ingredientes.Add("> Queijo parmessão ralado");
            ingredientes.Add("> Azeitonas pretas");
        }
    }
}
