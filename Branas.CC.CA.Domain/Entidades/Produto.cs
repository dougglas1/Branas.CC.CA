using System;

namespace Branas.CC.CA.Domain.Entidades
{
    /// <summary>
    /// Item
    /// </summary>
    public class Produto
    {
        public Guid Id { get; private set; }
        public string Descricao { get; private set; }
        public decimal PrecoSemImposto { get; private set; }
        public decimal Preco { get; private set; }
        public Imposto Imposto { get; private set; }

        public Produto(Guid id, string descricao, decimal precoSemImposto, Imposto imposto)
        {
            Id = id;
            Descricao = descricao;
            PrecoSemImposto = precoSemImposto;
            Imposto = imposto;
            CalcularPreco();
        }
        
        private void CalcularPreco()
        {
            Preco = PrecoSemImposto + Imposto.Valor;
        }
    }
}
