using System;

namespace ProHaus.PortalOnline.Dominio.Entidades.Acesso
{
    public class Usuario : Entidade
    {
        public int IdUsuario { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        public int IdUnidade { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int IdPerfilAcesso { get; set; }
        public DateTime DataUltModif { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
