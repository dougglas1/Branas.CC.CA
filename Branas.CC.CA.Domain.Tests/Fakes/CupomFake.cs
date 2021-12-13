using Branas.CC.CA.Domain.Entidades;
using System;

namespace Branas.CC.CA.Domain.Tests.Fakes
{
    public static class CupomFake
    {
        public static DateTime DataFimValida = DateTime.Now.AddDays(1);
        public static DateTime DataFimInvalida = DateTime.Now.AddDays(-1);
        
        public const string CODIGO_NOW_10 = "Now10";
        public const decimal PORCENTAGEM_10 = 10;
        
        public static Cupom BuscarCupom(string codigo, decimal porcentagem, DateTime? dataFim) => new Cupom(codigo, porcentagem, dataFim);
    }
}
