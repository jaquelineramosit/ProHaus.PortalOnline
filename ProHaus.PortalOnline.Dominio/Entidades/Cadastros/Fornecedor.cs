using System;

namespace ProHaus.PortalOnline.Dominio.Entidades
{
    public class Fornecedor : Entidade
    {
        public int IdFornecedor { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        public string Skype { get; set; }
        public string CNPJ { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataUltModif { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
