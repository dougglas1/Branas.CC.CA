
namespace Branas.CC.CA.Domain.Entidades
{
    public class Cpf
    {
        public string Numero { get; private set; }

        public Cpf(string numeroCpf)
        {
            Numero = numeroCpf;
        }
    }
}
