namespace Branas.CC.CA.Domain.Extensions
{
    public static class ValidaCpfExtensions
    {
        public static bool ValidarCpf(this string cpf)
        {
            cpf = cpf.Trim().Replace(".", "").Replace("-", "");

            if (cpf.Length != 11 || ValidarDigitosRepetidos(cpf))
                return false;

            string cpfAuxiliar = cpf.Substring(0, 9);

            int[] multiplicadorPrimeiroDigito = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            int resto = CalcularDigito(cpfAuxiliar, multiplicadorPrimeiroDigito);

            string digito = resto.ToString();
            cpfAuxiliar += digito;

            int[] multiplicadorSegundoDigito = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            resto = CalcularDigito(cpfAuxiliar, multiplicadorSegundoDigito);
            
            digito += resto.ToString();

            return cpf.EndsWith(digito);
        }

        private static int CalcularDigito(string cpfAuxiliar, int[] multiplicadorPrimeiroDigito)
        {
            var soma = 0;

            for (int digito = 0; digito < multiplicadorPrimeiroDigito.Length; digito++)
                soma += int.Parse(cpfAuxiliar[digito].ToString()) * multiplicadorPrimeiroDigito[digito];

            int resto = soma % 11;
            return resto < 2 ? 0 : 11 - resto;
        }
        
        private static bool ValidarDigitosRepetidos(string cpf)
        {
            for (int digito = 0; digito < 10; digito++)
                if (digito.ToString().PadLeft(11, char.Parse(digito.ToString())) == cpf)
                    return true;

            return false;
        }
    }
}
