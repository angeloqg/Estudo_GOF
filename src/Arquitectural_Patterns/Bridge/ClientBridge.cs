using Bridge.ConcreteImplementor;
using Bridge.Domain;
using Bridge.RefinedAbstraction;
using System;

namespace Bridge
{
    public static class ClientBridge
    {
        public static void ExecutPattern()
        {
            // RedefineAbstraction recebe via construtor em tempo de execução
            // o tipo específico de formato para gerar o arquivo
            // e usa a classe base AbstractionGeraArquivo para obter uma
            // instância de IGeraArquivo (Bridge)
            CalculaSalario calculaSalario = new CalculaSalario(new GeraXML());

            // Define os dados do funcionário
            Funcionario funcionario = new Funcionario
            {
                Id = 101,
                Nome = "Angelo",
                SalarioBase = 3000,
                Incentivo = 2000
            };

            // Processa o salário
            calculaSalario.ProcessaSalarioFuncionario(funcionario);

            // Altera o valor do incentivo em tempo de execução
            funcionario.Incentivo = 2500;

            // Altera o formato para gerar o arquivo em tempo de execução
            calculaSalario = new CalculaSalario(new GeraJson());

            calculaSalario.ProcessaSalarioFuncionario(funcionario);
            
            Console.ReadKey();
        }
    }
}
