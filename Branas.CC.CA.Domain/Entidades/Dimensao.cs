namespace Branas.CC.CA.Domain.Entidades
{
    public class Dimensao
    {
        public decimal Altura { get; private set; }
        public decimal Largura { get; private set; }
        public decimal Comprimento { get; private set; }

        public Dimensao(decimal altura, decimal largura, decimal comprimento)
        {
            Altura = altura;
            Largura = largura;
            Comprimento = comprimento;
        }

        public decimal CalcularDimensao() => (Largura / 100) * (Altura / 100) * (Comprimento / 100);
    }
}
