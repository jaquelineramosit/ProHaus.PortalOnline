using System;
using System.Collections.Generic;

namespace ProHaus.PortalOnline.Dominio.Entidades
{
    public class AcessoPagina
    {

        public int IdAcessoPagina { get; set; }
        public int IdPerfilAcesso { get; set; }
        public string NomePagina { get; set; }
        public string SubPagina { get; set; }
        public string Funcao { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataUltModif { get; set; }
    }
}
