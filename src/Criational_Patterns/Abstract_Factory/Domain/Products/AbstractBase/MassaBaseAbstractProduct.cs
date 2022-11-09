using Abstract_Factory.Domain.Enums;
using System.Collections;

namespace Abstract_Factory.Domain.Products.AbstractBase
{
    public abstract class MassaBaseAbstractProduct
    {
        public ETipoMassa TipoMassa { get; set; }
        public string Nome { get; set; }

        public ArrayList Ingredientes = new ArrayList();

        public MassaBaseAbstractProduct(string nome, ETipoMassa tipoMassa)
        {
            Nome = nome;
            TipoMassa = tipoMassa;
        }
    }
}
