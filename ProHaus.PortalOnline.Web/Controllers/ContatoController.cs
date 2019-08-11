using Microsoft.AspNetCore.Mvc;
using ProHaus.PortalOnline.Dominio.Contratos.Cadastros;
using ProHaus.PortalOnline.Dominio.Entidades.Cadastros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProHaus.PortalOnline.Web.Controllers
{
    [Route("api/[controller]")]
    public class ContatoController : Controller
    {
        private readonly IContatoRepositorio _contatorepositorio;
        public ContatoController(IContatoRepositorio contatoRepositorio)
        {
            _contatorepositorio = contatoRepositorio;
        }


        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var lista = _contatorepositorio.ObterTodos();
                return Ok(lista);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Contato contato)
        {
            try
            {
                _contatorepositorio.Adicionar(contato);
                return Created("api/contato", contato);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
