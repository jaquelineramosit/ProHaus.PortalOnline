using System;

namespace ProHaus.PortalOnline.Dominio.Entidades
{
    public class TipoProduto
    {
        public int IdTipoProduto { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataUltModif { get; set; }
    }
}
