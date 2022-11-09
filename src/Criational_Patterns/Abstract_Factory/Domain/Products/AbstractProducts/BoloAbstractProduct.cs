using Abstract_Factory.Domain.Enums;
using Abstract_Factory.Domain.Products.AbstractBase;

namespace Abstract_Factory.Domain.Products.AbstractProducts
{
    public abstract class BoloAbstractProduct : MassaBaseAbstractProduct
    {
        public BoloAbstractProduct(string nome, ETipoMassa tipoMassa) : base(nome, tipoMassa)
        {
        }
    }
}
