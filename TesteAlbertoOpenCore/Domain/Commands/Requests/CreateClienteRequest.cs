using MediatR;
using TesteAlbertoOpenCore.Domain.Commands.Responses;

namespace TesteAlbertoOpenCore.Domain.Commands.Requests
{
    public class CreateClienteRequest : IRequest<CreateClienteResponse>
    {
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
