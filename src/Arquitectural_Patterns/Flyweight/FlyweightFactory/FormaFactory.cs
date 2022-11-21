using Flyweight.ConcreteFlyweight;
using Flyweight.Flyweight;
using System;
using System.Collections.Generic;

namespace Flyweight.FlyweightFactory
{
    public class FormaFactory
    {
        private static Dictionary<string, IForma> formas = new Dictionary<string, IForma>();

        // Cria e gerencia objetos
        public static IForma GetForma(string chave)
        {
            IForma forma = null;

            if (formas.ContainsKey(chave))
            {
                return formas[chave];
            }
            else
            {
                if(chave == "circulo")
                {
                    forma = new Circulo();
                    formas.Add("circulo", forma);
                }
                else
                {
                    throw new Exception("Este tipo de objeto não pode ser criado");
                }
            }

            return forma;
        }
    }
}
