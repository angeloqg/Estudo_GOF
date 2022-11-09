using Abstract_Factory.Domain.Enums;
using Abstract_Factory.Domain.Products.AbstractBase;
using Abstract_Factory.Domain.Products.ConcreteProducts;
using System;

namespace Abstract_Factory.Factories
{
    public sealed class BoloConcreteFactory : MassasAbstractFactory
    {
        public override MassaBaseAbstractProduct CriarMassa(ETipoMassa tipoMassa)
        {
            var tipoBolo = (ETipoBolo) tipoMassa;

            switch (tipoBolo)
            {
                case ETipoBolo.Laranja:
                    {
                        return new BoloLaranjaConcreteProduct();
                    }
                case ETipoBolo.Chocolate:
                    {
                        return new BoloChocolateConcreteProduct();
                    }
                 default:
                    throw new ArgumentOutOfRangeException("Tipo não implementado");
            }
        }
    }
}
