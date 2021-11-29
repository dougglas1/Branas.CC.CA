namespace Branas.CC.CA.Domain.Extensions
{
    public static class ValidaCpfExtensions
    {
        public static bool ValidarCpf(this string cpf)
        {
            cpf = cpf.Trim().Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
                return false;

            string cpfAuxiliar = cpf.Substring(0, 9);
            int soma = 0;

            int[] multiplicadorPrimeiroDigito = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            CalcularDigito(ref soma, cpfAuxiliar, multiplicadorPrimeiroDigito, 9);

            int resto = CalcularRestoDaDivisao(soma);

            string digito = resto.ToString();
            cpfAuxiliar += digito;
            soma = 0;

            int[] multiplicadorSegundoDigito = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            CalcularDigito(ref soma, cpfAuxiliar, multiplicadorSegundoDigito, 10);

            resto = CalcularRestoDaDivisao(soma);

            digito += resto.ToString();

            return cpf.EndsWith(digito);
        }

        private static void CalcularDigito(ref int soma, string cpfAuxiliar, int[] multiplicadorPrimeiroDigito, int iteracao)
        {
            for (int i = 0; i < iteracao; i++)
                soma += int.Parse(cpfAuxiliar[i].ToString()) * multiplicadorPrimeiroDigito[i];
        }

        private static int CalcularRestoDaDivisao(int soma)
        {
            int resto = soma % 11;
            return resto < 2 ? 0 : 11 - resto;
        }
    }
}
