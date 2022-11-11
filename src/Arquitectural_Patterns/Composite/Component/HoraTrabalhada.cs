using System.Collections.Generic;

namespace Composite.Component
{
    public abstract class HoraTrabalhada
    {
        public HoraTrabalhada() { }
        public string Nome { get; set; }
        public abstract int GetHoraTrabalhada();
        public virtual void Add(HoraTrabalhada component) { }
        public virtual void Remove(HoraTrabalhada component) { }
        public virtual HoraTrabalhada LocalizarDeparatamento(string organicazao)
        {
            return null;
        }
    }
}
