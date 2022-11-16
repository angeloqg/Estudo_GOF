using System;

namespace Facade.Subistemas
{
    public class Cadastro
    {
        public void CadastrarCliente(Cliente cliente)
        {
            Console.WriteLine($"Cadastro do cliente {cliente.Nome} concluído.");
        }
    }
}
