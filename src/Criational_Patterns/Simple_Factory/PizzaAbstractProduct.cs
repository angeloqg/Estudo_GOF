namespace Simple_Factory
{
    public abstract class PizzaAbstractProduct
    {
        public string Nome { get; set; }
        public abstract void Preparar();
        public abstract void Assar(int tempo);
        public abstract void Embalar();
    }
}
