using Abstract_Factory.Domain.Enums;
using Abstract_Factory.Domain.Products.AbstractBase;
using Abstract_Factory.Domain.Products.ConcreteProducts;
using System;

namespace Abstract_Factory.Factories
{
    public sealed class PizzaConcreteFactory : MassasAbstractFactory
    {
        public override MassaBaseAbstractProduct CriarMassa(ETipoMassa tipoMassa)
        {
            var tipoPizza = (ETipoPizza)tipoMassa;

            switch (tipoPizza)
            {
                case ETipoPizza.Mussarela:
                    {
                        return new PizzaMussarelaConcreteProduct();
                    }
                case ETipoPizza.Calabreza:
                    {
                        return new PizzaCalabrezaConcreteProduct();
                    }
                default:
                    throw new ArgumentOutOfRangeException("Tipo não implementado");

            }
            throw new NotImplementedException();
        }
    }
}
