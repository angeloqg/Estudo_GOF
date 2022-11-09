using Abstract_Factory.Domain.Enums;
using Abstract_Factory.Domain.Products.AbstractBase;
using System;

namespace Abstract_Factory.Factories
{
    public abstract class MassasAbstractFactory
    {
        public abstract MassaBaseAbstractProduct CriarMassa(ETipoMassa tipoMassa);

        public static MassasAbstractFactory CriarFabricaMassas(ETipoMassa tipoMassa)
        {
            switch (tipoMassa)
            {
                case ETipoMassa.Pizza:
                    {
                        return new PizzaConcreteFactory();
                    }
                case ETipoMassa.Bolo:
                    {
                        return new BoloConcreteFactory();
                    }
                default:
                    throw new ArgumentOutOfRangeException(nameof(ETipoMassa), tipoMassa, null);
            }
        }
    }
}
