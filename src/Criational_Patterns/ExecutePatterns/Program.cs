using Abstract_Factory;
using Factory_Method;

namespace ExecutePatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Simple Factory
            // PizzariaClient.SolicitarPedido();

            // Factory Method
            //PizzariaLocalClient.SolicitarPedido();

            // Abstract Factory
            MassaFactoryClient.ExibeProdutos();
        }
    }
}
