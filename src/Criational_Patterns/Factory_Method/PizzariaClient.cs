using System;

namespace Factory_Method
{
    public static class PizzariaLocalClient
    {
        public static void SolicitarPedido()
        {
            Console.WriteLine("========= Pizzaria ======\n");
            Console.WriteLine("Informe o local (S)São Paulo  (R)Rio de Janeiro");
            var localEscolhido = Console.ReadLine().ToUpper();

            Console.WriteLine("Escolha a pizza (M)ussarela  (C)Calabreza");
            var pizzaEscolhida = Console.ReadLine().ToUpper();

            try
            {
                PizzaFactoryMethodCreator pizzaria =
                    PizzariaSimpleFactory.SelecionarPizzaria(localEscolhido);

                var pizza = pizzaria.MontaPizza(pizzaEscolhida);

                Console.WriteLine(pizza.Preparar());
                Console.WriteLine("\nPizza concluida com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro :" + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
