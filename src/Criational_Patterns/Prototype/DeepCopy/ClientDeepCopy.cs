using Prototype.DeepCopy.ConcreteType;
using System;
using System.Collections.Generic;

namespace Prototype.DeepCopy
{
    public class ClientDeepCopyClone
    {
        public static void UsandoDeepCopy()
        {
            List<SoldadoConcreteType> clone = new List<SoldadoConcreteType>();

            Console.WriteLine("========== Usando Deep Copy ============");

            Console.WriteLine("Quantos soldados deseja criar? (Mínimo dois soldados)");
            string numeroSoldados = Console.ReadLine().ToString();

            try
            {
                if (Convert.ToInt32(numeroSoldados) > 1)
                {
                    SoldadoConcreteType soldado = new SoldadoConcreteType();
                    Console.WriteLine("Informe o nome do soldado [1]: ");
                    soldado.Nome = Console.ReadLine();
                    Console.WriteLine("Informe a arma do soldado [1]: ");
                    soldado.Arma = Console.ReadLine();
                    Console.WriteLine("Informe o acessório do soldado [1]: ");
                    soldado.Acessorio = new AcessorioConcreteType { Nome = Console.ReadLine() };
                    clone.Add(soldado);

                    int total = 1;

                    while (total < Convert.ToInt32(numeroSoldados))
                    {

                        var cloneSoldado = (SoldadoConcreteType)soldado.Clone();
                        Console.WriteLine($"Informe o nome do soldado [{total + 1}]: ");
                        cloneSoldado.Nome = Console.ReadLine();
                        Console.WriteLine($"Informe a arma do soldado [{total + 1}]: ");
                        cloneSoldado.Arma = Console.ReadLine();
                        Console.WriteLine($"Informe o acessório do soldado [{total + 1}]: ");
                        cloneSoldado.Acessorio.Nome = Console.ReadLine();

                        total++;

                        clone.Add(cloneSoldado);
                    }

                    Console.WriteLine("\n");
                    Console.WriteLine("Exibir pelotão de soldados:");
                    foreach (var pelotao in clone)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine($"\tSoldado: {pelotao.Nome}");
                        Console.WriteLine($"\tArma: {pelotao.Arma}");
                        Console.WriteLine($"\tAcessório: {pelotao.Acessorio.Nome}");
                    }
                }
                else
                {
                    Console.WriteLine("\nInforme pelo menos 2 (dois) soldados");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("\nValor incorreto fornecido");
            }

            Console.ReadKey();
        }
    }
}
