using ProHaus.PortalOnline.Dominio.Contratos.Cadastros;
using ProHaus.PortalOnline.Dominio.Entidades.Cadastros;
using ProHaus.PortalOnline.Repositorio.Contexto;

namespace ProHaus.PortalOnline.Repositorio.Repositorios.Cadastros
{
    public class TipoProdutoRepositorio : BaseRepositorio<TipoProduto>, ITipoProdutoRepositorio
    {
        public TipoProdutoRepositorio(ProHausContexto proHausContexto) : base(proHausContexto)
        {
        }
    }
}
