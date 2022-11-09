using Abstract_Factory.Domain.Enums;
using Abstract_Factory.Domain.Products.AbstractBase;
using Abstract_Factory.Factories;
using System;

namespace Abstract_Factory
{
    public static class MassaFactoryClient
    {
        private static MassasAbstractFactory boloFactory;
        private static MassasAbstractFactory pizzaFactory;

        private static void ObtemFabricas()
        {
            boloFactory = MassasAbstractFactory.CriarFabricaMassas(ETipoMassa.Bolo);
            pizzaFactory = MassasAbstractFactory.CriarFabricaMassas(ETipoMassa.Pizza);
        }


        private static void ExibeDetalhes(MassaBaseAbstractProduct massaBase)
        {
            Console.WriteLine($"Tipo: {massaBase.TipoMassa}");
            Console.WriteLine($"Massa: {massaBase.Nome}");
            Console.WriteLine($"Ingredientes: {massaBase.Ingredientes[0].ToString()}");
            Console.WriteLine("\n");
        }


        public static void ExibeProdutos()
        {
            ObtemFabricas();

            var bolo1 = boloFactory.CriarMassa((ETipoMassa)ETipoBolo.Chocolate);
            var bolo2 = boloFactory.CriarMassa((ETipoMassa)ETipoBolo.Laranja);
            var Pizza1 = pizzaFactory.CriarMassa((ETipoMassa)ETipoPizza.Mussarela);
            var Pizza2 = pizzaFactory.CriarMassa((ETipoMassa)ETipoPizza.Calabreza);

            ExibeDetalhes(bolo1);
            ExibeDetalhes(bolo2);
            ExibeDetalhes(Pizza1);
            ExibeDetalhes(Pizza2);
        }
    }
}
