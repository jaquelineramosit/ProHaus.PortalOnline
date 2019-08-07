using Microsoft.AspNetCore.Mvc;
using ProHaus.PortalOnline.Dominio.Contratos.Cadastros;

using ProHaus.PortalOnline.Dominio.Entidades.Cadastros;
using ProHaus.PortalOnline.Repositorio.Contexto;
using System.Runtime.InteropServices;

namespace ProHaus.PortalOnline.Repositorio.Repositorios.Cadastros
{
    
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(ProHausContexto proHausContexto) : base(proHausContexto)
        {
        }
    }
}
