using System;

namespace Branas.CC.CA.Domain.Entidades
{
    public class Cupom
    {
        public string Codigo { get; private set; }
        public decimal Porcentagem { get; private set; }
        public DateTime? DataFim { get; private set; }
        public CupomStatus Status { get; private set; }
        
        public Cupom(string codigo, decimal porcentagem, DateTime? dataFim)
        {
            Codigo = codigo;
            Porcentagem = porcentagem;
            DataFim = dataFim;
        }

        public decimal CalcularDesconto(decimal valor) => ValidarDataFim() ? valor * (Porcentagem / 100) : 0;

        private bool ValidarDataFim()
        {
            var status = true;

            if (DataFim.HasValue)
                status = DataFim.Value >= DateTime.Now;

            AdicionarStatus(status);
            return status;
        }
        
        private void AdicionarStatus(bool status) => Status = status ? CupomStatus.Valido : CupomStatus.Invalido;
    }
}
