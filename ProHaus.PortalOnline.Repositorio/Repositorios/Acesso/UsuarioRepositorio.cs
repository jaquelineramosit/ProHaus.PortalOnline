using ProHaus.PortalOnline.Dominio.Contratos;
using ProHaus.PortalOnline.Dominio.Contratos.Acesso;
using ProHaus.PortalOnline.Dominio.Entidades;
using ProHaus.PortalOnline.Dominio.Entidades.Acesso;
using ProHaus.PortalOnline.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProHaus.PortalOnline.Repositorio.Repositorios.Acesso
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(ProHausContexto proHausContexto) : base(proHausContexto)
        {
        }
    }
}
