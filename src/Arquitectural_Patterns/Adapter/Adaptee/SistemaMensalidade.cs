using Adapter.Domain;
using System;
using System.Collections.Generic;

namespace Adapter.Adaptee
{
    public class SistemaMensalidade
    {
        public void CalculaMensalidade(List<Aluno> listaAlunos)
        {
            foreach (Aluno aluno in listaAlunos)
            {
                // Usa lógica para calcular a mensalidade
                Console.WriteLine($"Aluno: {aluno.Nome} - Curso: {aluno.Curso}" +
                    $" - Valor da mensalidade R$ {aluno.Mensalidade}");
            }
        }
    }
}
