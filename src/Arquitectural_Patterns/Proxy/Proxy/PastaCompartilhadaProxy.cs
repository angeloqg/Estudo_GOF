using Proxy.Common;
using Proxy.RealSubject;
using Proxy.Subject;
using System;

namespace Proxy.Proxy
{
    // Contém uma referência à classe RealSubject e pode acessar
    // os menbros da classe RealSubject conforme necessário
    public class PastaCompartilhadaProxy : IPastaCompartilhada
    {
        private IPastaCompartilhada _pasta;
        private Funcionario _funcionario;

        public PastaCompartilhadaProxy(Funcionario funcionario)
        {
            _funcionario = funcionario;
        }

        public void OperacaoDeLeituraGravacao()
        {
            if(_funcionario.Perfil.ToUpper() == "CEO")
            {
                _pasta = new PastaCompartilhada();
                Console.WriteLine("O proxy 'Pasta Compartilhada invoca a pasta Real" +
                    " : 'método usado : OperacaoDeLeituraGravacao()\n");
                _pasta.OperacaoDeLeituraGravacao();
            }
            else
            {
                Console.WriteLine("O proxy 'Pasta Compartilhada' avisa : " +
                    "'Você não tem permissão para acessar essa pasta'\n");
            }
        }
    }
}
