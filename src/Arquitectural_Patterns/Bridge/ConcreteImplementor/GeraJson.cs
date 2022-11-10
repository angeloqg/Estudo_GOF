using Bridge.Domain;
using Bridge.Implementor;
using System;
using System.IO;
using System.Text.Json;

namespace Bridge.ConcreteImplementor
{
    public class GeraJson : IGeraArquivoBridge
    {
        private string nomeArquivo = "SalarioFuncionario.json";

        public void GravaArquivo(Funcionario funcionario)
        {
            var funcionarioSerializado = JsonSerializer.Serialize(funcionario);

            File.WriteAllText(nomeArquivo, funcionarioSerializado);

            Console.WriteLine($"Salário para o funcionário: {funcionario.Nome} " +
                              $"gerado com sucesso em: {nomeArquivo}\n");
        }
    }
}
