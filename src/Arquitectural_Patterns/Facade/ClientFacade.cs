using Facade.Facade;
using Facade.Subistemas;
using System;

namespace Facade
{
    public static class ClientFacade
    {
        public static void ExecutPattern()
        {
            // Cria uma instância do Facade
            MeuFacade concedeCreditoFacade = new MeuFacade();

            // Cria uma instância de um  novo Cliente informando o nome
            Cliente cliente1 = new Cliente("Angelo");

            //Utiliza o Facade para verificar condições de concessão ou não
            bool resultado = concedeCreditoFacade.ConcederEmprestimo(cliente1, 199000.00);

            //exibe o resultado
            Console.WriteLine($"O empréstimo pleiteado pelo cliente {cliente1.Nome} foi " + (resultado ? "Aprovado" : "Negado"));

            //aguarda
            Console.ReadKey();
        }
    }
}
