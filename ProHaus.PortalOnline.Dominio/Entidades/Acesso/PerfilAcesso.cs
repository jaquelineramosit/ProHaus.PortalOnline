using System;

namespace ProHaus.PortalOnline.Dominio.Entidades
{
    public class PerfilAcesso
    {
        public int IdPerfilAcesso { get; set; }
        public string Perfil { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataUltModif { get; set; }

    }
}
