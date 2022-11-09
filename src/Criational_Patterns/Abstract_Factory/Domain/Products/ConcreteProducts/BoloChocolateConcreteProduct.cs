using Abstract_Factory.Domain.Products.AbstractProducts;

namespace Abstract_Factory.Domain.Products.ConcreteProducts
{
    public sealed class BoloChocolateConcreteProduct : BoloAbstractProduct
    {
        public BoloChocolateConcreteProduct() : base("Bolo de Chocolate", Enums.ETipoMassa.Bolo)
        {
            Ingredientes.Add("Com cobertura de chocolate Nestlé");
        }
    }
}
