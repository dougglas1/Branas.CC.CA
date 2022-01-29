using System;

namespace Branas.CC.CA.Domain.Entidades
{
    /// <summary>
    /// Item
    /// </summary>
    public class Produto
    {
        public Guid Id { get; private set; }
        public Guid CategoriaId { get; private set; }
        public string Descricao { get; private set; }
        public decimal PrecoSemImposto { get; private set; }
        public decimal Preco { get; private set; }
        public Imposto Imposto { get; private set; }
        public Dimensao Dimensao { get; private set; }
        public decimal Peso { get; private set; }
        public UnidadeMedida UnidadeMedida { get; private set; }
        
        public Produto(Guid id, Guid categoriaId, string descricao, decimal precoSemImposto, Imposto imposto, Dimensao dimensao, decimal peso, UnidadeMedida unidadeMedida)
        {
            Id = id;
            CategoriaId = categoriaId;
            Descricao = descricao;
            PrecoSemImposto = precoSemImposto;
            Imposto = imposto;
            Dimensao = dimensao;
            Peso = peso;
            UnidadeMedida = unidadeMedida;
            
            CalcularPreco();
        }
        
        public decimal CalcularVolume() => Dimensao.CalcularDimensao();

        public decimal CalcularDensidade() => Peso / Dimensao.CalcularDimensao();
        
        private void CalcularPreco() => Preco = PrecoSemImposto + Imposto.Valor;
    }
}
