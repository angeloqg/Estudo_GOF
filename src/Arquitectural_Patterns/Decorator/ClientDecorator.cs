using Decorator.Component;
using Decorator.ConcreteComponent;
using Decorator.ConcreteDecorator;
using System;

namespace Decorator
{
    public static class ClientDecorator
    {
        public static void ExecutPattern()
        {
            IPizza pizza = new Pizza();

            Console.WriteLine(pizza.Opcionais());
            Console.WriteLine($"Preco R$ {pizza.Preco()}\n");
            Console.WriteLine("Tecle algo para aplicar o padrão Decorator");
            Console.ReadKey();

            Console.WriteLine("------ Aplicando o Decorator ------------------");

            IPizza massaEspecial = new MassaEspecialDecorator(pizza);
            Console.WriteLine(massaEspecial.Opcionais());
            Console.WriteLine($"Preco Total R$ : {massaEspecial.Preco()}\n");

            IPizza baconDecorator = new BaconDecorator(massaEspecial);
            Console.WriteLine(baconDecorator.Opcionais());
            Console.WriteLine($"Preco Total R$ : {baconDecorator.Preco()}\n");

            IPizza bordaRecheadaDecorator = new BordaRecheadaDecorator(baconDecorator);

            Console.WriteLine(bordaRecheadaDecorator.Opcionais());
            Console.WriteLine($"Preco Total R$ : {bordaRecheadaDecorator.Preco()}\n");

            Console.ReadKey();
        }
    }
}
