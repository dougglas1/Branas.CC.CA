using Branas.CC.CA.Domain.Entidades;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Branas.CC.CA.Domain.Tests.Entidades
{
    public class PedidoTest
    {
        [Fact]
        public void Nao_Deve_Fazer_Pedido_Com_CPF_Invalido()
        {
            var cpf = new Cpf("123.456.789-10");

            var expected = new Pedido(cpf).AdicionarStatus();
            
            var pedido = new Pedido(cpf);
            
            pedido.Should().BeEquivalentTo(expected);
        }
        
        [Fact]
        public void Deve_Fazer_Pedido_Com_Tres_Itens()
        {
            var cpf = new Cpf("780.424.280-81");

            var pedido = new Pedido(cpf)
                .AdicionarItens(BuscarItens());
            
            pedido.Itens.Count().Should().Be(3);
        }

        [Fact]
        public void Deve_Fazer_Pedido_Com_Cupom_Desconto()
        {
            var cpf = new Cpf("780.424.280-81");

            var cupom = new Cupom("Now10");

            var pedido = new Pedido(cpf)
                .AdicionarItens(BuscarItens())
                .AdicionarCupom(cupom);
            
            var subtotal = pedido.Itens.Sum(item => item.Preco);
            var total = subtotal - (subtotal * (cupom.Porcentagem / 100));
            
            pedido.ValorSubTotal.Should().Be(subtotal);
            pedido.ValorTotal.Should().Be(total);
        }

        private List<Item> BuscarItens()
        {
            return new List<Item>()
            {
                new Item("Monitor Gamer Aoc 0.5MS 240HZ", 1199.99M, 1, new Imposto(799.996M)),
                new Item("Headset Gamer JBL 400", 211.99M, 1, new Imposto(187.953M)),
                new Item("Ventoinha Fan 140MM", 27.06M, 4, new Imposto(9.02M))
            };
        }
    }
}
