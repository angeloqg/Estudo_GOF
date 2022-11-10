﻿using Adapter.Adaptee;
using Adapter.Domain;
using Adapter.Target;
using System;
using System.Collections.Generic;

namespace Adapter.Adapter
{
    public class AlunoAdapter : ITarget
    {
        private SistemaMensalidade sistemaMensalidade = new SistemaMensalidade();

        public void ProcessaCalculoMensalidade(string[,] alunosArray)
        {
            string Id = null;
            string Nome = null;
            string Curso = null;
            string Mensalidade = null;

            List<Aluno> listaAlunos = new List<Aluno>();

            for (int i = 0; i < alunosArray.GetLength(0); i++)
            {
                for (int j = 0; j < alunosArray.GetLength(1); j++)
                {
                    if(j == 0)
                    {
                        Id = alunosArray[i, j];
                    } else if(j == 1)
                    {
                        Nome = alunosArray[i, j];
                    }
                    else if (j == 2)
                    {
                        Curso = alunosArray[i, j];
                    }
                    else
                    {
                        Mensalidade = alunosArray[i, j];
                    }
                }
                listaAlunos.Add(new Aluno(Convert.ToInt32(Id),
                                          Nome,
                                          Curso,
                                          Convert.ToDecimal(Mensalidade)));
            }

            Console.WriteLine("O Adapter converteu o Array[] para List<> de Alunos\n");
            Console.WriteLine("E delegou ao sistemaMensalidade o processamento da mensalidade dos alunos\n");
            
            sistemaMensalidade.CalculaMensalidade(listaAlunos);
        }
    }
}
