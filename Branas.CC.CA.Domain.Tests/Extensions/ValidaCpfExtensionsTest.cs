using Branas.CC.CA.Domain.Extensions;
using Branas.CC.CA.Domain.Tests.Fakes;
using FluentAssertions;
using Xunit;

namespace Branas.CC.CA.Domain.Tests.Extensions
{
    public class ValidaCpfExtensionsTest
    {
        [Theory]
        [InlineData(CpfFake.CPF_VALIDO_COM_CARACTERES)]
        [InlineData(CpfFake.CPF_VALIDO_COM_CARACTERES_COM_FINAL_80)]
        [InlineData(CpfFake.CPF_VALIDO_COM_CARACTERES_COM_FINAL_00)]
        [InlineData(CpfFake.CPF_VALIDO_SEM_CARACTERES)]
        public void Deve_Validar_CPF_Valido(string cpf)
        {
            var actual = cpf.ValidarCpf();
            actual.Should().BeTrue();
        }
        
        [Theory]
        [InlineData(CpfFake.CPF_INVALIDO_COM_CARACTERES)]
        [InlineData(CpfFake.CPF_INVALIDO_SEQUENCIA)]
        [InlineData(CpfFake.CPF_INVALIDO_TUDO_REPETIDO)]
        [InlineData(CpfFake.CPF_INVALIDO_COM_MENOS_CARACTERES)]
        [InlineData(CpfFake.CPF_INVALIDO_COM_MAIS_CARACTERES)]
        [InlineData(CpfFake.CPF_INVALIDO_SEM_CARACTERES)]
        public void Deve_Validar_CPF_Invalido(string cpf)
        {
            var actual = cpf.ValidarCpf();
            actual.Should().BeFalse();
        }
    }
}
