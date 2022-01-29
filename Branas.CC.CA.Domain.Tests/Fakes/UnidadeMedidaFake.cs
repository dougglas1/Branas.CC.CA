using Branas.CC.CA.Domain.Entidades;

namespace Branas.CC.CA.Domain.Tests.Fakes
{
    public static class UnidadeMedidaFake
    {
        public const string MONITOR_SIGLA = "Kg";
        public const string HEADSET_SIGLA = "Kg";
        public const string VENTOINHA_FAN_SIGLA = "Kg";
        
        public static UnidadeMedida BuscarUnidadeMedida(string sigla) => new UnidadeMedida(sigla);
    }
}
