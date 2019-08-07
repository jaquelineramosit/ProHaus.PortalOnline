using ProHaus.PortalOnline.Dominio.Contratos.Acesso;
using ProHaus.PortalOnline.Dominio.Entidades;
using ProHaus.PortalOnline.Dominio.Entidades.Acesso;
using ProHaus.PortalOnline.Repositorio.Contexto;

namespace ProHaus.PortalOnline.Repositorio.Repositorios.Acesso
{
    public class UnidadeRepositorio : BaseRepositorio<Unidade>, IUnidadeRepositorio
    {
        public UnidadeRepositorio(ProHausContexto proHausContexto) : base(proHausContexto)

        {
        }
    }
}
