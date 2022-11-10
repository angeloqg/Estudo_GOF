using Adapter.Adapter;
using Adapter.Target;
using System;

namespace Adapter
{
    public static class ClientAdapter
    {
        public static void ExecutarAdapter()
        {
            string[,] alunosArray = new string[5, 4] 
            {
                {"101", "Maria", "Artes", "1000" },
                {"101", "Pedro", "Engenharia", "2000" },
                {"101", "Bianca", "Veterinaria", "3000" },
                {"101", "Pamela", "Moda", "900" },
                {"101", "Sergio", "Desenho", "850" }
            };

            ITarget target = new AlunoAdapter();

            Console.WriteLine("SistemaMensalidades passa o array de string para o Adapter");

            target.ProcessaCalculoMensalidade(alunosArray);

            Console.ReadKey();
        }
    }
}
