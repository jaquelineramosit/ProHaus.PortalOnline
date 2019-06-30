using System;
using System.Collections.Generic;

namespace ProHaus.PortalOnline.Dominio.Entidades.Cadastros
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public int IdTipoProduto { get; set; }
        public string Codigo { get; set; }
        public string ParNumber { get; set; }
        public string Nome { get; set; }
        public decimal Custo { get; set; }
        public int IdFornecedor { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataUltModif { get; set; }
    }
}
