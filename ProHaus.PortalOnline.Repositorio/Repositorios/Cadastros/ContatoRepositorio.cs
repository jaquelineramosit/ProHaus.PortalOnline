using ProHaus.PortalOnline.Dominio.Contratos.Cadastros;
using ProHaus.PortalOnline.Dominio.Entidades.Cadastros;
using ProHaus.PortalOnline.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProHaus.PortalOnline.Repositorio.Repositorios.Cadastros
{
    public class ContatoRepositorio : BaseRepositorio<Contato>, IContatoRepositorio
    {
        public ContatoRepositorio(ProHausContexto proHausContexto) : base(proHausContexto)
        {
        }
    }
}
