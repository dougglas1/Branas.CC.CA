using Branas.CC.CA.Domain.Entidades;
using System.Collections.Generic;

namespace Branas.CC.CA.Domain.Tests.Fakes
{
    public static class PedidoFake
    {
        public static Pedido BuscarPedidoComCpf(Cpf cpf) => new Pedido(cpf);

        public static Pedido BuscarPedidoComItens(Cpf cpf, List<PedidoItem> itens)
        {
            var pedido = new Pedido(cpf);
            pedido.AdicionarItensNoPedido(itens);
            
            return pedido;
        }
        
        public static Pedido BuscarPedidoComItensECupom(Cpf cpf, List<PedidoItem> itens, Cupom cupom)
        {
            var pedido = new Pedido(cpf).AdicionarCupom(cupom);
            pedido.AdicionarItensNoPedido(itens);

            return pedido;
        }
        
        private static void AdicionarItensNoPedido(this Pedido pedido, List<PedidoItem> itens) => 
            itens.ForEach(item => pedido.AdicionarItem(item));
    }
}
