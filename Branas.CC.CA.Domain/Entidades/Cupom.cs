using System.Text.RegularExpressions;

namespace Branas.CC.CA.Domain.Entidades
{
    public class Cupom
    {
        public string Codigo { get; private set; }
        public decimal Porcentagem { get; private set; }

        public Cupom(string CodigoCupom)
        {
            Codigo = CodigoCupom;
            BuscarPorcentagemDoCupom();
        }

        private Cupom BuscarPorcentagemDoCupom()
        {
            var digitosCupom = Regex.Replace(Codigo, "[aA-zZ]", "");
            Porcentagem = decimal.Parse(digitosCupom);

            return this;
        }
    }
}
