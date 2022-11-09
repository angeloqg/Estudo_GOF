using Abstract_Factory.Domain.Products.AbstractProducts;

namespace Abstract_Factory.Domain.Products.ConcreteProducts
{
    public sealed class PizzaCalabrezaConcreteProduct : PizzaAbstractProduct
    {
        public PizzaCalabrezaConcreteProduct() : base("Pizza Calabreza", Enums.ETipoMassa.Pizza)
        {
            Ingredientes.Add("Calabreza em cubos e tomate em cubos");
        }
    }
}
