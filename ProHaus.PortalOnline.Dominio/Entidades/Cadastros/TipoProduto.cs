using System;

namespace ProHaus.PortalOnline.Dominio.Entidades
{
    public class TipoProduto : Entidade
    {
        public int IdTipoProduto { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataUltModif { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
