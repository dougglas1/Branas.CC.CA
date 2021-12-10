using Branas.CC.CA.Domain.Entidades;

namespace Branas.CC.CA.Domain.Tests.Fakes
{
    public static class ImpostoFake
    {
        public const decimal MONITOR_VALOR = 1199.99M;
        public const decimal HEADSET_VALOR = 211.99M;
        public const decimal VENTOINHA_VALOR = 27.06M;
        
        public static Imposto BuscarImposto(decimal valor) => new Imposto(valor);
    }
}
