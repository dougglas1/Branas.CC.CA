using Branas.CC.CA.Domain.Entidades;
using Branas.CC.CA.Domain.Tests.Fakes;
using FluentAssertions;
using System.Linq;
using Xunit;

namespace Branas.CC.CA.Domain.Tests.Entidades
{
    public class PedidoTest
    {
        [Fact]
        public void Nao_Deve_Fazer_Pedido_Com_CPF_Invalido()
        {
            var cpf = CpfFake.BuscarCpf(CpfFake.CPF_INVALIDO_COM_CARACTERES);            
            var pedido = PedidoFake.BuscarPedidoComCpf(cpf);
            
            pedido.Cpf.Numero.Should().Be(CpfFake.CPF_INVALIDO_COM_CARACTERES);
            pedido.Status.Should().Be(PedidoStatus.Cancelado);
        }
        
        [Fact]
        public void Deve_Fazer_Pedido_Com_Tres_Itens()
        {
            var cpf = CpfFake.BuscarCpf(CpfFake.CPF_VALIDO_COM_CARACTERES);
            var itens = PedidoItemFake.BuscarItens().ToList();
            var pedido = PedidoFake.BuscarPedidoComItens(cpf, itens);
            
            pedido.Itens.Count().Should().Be(3);
        }
        
        [Fact]
        public void Deve_Fazer_Pedido_Com_Cupom_Desconto_Valido()
        {
            var cpf = CpfFake.BuscarCpf(CpfFake.CPF_VALIDO_COM_CARACTERES);
            var cupom = CupomFake.BuscarCupom(CupomFake.CODIGO_NOW_10, CupomFake.PORCENTAGEM_10, CupomFake.DataFimValida);
            var itens = PedidoItemFake.BuscarItens().ToList();
            var pedido = PedidoFake.BuscarPedidoComItensECupom(cpf, itens, cupom);

            pedido.Cupom.Status.Should().Be(CupomStatus.Valido);
            pedido.ValorSubTotal.Should().Be(1520.22M);
            pedido.ValorTotal.Should().Be(1538.198M);
        }
        
        [Fact]
        public void Deve_Fazer_Pedido_Com_Cupom_Desconto_Expirado()
        {
            var cpf = CpfFake.BuscarCpf(CpfFake.CPF_VALIDO_COM_CARACTERES);
            var cupom = CupomFake.BuscarCupom(CupomFake.CODIGO_NOW_10, CupomFake.PORCENTAGEM_10, CupomFake.DataFimInvalida);
            var itens = PedidoItemFake.BuscarItens().ToList();
            var pedido = PedidoFake.BuscarPedidoComItensECupom(cpf, itens, cupom);
            
            pedido.Cupom.Status.Should().Be(CupomStatus.Invalido);
            pedido.ValorSubTotal.Should().Be(1520.22M);
            pedido.ValorTotal.Should().Be(1690.22M);
        }
    }
}
