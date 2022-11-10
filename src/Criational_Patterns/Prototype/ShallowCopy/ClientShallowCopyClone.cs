using Prototype.ShallowCopy.ConcreteType;
using System;
using System.Collections.Generic;

namespace Prototype.ShallowCopy
{
    public static class ClientShallowCopyClone
    {
        public static void UsandoShallowCopy()
        {
            List<SoldadoConcreteType> clone = new List<SoldadoConcreteType>();

            Console.WriteLine("========== Usando Shallow Copy ============");

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
                    soldado.Acessorio = new AcessorioConcreteType { Nome = "" };
                    clone.Add(soldado);

                    int total = 1;

                    while (total < Convert.ToInt32(numeroSoldados))
                    {

                        var cloneSoldado = (SoldadoConcreteType)soldado.Clone();
                        Console.WriteLine($"Informe o nome do soldado [{total + 1}]: ");
                        cloneSoldado.Nome = Console.ReadLine();
                        Console.WriteLine($"Informe a arma do soldado [{total + 1}]: ");
                        cloneSoldado.Arma = Console.ReadLine();
                        cloneSoldado.Acessorio.Nome = "";

                        total++;

                        if (total == Convert.ToInt32(numeroSoldados))
                        {
                            Console.WriteLine($"Informe o Acessório para os soldados: ");
                            cloneSoldado.Acessorio.Nome = Console.ReadLine();
                        }

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
