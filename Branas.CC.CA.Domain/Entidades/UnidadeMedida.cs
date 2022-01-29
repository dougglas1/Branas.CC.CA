namespace Branas.CC.CA.Domain.Entidades
{
    public class UnidadeMedida
    {
        public string Sigla { get; private set; }

        public UnidadeMedida(string sigla)
        {
            Sigla = sigla;
        }
    }
}
