using Builder.Builder;
using Builder.Product.Enums;
using System.Collections.Generic;

namespace Builder.ConcreteBuilder
{
    public sealed class PizzaMussarelaConcreteBuilder : PizzaBuilder
    {
        public override void IncluiIngredientes()
        {
            pizza.TipoMassa = ETipoMassa.Normal;
            pizza.TipoBorda = ETipoBorda.Recheada;
            pizza.Tamanho = ETamanho.Grande;
        }

        public override void PreparaPizza()
        {
            pizza.Ingredientes = new List<string> { "Mussarela", "Molho de tomate","Orégano" };
        }
    }
}
