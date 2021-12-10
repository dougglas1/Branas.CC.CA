using Branas.CC.CA.Domain.Entidades;
using System;
using System.Collections.Generic;

namespace Branas.CC.CA.Domain.Tests.Fakes
{
    public static class PedidoItemFake
    {
        public const decimal MONITOR_PRECO = 1199.99M;
        public const decimal HEADSET_PRECO = 211.99M;
        public const decimal VENTOINHA_FAN_PRECO = 27.06M;
        
        public const int QUANTIDADE_1 = 1;
        public const int QUANTIDADE_4 = 4;
        
        public static IEnumerable<PedidoItem> BuscarItens()
        {
            yield return BuscarItem(ProdutoFake.MonitorId, MONITOR_PRECO, QUANTIDADE_1);
            yield return BuscarItem(ProdutoFake.HeadsetId, HEADSET_PRECO, QUANTIDADE_1);
            yield return BuscarItem(ProdutoFake.VentoinhaFanId, VENTOINHA_FAN_PRECO, QUANTIDADE_4);
        }
        
        private static PedidoItem BuscarItem(Guid produtoId, decimal preco, int quantidade) =>
            new PedidoItem(produtoId, preco, quantidade);
    }
}
