using System;

namespace Branas.CC.CA.Domain.Entidades
{
    /// <summary>
    /// OrderItem
    /// </summary>
    public class PedidoItem
    {
        private const decimal FRETE_MINIMO = 10;

        public Guid ProdutoId { get; private set; }
        public virtual Produto Produto { get; private set; }
        public decimal Preco { get; private set; }
        public int Quantidade { get; private set; }
        
        public PedidoItem(Guid produtoId, decimal preco, int quantidade)
        {
            ProdutoId = produtoId;
            Preco = preco;
            Quantidade = quantidade;
        }

        public PedidoItem AdicionarProduto(Produto produto)
        {
            Produto = produto;
            return this;
        }

        public decimal CalcularTotal() => Preco * Quantidade;
        
        public decimal CalcularFrete()
        {
            var frete = (1000 * Produto.CalcularVolume() * (Produto.CalcularDensidade() / 100));
            return Math.Max(FRETE_MINIMO, frete) * Quantidade;
        }
    }
}
