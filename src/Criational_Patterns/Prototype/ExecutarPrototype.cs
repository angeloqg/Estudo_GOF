using Prototype.DeepCopy;
using Prototype.ShallowCopy;
using System;

namespace Prototype
{
    public static class ExecutarPrototype
    {
        public static void Clonar()
        {
            Console.WriteLine("========== Usando Prototype ============");
            Console.WriteLine("Escolha: [1] Shallow Copy ou [2] Deep Copy");

            var opcao = Console.ReadKey().KeyChar.ToString();

            try
            {
                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        ClientShallowCopyClone.UsandoShallowCopy();
                        break;
                    case "2":
                        Console.Clear();
                        ClientDeepCopyClone.UsandoDeepCopy();
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Opção inválida");
            }           
        }
    }
}
