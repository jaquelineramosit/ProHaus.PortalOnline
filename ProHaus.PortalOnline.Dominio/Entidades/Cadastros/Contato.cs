using System;
using System.Collections.Generic;
using System.Text;

namespace ProHaus.PortalOnline.Dominio.Entidades.Cadastros
{
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataUltModif { get; set; }

    }
}
