using System;

namespace Branas.CC.CA.Domain.Entidades
{
    public class Categoria
    {
        public Guid Id { get; private set; }
        public string Descricao { get; private set; }

        public Categoria(Guid id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }
    }
}
