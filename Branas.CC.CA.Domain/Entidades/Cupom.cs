namespace Branas.CC.CA.Domain.Entidades
{
    public class Cupom
    {
        public string Codigo { get; private set; }
        public decimal Porcentagem { get; private set; }

        public Cupom(string codigo, decimal porcentagem)
        {
            Codigo = codigo;
            Porcentagem = porcentagem;
        }
    }
}
