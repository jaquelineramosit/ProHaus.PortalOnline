using System;

namespace ProHaus.PortalOnline.Dominio.Entidades.Acesso
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        public int UnidadeId { get; set; }
        public virtual Unidade Unidade { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int PerfilAcessoId { get; set; }
        public virtual PerfilAcesso PerfilAcesso { get; set; }
        public DateTime DataUltModif { get; set; }

        

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
