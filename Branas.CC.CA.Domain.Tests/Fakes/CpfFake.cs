using Branas.CC.CA.Domain.Entidades;

namespace Branas.CC.CA.Domain.Tests.Fakes
{
    public static class CpfFake
    {
        public const string CPF_VALIDO_COM_CARACTERES = "780.424.280-81";
        public const string CPF_VALIDO_COM_CARACTERES_COM_FINAL_80 = "935.411.347-80";
        public const string CPF_VALIDO_COM_CARACTERES_COM_FINAL_00 = "987.654.321-00";
        public const string CPF_VALIDO_SEM_CARACTERES = "78042428081";

        public const string CPF_INVALIDO_COM_CARACTERES = "123.456.789-00";
        public const string CPF_INVALIDO_SEQUENCIA = "123.456.789-10";
        public const string CPF_INVALIDO_TUDO_REPETIDO = "111.111.111-11";
        public const string CPF_INVALIDO_COM_MENOS_CARACTERES = "780.424.2-81";
        public const string CPF_INVALIDO_COM_MAIS_CARACTERES = "123.456.789-1000";
        public const string CPF_INVALIDO_SEM_CARACTERES = "78042428082";

        public static Cpf BuscarCpf(string cpf) => new Cpf(cpf);
    }
}
