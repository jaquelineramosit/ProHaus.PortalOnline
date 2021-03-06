﻿using System;
using System.Collections.Generic;

namespace ProHaus.PortalOnline.Dominio.Entidades.Acesso
{
    public class AcessoPagina : Entidade
    {

        public int Id { get; set; }
        public int PerfilAcessoId { get; set; }
        public virtual PerfilAcesso PerfilAcesso { get; set; }
        public string NomePagina { get; set; }
        public string SubPagina { get; set; }
        public string Funcao { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataUltModif { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
