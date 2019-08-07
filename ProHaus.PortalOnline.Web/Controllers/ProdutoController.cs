using Microsoft.AspNetCore.Mvc;
using ProHaus.PortalOnline.Dominio.Contratos.Cadastros;
using ProHaus.PortalOnline.Dominio.Entidades.Cadastros;
using System;

namespace ProHaus.PortalOnline.Web.Controllers
{
    [Route("api/[controller]")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        public ProdutoController(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var lista = _produtoRepositorio.ObterTodos();
                return Ok(lista);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Produto produto)
        {
            try
            {
                _produtoRepositorio.Adicionar(produto);
                return Created("api/produto", produto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
