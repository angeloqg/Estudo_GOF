using Decorator.Component;

namespace Decorator.Decorator
{
    public class PizzaDecorator : IPizza
    {
        private readonly IPizza _pizza;

        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public virtual string Opcionais()
        {
            return _pizza.Opcionais();
        }

        public virtual decimal Preco()
        {
            return _pizza.Preco();
        }
    }
}
