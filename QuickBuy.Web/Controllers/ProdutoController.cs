using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuickBuy.Dominio.Contratos;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Web.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepositorio produtoRepositorio;

        public ProdutoController(IProdutoRepositorio produtoRepositorio)
        {
            this.produtoRepositorio = produtoRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(this.produtoRepositorio.obterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]Produto produto)
        {
            try
            {
                this.produtoRepositorio.adicionar(produto);

                return Created("api/produto", produto);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

    }
}