using Abstract_Factory.Domain.Enums;
using Abstract_Factory.Domain.Products.AbstractBase;

namespace Abstract_Factory.Domain.Products.AbstractProducts
{
    public abstract class PizzaAbstractProduct : MassaBaseAbstractProduct
    {
        public PizzaAbstractProduct(string nome, ETipoMassa tipoMassa) : base(nome, tipoMassa)
        {
        }
    }
}
