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
            yield return BuscarItem(ProdutoFake.MonitorId, MONITOR_PRECO, QUANTIDADE_1)
                .AdicionarProduto(ProdutoFake.BuscarProduto(
                    ProdutoFake.MonitorId, CategoriaFake.MonitorId, ProdutoFake.MONITOR_DESCRICAO,
                    ProdutoFake.MONITOR_PRECO, ImpostoFake.BuscarImposto(ImpostoFake.MONITOR_VALOR),
                    DimensaoFake.BuscarDimensao(DimensaoFake.MONITOR_ALTURA, DimensaoFake.MONITOR_LARGURA, DimensaoFake.MONITOR_COMPRIMENTO),
                    ProdutoFake.MONITOR_PESO, UnidadeMedidaFake.BuscarUnidadeMedida(UnidadeMedidaFake.MONITOR_SIGLA)));

            yield return BuscarItem(ProdutoFake.HeadsetId, HEADSET_PRECO, QUANTIDADE_1)
                .AdicionarProduto(ProdutoFake.BuscarProduto(
                    ProdutoFake.HeadsetId, CategoriaFake.HeadsetId, ProdutoFake.HEADSET_DESCRICAO,
                    ProdutoFake.HEADSET_PRECO, ImpostoFake.BuscarImposto(ImpostoFake.HEADSET_VALOR),
                    DimensaoFake.BuscarDimensao(DimensaoFake.HEADSET_ALTURA, DimensaoFake.HEADSET_LARGURA, DimensaoFake.HEADSET_COMPRIMENTO),
                    ProdutoFake.HEADSET_PESO, UnidadeMedidaFake.BuscarUnidadeMedida(UnidadeMedidaFake.HEADSET_SIGLA)));

            yield return BuscarItem(ProdutoFake.VentoinhaFanId, VENTOINHA_FAN_PRECO, QUANTIDADE_4)
                .AdicionarProduto(ProdutoFake.BuscarProduto(
                    ProdutoFake.VentoinhaFanId, CategoriaFake.VentoinhaFanId, ProdutoFake.VENTOINHA_FAN_DESCRICAO,
                    ProdutoFake.VENTOINHA_FAN_PRECO, ImpostoFake.BuscarImposto(ImpostoFake.VENTOINHA_VALOR),
                    DimensaoFake.BuscarDimensao(DimensaoFake.VENTOINHA_FAN_ALTURA, DimensaoFake.VENTOINHA_FAN_LARGURA, DimensaoFake.VENTOINHA_FAN_COMPRIMENTO),
                    ProdutoFake.VENTOINHA_FAN_PESO, UnidadeMedidaFake.BuscarUnidadeMedida(UnidadeMedidaFake.VENTOINHA_FAN_SIGLA)));

        }

        private static PedidoItem BuscarItem(Guid produtoId, decimal preco, int quantidade) =>
            new PedidoItem(produtoId, preco, quantidade);
    }
}
