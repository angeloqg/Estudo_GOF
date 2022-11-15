using Adapter;
using Bridge;
using Composite;
using Decorator;

namespace ExecutePatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Adapter
            //ClientAdapter.ExecutPattern();

            // Bridge
            //ClientBridge.ExecutPattern();

            // Composite
            //ClientComposite.ExecutPattern();

            // Decotador
            ClientDecorator.ExecutPattern();
        }
    }
}
