using System;
using System.Collections.Generic;

namespace ProHaus.PortalOnline.Dominio.Entidades.Acesso
{
    public class PerfilAcesso : Entidade
    {
        public int Id { get; set; }
        public string Perfil { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataUltModif { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
        public virtual ICollection<AcessoPagina> AcessoPagina { get; set; }

        /// <summary>
        /// Regras que eu quero implementar para esta classe
        /// </summary>
        public override void Validate()
        {
            if (string.IsNullOrEmpty(Perfil))
                AdicionarCritica("Crítica: O campo 'Perfil' é de preenchimento obrigatório");
            if (string.IsNullOrEmpty(Descricao))
                AdicionarCritica("Crítica: O campo 'Descricao' é de preenchimento obrigatório");
        }
    }
}
