using Branas.CC.CA.Domain.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Branas.CC.CA.Domain.Entidades
{
    /// <summary>
    /// Order
    /// </summary>
    public class Pedido
    {
        public decimal ValorSubTotal { get; private set; }
        public decimal ValorTotal { get; private set; }
        public IEnumerable<PedidoItem> Itens => _itens;
        public Cpf Cpf { get; private set; }
        public Cupom Cupom { get; private set; }
        public Frete Frete { get; private set; }
        public PedidoStatus Status { get; private set; }

        private List<PedidoItem> _itens;

        public Pedido(Cpf cpf)
        {
            _itens = new List<PedidoItem>();
            Cpf = cpf;
            AdicionarStatus();
        }

        public Pedido AdicionarStatus()
        {
            Status = Cpf.Numero.ValidarCpf() ? PedidoStatus.Realizado : PedidoStatus.Cancelado;

            return this;
        }
        
        public Pedido AdicionarItem(PedidoItem item)
        {
            _itens.Add(item);
            CalcularValorSubTotal();

            return this;
        }

        public Pedido AdicionarCupom(Cupom cupom)
        {            
            Cupom = cupom;
            CalcularValorTotal();

            return this;
        }
        
        public Pedido AdicionarFrete(Frete frete)
        {
            Frete = frete;
            CalcularValorTotal();

            return this;
        }
        
        private void CalcularValorSubTotal()
        {
            ValorSubTotal = _itens.Sum(item => item.CalcularTotal());
            CalcularValorTotal();
        }
        
        private void CalcularValorTotal()
        {
            var descontoCupom = Cupom != null ? Cupom.CalcularDesconto(ValorSubTotal) : 0;
            var descontoFrete = Frete != null ? Frete.Valor : 0;
            
            ValorTotal = ValorSubTotal - descontoCupom - descontoFrete;
        }
    }
}
