using MediatR;
using Microsoft.AspNetCore.Mvc;
using TesteAlbertoOpenCore.Domain.Commands.Requests;
using TesteAlbertoOpenCore.Domain.Handlers;

namespace TesteAlbertoOpenAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : Controller
    {
        [HttpPost]
        public IActionResult Create([FromServices] IMediator mediator, [FromBody] CreateClienteRequest command)
        {
            if (String.IsNullOrEmpty(command.Nome) || command.Nome.ToLower() == "string")
            {
                return StatusCode(400, "O nome do cliente é obrigatório ou está inválido!");
            }

            try
            {
                var response = mediator.Send(command);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            }
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll([FromServices] IMediator mediator, [FromQuery] FindAllClientsRequest command)
        {
            var response = mediator.Send(command);
            return Ok(response);
        }
    }
}
