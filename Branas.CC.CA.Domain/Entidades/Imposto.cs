
namespace Branas.CC.CA.Domain.Entidades
{
    public class Imposto
    {
        public decimal Valor { get; private set; }

        public Imposto(decimal valor)
        {
            Valor = valor;
        }
    }
}
