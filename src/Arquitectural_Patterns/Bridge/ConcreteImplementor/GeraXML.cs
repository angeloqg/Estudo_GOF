using Bridge.Domain;
using Bridge.Implementor;
using System;
using System.IO;
using System.Xml.Serialization;

namespace Bridge.ConcreteImplementor
{
    public class GeraXML : IGeraArquivoBridge
    {
        private string nomeArquivo = "SalarioFuncionario.xml";
        private XmlSerializer xmlSerializer = new XmlSerializer(typeof(Funcionario));
        private FileStream fileStream;

        public void GravaArquivo(Funcionario funcionario)
        {
            fileStream = new FileStream(nomeArquivo, FileMode.OpenOrCreate);

            xmlSerializer.Serialize(fileStream, funcionario);

            Console.WriteLine($"Salário para o funcionário: {funcionario.Nome} " +
                  $"gerado com sucesso em: {nomeArquivo}\n");
        }
    }
}
