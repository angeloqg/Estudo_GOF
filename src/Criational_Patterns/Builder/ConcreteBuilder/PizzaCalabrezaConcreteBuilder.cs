using Builder.Builder;
using Builder.Product.Enums;
using System.Collections.Generic;

namespace Builder.ConcreteBuilder
{
    public sealed class PizzaCalabrezaConcreteBuilder : PizzaBuilder
    {
        public override void IncluiIngredientes()
        {
            pizza.TipoMassa = ETipoMassa.Grossa;
            pizza.TipoBorda = ETipoBorda.Normal;
            pizza.Tamanho = ETamanho.Grande;
        }

        public override void PreparaPizza()
        {
            pizza.Ingredientes = new List<string> { "Calabreza em fatias", "Molho de tomate" };
        }
    }
}
