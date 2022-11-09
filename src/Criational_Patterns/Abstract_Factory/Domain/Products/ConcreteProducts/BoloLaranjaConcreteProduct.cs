using Abstract_Factory.Domain.Products.AbstractProducts;

namespace Abstract_Factory.Domain.Products.ConcreteProducts
{
    public sealed class BoloLaranjaConcreteProduct : BoloAbstractProduct
    {
        public BoloLaranjaConcreteProduct() : base("Bolo de Laranja", Enums.ETipoMassa.Bolo)
        {
            Ingredientes.Add("Com cobertura de calda de laranja");
        }
    }
}
