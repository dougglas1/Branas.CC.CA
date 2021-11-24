using System;

namespace Branas.CC.CA.Application.CalculoTaxi
{
    public class CalculoCorridaTaxiDepois
    {
        private const decimal VALOR_NOITE = 3.90M;
        private const decimal VALOR_DOMINGO = 2.90M;
        private const decimal VALOR_NORMAL = 2.10M;

        public decimal CalcularCorridaTaxi(decimal distancia, DateTime data)
        {
            if (distancia < 0)
                throw new Exception("Distância não pode ser negativa.");

            if (ValidarSeNoite(data))
                return distancia * VALOR_NOITE;

            if (ValidarSeDomingo(data))
                return distancia * VALOR_DOMINGO;

            return distancia * VALOR_NORMAL;
        }

        private bool ValidarSeNoite(DateTime data) => data.Hour >= 22;

        private bool ValidarSeDomingo(DateTime data) => data.DayOfWeek == 0;
    }
}
