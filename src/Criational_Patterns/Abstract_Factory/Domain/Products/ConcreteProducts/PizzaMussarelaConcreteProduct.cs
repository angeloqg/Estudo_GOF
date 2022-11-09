using Abstract_Factory.Domain.Products.AbstractProducts;

namespace Abstract_Factory.Domain.Products.ConcreteProducts
{
    public sealed class PizzaMussarelaConcreteProduct : PizzaAbstractProduct
    {
        public PizzaMussarelaConcreteProduct() : base("Pizza Mussarela", Enums.ETipoMassa.Pizza)
        {
            Ingredientes.Add("Queijo mussarela gratinado e molho de tomate");
        }
    }
}
