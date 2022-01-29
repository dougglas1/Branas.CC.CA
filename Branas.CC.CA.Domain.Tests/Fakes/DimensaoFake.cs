using Branas.CC.CA.Domain.Entidades;

namespace Branas.CC.CA.Domain.Tests.Fakes
{
    public static class DimensaoFake
    {
        public const decimal MONITOR_ALTURA = 20;
        public const decimal MONITOR_LARGURA = 15;
        public const decimal MONITOR_COMPRIMENTO = 10;
        public const decimal HEADSET_ALTURA = 100;
        public const decimal HEADSET_LARGURA = 30;
        public const decimal HEADSET_COMPRIMENTO = 10;
        public const decimal VENTOINHA_FAN_ALTURA = 200;
        public const decimal VENTOINHA_FAN_LARGURA = 100;
        public const decimal VENTOINHA_FAN_COMPRIMENTO = 50;

        public static Dimensao BuscarDimensao(decimal altura, decimal largura, decimal comprimento) 
            => new Dimensao(altura, largura, comprimento);
    }
}
