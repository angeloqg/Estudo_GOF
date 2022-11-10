using Bridge.Domain;
using Bridge.Implementor;

namespace Bridge.Abstraction
{
    public abstract class AbstractionGeraArquivo
    {
        protected IGeraArquivoBridge _geraArquivo;

        protected AbstractionGeraArquivo(IGeraArquivoBridge geraArquivo)
        {
            _geraArquivo = geraArquivo;
        }

        public virtual void GeraArquivo(Funcionario funcionario)
        {
            _geraArquivo.GravaArquivo(funcionario);
        }
    }
}
