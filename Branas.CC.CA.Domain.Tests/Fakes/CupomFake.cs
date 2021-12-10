using Branas.CC.CA.Domain.Entidades;

namespace Branas.CC.CA.Domain.Tests.Fakes
{
    public static class CupomFake
    {
        public const string CODIGO_NOW_10 = "Now10";
        public const decimal PORCENTAGEM_10 = 10;
        
        public static Cupom BuscarCupom(string codigo, decimal porcentagem) => new Cupom(codigo, porcentagem);
    }
}
