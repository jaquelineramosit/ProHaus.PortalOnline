using System;
using System.Collections.Generic;

namespace ProHaus.PortalOnline.Dominio.Entidades
{
    public class Unidade : Entidade
    {
        public int IdUnidade { get; set; }
        public string Nome { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataUltModif { get; set; }
        public ICollection<Usuario> Usuarios { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
