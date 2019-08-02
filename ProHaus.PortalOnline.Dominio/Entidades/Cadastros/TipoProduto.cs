using System;
using System.Collections.Generic;

namespace ProHaus.PortalOnline.Dominio.Entidades.Cadastros
{
    public class TipoProduto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataUltModif { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
