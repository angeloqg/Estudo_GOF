namespace Prototype.DeepCopy.ConcreteType
{
    public class AcessorioConcreteType
    {
        public string Nome { get; set; }

        public object Clone()
        {
            return (AcessorioConcreteType)this.MemberwiseClone();
        }
    }
}
