using System;

namespace Branas.CC.CA.Domain.Entidades
{
    /// <summary>
    /// OrderItem
    /// </summary>
    public class PedidoItem
    {
        public Guid ProdutoId { get; private set; }
        public decimal Preco { get; private set; }
        public int Quantidade { get; private set; }
        
        public PedidoItem(Guid produtoId, decimal preco, int quantidade)
        {
            ProdutoId = produtoId;
            Preco = preco;
            Quantidade = quantidade;
        }
    }
}
