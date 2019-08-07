using ProHaus.PortalOnline.Dominio.Contratos.Acesso;
using ProHaus.PortalOnline.Dominio.Entidades;
using ProHaus.PortalOnline.Dominio.Entidades.Acesso;
using ProHaus.PortalOnline.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProHaus.PortalOnline.Repositorio.Repositorios.Acesso
{
    public class AcessoPaginaRepositorio : BaseRepositorio<AcessoPagina>, IAcessoPaginaRepositorio
    {
        public AcessoPaginaRepositorio(ProHausContexto proHausContexto) : base(proHausContexto)
        {
        }
    }
}
