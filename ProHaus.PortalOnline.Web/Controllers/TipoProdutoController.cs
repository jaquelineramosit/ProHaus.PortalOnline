using Microsoft.AspNetCore.Mvc;
using ProHaus.PortalOnline.Dominio.Contratos.Cadastros;
using ProHaus.PortalOnline.Dominio.Entidades.Cadastros;

namespace ProHaus.PortalOnline.Web.Controllers
{
    [Route("api/[controller]")]
    public class TipoProdutoController : Controller
    {
        private readonly ITipoProdutoRepositorio _tipoProdutoRepositorio;
        public TipoProdutoController(ITipoProdutoRepositorio tipoProdutoRepositorio)
        {
            _tipoProdutoRepositorio = tipoProdutoRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_tipoProdutoRepositorio.ObterTodos());
            }
            catch (System.Exception ex)
            {

                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] TipoProduto tipoProduto)
        {
            try
            {
                _tipoProdutoRepositorio.Adicionar(tipoProduto);
                return Created("api/TipoProduto", tipoProduto);
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }
    }
}
