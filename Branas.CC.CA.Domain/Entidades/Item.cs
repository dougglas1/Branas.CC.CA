
namespace Branas.CC.CA.Domain.Entidades
{
    public class Item
    {
        public string Descricao { get; private set; }
        public decimal PrecoSemImposto { get; private set; }
        public decimal Preco { get; private set; }
        public int Quantidade { get; private set; }
        public Imposto Imposto { get; private set; }

        public Item(string descricao, decimal precoSemImposto, int quantidade, Imposto imposto)
        {
            Descricao = descricao;
            PrecoSemImposto = precoSemImposto;
            Quantidade = quantidade;
            Imposto = imposto;
            CalcularPreco();
        }
        
        private void CalcularPreco()
        {
            Preco = PrecoSemImposto + Imposto.Valor;
        }
    }
}
