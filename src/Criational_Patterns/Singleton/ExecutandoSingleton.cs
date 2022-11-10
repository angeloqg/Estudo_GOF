using System;
using System.Threading.Tasks;

namespace Singleton
{
    public static class ExecutandoSingleton
    {
        public static void ExecutaConexaoBanco()
        {
            Parallel.Invoke
                (
                    () => AcessoThread1(),
                    () => AcessoThread2()
                
                );
            Console.ReadLine();
        }


        private static void AcessoThread1()
        {
            BancoDeDadosSingleton s1 = BancoDeDadosSingleton.Instance;
            Console.WriteLine("Thread 1");
        }

        private static void AcessoThread2()
        {
            BancoDeDadosSingleton s2 = BancoDeDadosSingleton.Instance;
            Console.WriteLine("Thread 2");
        }
    }


}
