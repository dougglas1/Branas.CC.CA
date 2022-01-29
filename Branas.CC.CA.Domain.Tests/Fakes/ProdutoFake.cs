using Branas.CC.CA.Domain.Entidades;
using System;

namespace Branas.CC.CA.Domain.Tests.Fakes
{
    public static class ProdutoFake
    {
        public static Guid MonitorId = Guid.Parse("b31c222b-66ae-497e-85f2-bf44cec8e37c");
        public static Guid HeadsetId = Guid.Parse("8e4b345a-f939-49b3-b571-24d07cd93f08");
        public static Guid VentoinhaFanId = Guid.Parse("21bb39fe-9ca7-46a0-85da-8c51e565537f");
        
        public const string MONITOR_DESCRICAO = "Monitor Gamer Aoc 0.5MS 240HZ";
        public const string HEADSET_DESCRICAO = "Headset Gamer JBL 400";
        public const string VENTOINHA_FAN_DESCRICAO = "Ventoinha Fan 140MM";

        public const decimal MONITOR_PRECO = 1199.99M;
        public const decimal HEADSET_PRECO = 211.99M;
        public const decimal VENTOINHA_FAN_PRECO = 27.06M;

        public const decimal MONITOR_PESO = 10;
        public const decimal HEADSET_PESO = 3;
        public const decimal VENTOINHA_FAN_PESO = 1;

        public static Produto BuscarProduto(
            Guid id, Guid categoriaId, string descricao, decimal preco, 
            Imposto imposto, Dimensao dimensao, decimal peso, UnidadeMedida unidadeMedida) => 
            new Produto(id, categoriaId, descricao, preco, imposto, dimensao, peso, unidadeMedida);
    }
}
