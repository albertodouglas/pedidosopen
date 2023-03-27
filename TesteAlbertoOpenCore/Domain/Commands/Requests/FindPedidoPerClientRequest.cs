using MediatR;
using System.ComponentModel.DataAnnotations;
using TesteAlbertoOpenCore.Domain.Commands.Responses;

namespace TesteAlbertoOpenCore.Domain.Commands.Requests
{
    public class FindPedidoPerClientRequest : IRequest<FindPedidoPerClientResponse>
    {
        [Required]
        public int ClientId { get; set; }
    }
}
