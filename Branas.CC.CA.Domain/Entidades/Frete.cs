
namespace Branas.CC.CA.Domain.Entidades
{
    public class Frete
    {
        public decimal Valor { get; private set; }

        public Frete(decimal valor)
        {
            Valor = valor;
        }
    }
}
