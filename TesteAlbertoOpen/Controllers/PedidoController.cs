using Microsoft.AspNetCore.Mvc;
using TesteAlbertoOpenCore.Domain.Commands.Requests;
using TesteAlbertoOpenCore.Domain.Handlers;

namespace TesteAlbertoOpenAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidoController : Controller
    {
        [HttpPost]
        public IActionResult Create([FromServices] ICreatePedidoHandler handler, [FromBody] CreatePedidoRequest command)
        {
            if (command.ClienteId == 0)
                return StatusCode(400, "Informe o código do cliente");

            if (command.Produtos.Count() == 0)
                return StatusCode(400, "Informe pelo menos um produto");

            foreach (var item in command.Produtos)
            {
                if (item.Id == 0 || item.Quantidade == 0)
                {
                    return StatusCode(400, "Existe um Id e/ou Quantidade de produto que está zero. Favor informar o Id e Quantidade para todos os produtos.");
                }
            }

            var response = handler.Handle(command);
            return Ok(response);
        }

        [HttpGet("GetPerClient")]
        public IActionResult FindPedidosPerClient([FromServices] IFindPedidoPerClientHandler handler, [FromQuery] FindPedidoPerClientRequest comand)
        {
            try
            {
                var response = handler.Handle(comand);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            }
        }
    }
}
