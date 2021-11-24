using Branas.CC.CA.Application.CalculoTaxi;
using System;
using Xunit;
using FluentAssertions;

namespace Branas.CC.CA.Application.Tests.CalculoTaxi
{
    public class CalculoCorridaTaxiTest
    {
        private static DateTime DATA_NORMAL = new DateTime(2021, 11, 22, 10, 00, 00);
        private static DateTime DATA_DOMINGO = new DateTime(2021, 11, 21, 10, 00, 00);
        private static DateTime DATA_NOITE = new DateTime(2021, 11, 21, 23, 00, 00);
        
        private const decimal DISTANCIA = 1000;
        private const decimal DISTANCIA_NEGATIVA = -1000;

        private const string MENSAGEM_ERRO_DISTANCIA_NEGATIVA = "Distância não pode ser negativa.";

        [Fact]
        public void Deve_Calcular_Valor_Corrida_Taxi_Dias_Normais()
        {
            var actual = new CalculoCorridaTaxiDepois().CalcularCorridaTaxi(DISTANCIA, DATA_NORMAL);

            actual.Should().Be(2100);
        }

        [Fact]
        public void Deve_Calcular_Valor_Corrida_Taxi_Nos_Domingos()
        {
            var actual = new CalculoCorridaTaxiDepois().CalcularCorridaTaxi(DISTANCIA, DATA_DOMINGO);

            actual.Should().Be(2900);
        }

        [Fact]
        public void Deve_Calcular_Valor_Corrida_Taxi_De_Noite()
        {
            var actual = new CalculoCorridaTaxiDepois().CalcularCorridaTaxi(DISTANCIA, DATA_NOITE);

            actual.Should().Be(3900);
        }

        [Fact]
        public void Deve_Calcular_Valor_Corrida_Taxi_Com_Distancia_Negativa()
        {
            Action action = () => new CalculoCorridaTaxiDepois().CalcularCorridaTaxi(DISTANCIA_NEGATIVA, DATA_NORMAL);

            action.Should().Throw<Exception>().WithMessage(MENSAGEM_ERRO_DISTANCIA_NEGATIVA);
        }
    }
}
