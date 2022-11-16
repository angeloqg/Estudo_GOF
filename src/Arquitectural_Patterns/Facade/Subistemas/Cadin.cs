using System;

namespace Facade.Subistemas
{
    public class Cadin
    {
        public bool EstaNoCadin(Cliente cliente)
        {
            Console.WriteLine("Verificando o CADIN para o cliente " + cliente.Nome);
            return false;
        }
    }
}
