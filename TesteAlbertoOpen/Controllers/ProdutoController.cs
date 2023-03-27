using Microsoft.AspNetCore.Mvc;
using TesteAlbertoOpenCore.Domain.Commands.Requests;
using TesteAlbertoOpenCore.Domain.Handlers;

namespace TesteAlbertoOpenAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : Controller
    {
        [HttpPost]
        public IActionResult Create([FromServices]ICreateProdutoHandler handler, [FromBody]CreateProdutoRequest command)
        {
            if (string.IsNullOrEmpty(command.Nome))
            {
                return StatusCode(400, "Informe o nome do produto");
            }

            var response = handler.Handle(command);
            return Ok(response);
        }
    }
}
