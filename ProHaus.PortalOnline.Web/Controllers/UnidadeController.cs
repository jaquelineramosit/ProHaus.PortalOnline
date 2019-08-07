using Microsoft.AspNetCore.Mvc;
using ProHaus.PortalOnline.Dominio.Contratos.Acesso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProHaus.PortalOnline.Web.Controllers
{
    [Route("api/[controller]")]
    public class UnidadeController : Controller
    {
        private readonly IUnidadeRepositorio _unidadeRepositorio;

        public UnidadeController(IUnidadeRepositorio unidadeRepositorio)
        {
            _unidadeRepositorio = unidadeRepositorio;
        }
    }
}
