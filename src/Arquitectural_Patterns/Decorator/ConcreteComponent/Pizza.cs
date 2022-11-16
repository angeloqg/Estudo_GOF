using Decorator.Component;

namespace Decorator.ConcreteComponent
{
    public class Pizza : IPizza
    {
        public string Opcionais()
        {
            return "Pizza padrão ou normal";
        }

        public decimal Preco()
        {
            return 10.00M;
        }
    }
}
