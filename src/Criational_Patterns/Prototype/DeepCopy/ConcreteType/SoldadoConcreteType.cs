using System;

namespace Prototype.DeepCopy.ConcreteType
{
    public class SoldadoConcreteType : ICloneable
    {
        public string Nome { get; set; }
        public string Arma { get; set; }
        public AcessorioConcreteType Acessorio { get; set; }

        public SoldadoConcreteType(){}

        public SoldadoConcreteType(SoldadoConcreteType soldado) 
        {
            Nome = soldado.Nome;
            Arma = soldado.Arma;
            Acessorio = soldado.Acessorio;
        }

        public object Clone()
        {
            SoldadoConcreteType soldado = (SoldadoConcreteType)this.MemberwiseClone();
            soldado.Acessorio = (AcessorioConcreteType)Acessorio.Clone();
            return soldado;
        }
    }
}
