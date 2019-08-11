using System;

namespace ProHaus.PortalOnline.Dominio.Entidades.Cadastros
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public int TipoProdutoId { get; set; }
        public virtual TipoProduto TipoProduto { get; set; }
        public string Codigo { get; set; }
        public string ParNumber { get; set; }
        public string Nome { get; set; }
        public decimal Custo { get; set; }
        public int FornecedorId { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataUltModif { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
