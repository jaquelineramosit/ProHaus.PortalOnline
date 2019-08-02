using System;
using System.Collections.Generic;

namespace ProHaus.PortalOnline.Dominio.Entidades.Cadastros
{
    public class Fornecedor : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        public string Skype { get; set; }
        public string CNPJ { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataUltModif { get; set; }
        public virtual ICollection<Fornecedor> Fornecedores { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
