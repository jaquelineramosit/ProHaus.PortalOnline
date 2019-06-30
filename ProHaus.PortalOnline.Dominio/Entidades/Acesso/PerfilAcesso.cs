using System;

namespace ProHaus.PortalOnline.Dominio.Entidades
{
    public class PerfilAcesso : Entidade
    {
        public int IdPerfilAcesso { get; set; }
        public string Perfil { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataUltModif { get; set; }

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
