using System;

namespace Simple_Factory
{
    public static class PizzariaClient
    {
        public static void SolicitarPedido()
        {
            Console.WriteLine("====== Pizzaria ==========");
            Console.WriteLine("Informe a Pizza (C)alabreza ou (M)ussarela: ");

            Console.ForegroundColor = ConsoleColor.Black;
            var tipo = Console.ReadKey().Key.ToString().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");

            try
            {
                PizzaAbstractProduct pizza = PizzariaSimpleFactory.CriarPizza(tipo);
                pizza.Preparar();
                pizza.Assar(10);
                pizza.Embalar();

                Console.WriteLine("\nPizza Concluída.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}
