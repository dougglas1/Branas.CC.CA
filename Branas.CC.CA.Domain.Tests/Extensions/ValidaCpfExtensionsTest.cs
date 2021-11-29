using Branas.CC.CA.Domain.Extensions;
using FluentAssertions;
using Xunit;

namespace Branas.CC.CA.Domain.Tests.Extensions
{
    public class ValidaCpfExtensionsTest
    {
        [Theory]
        [InlineData("780.424.280-81")]
        [InlineData("78042428081")]
        public void Deve_Validar_CPF_Valido(string cpf)
        {
            var actual = cpf.ValidarCpf();
            actual.Should().BeTrue();
        }

        [Theory]
        [InlineData("123.456.789-10")]
        [InlineData("780.424.2-81")]
        public void Deve_Validar_CPF_Invalido(string cpf)
        {
            var actual = cpf.ValidarCpf();
            actual.Should().BeFalse();
        }
    }
}
