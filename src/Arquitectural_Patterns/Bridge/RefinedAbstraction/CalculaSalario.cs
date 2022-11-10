using Bridge.Abstraction;
using Bridge.Domain;
using Bridge.Implementor;
using System;

namespace Bridge.RefinedAbstraction
{
    public class CalculaSalario : AbstractionGeraArquivo
    {
        private new readonly IGeraArquivoBridge _geraArquivo;

        public CalculaSalario(IGeraArquivoBridge geraArquivo) : base(geraArquivo)
        {
            _geraArquivo = geraArquivo;
        }

        public void ProcessaSalarioFuncionario(Funcionario funcionario)
        {
            funcionario.SalarioTotal = funcionario.SalarioBase + funcionario.Incentivo;

            Console.WriteLine($"Valor do Salário Total para o funcionário {funcionario.Nome}: R$ {funcionario.SalarioTotal}");

            _geraArquivo.GravaArquivo(funcionario);
        }
    }
}
