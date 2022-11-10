using System;

namespace Singleton
{
    public class BancoDeDadosSingleton
    {
        private static int contador = 0;
        private static BancoDeDadosSingleton instance = null;

        private static object lockObject = new object();

        public BancoDeDadosSingleton()
        {
            contador++;
            Console.WriteLine($"Instância = {contador}");
        }

        public static BancoDeDadosSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if(instance == null)
                        {
                            Console.WriteLine("Criando instância do banco de dados");
                            instance = new BancoDeDadosSingleton();
                        }                      
                    }
                }

                return instance;
            }
        }
    }
}
