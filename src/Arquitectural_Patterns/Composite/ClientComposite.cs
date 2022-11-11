using Composite.Composite;
using Composite.Leaf;
using System;

namespace Composite
{
    public static class ClientComposite
    {
        public static void ExecutaPattern()
        {
            Console.WriteLine("Criando a estrutura da empresa - Composite");
            Console.WriteLine(">>> Adicionando departamentos de TI e Compatibilidade");
            Organizacao organizacao = new Organizacao { Nome = "JcmSoft Inc." };

            Organizacao departamentoTI = new Organizacao { Nome = "TI" };
            departamentoTI.Add(new Funcionario { Id = 1001, Nome = "Maria", Horas = 8 });
            departamentoTI.Add(new Funcionario { Id = 1002, Nome = "Miguel", Horas = 6 });
            departamentoTI.Add(new Funcionario { Id = 1005, Nome = "Samuel", Horas = 8 });

            Organizacao departamentoContabilidade = new Organizacao { Nome = "Contabilidade" };
            departamentoContabilidade.Add(new Funcionario { Id = 1003, Nome = "Beatriz", Horas = 7 });
            departamentoContabilidade.Add(new Funcionario { Id = 1004, Nome = "Paulo", Horas = 5 });

            organizacao.Add(departamentoTI);
            organizacao.Add(departamentoContabilidade);
            organizacao.GetHoraTrabalhada();

            Console.WriteLine(">>> Removendo o departamento de Compatibilidade");
            var departamento = organizacao.LocalizarDeparatamento("Contabilidade");

            organizacao.Remove(departamento);
            organizacao.GetHoraTrabalhada();
        }
    }
}
