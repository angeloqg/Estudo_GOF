using Composite.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Composite
{
    public class Organizacao : HoraTrabalhada
    {
        protected List<HoraTrabalhada> departamentos = new List<HoraTrabalhada>();

        public override void Add(HoraTrabalhada component)
        {
            departamentos.Add(component);
        }

        public override void Remove(HoraTrabalhada component)
        {
            departamentos.Remove(component);
        }

        public override HoraTrabalhada LocalizarDeparatamento(string organizacao)
        {
            return departamentos.First(x => x.Nome == organizacao);
        }

        public override int GetHoraTrabalhada()
        {
            int horasTrabalhadasDepartamento = 0;

            foreach (var departamento in departamentos)
            {
                horasTrabalhadasDepartamento += departamento.GetHoraTrabalhada();
            }

            Console.WriteLine($"\n{Nome} registrou um total de [{horasTrabalhadasDepartamento}] horas\n");

            return horasTrabalhadasDepartamento;
        }
    }
}
