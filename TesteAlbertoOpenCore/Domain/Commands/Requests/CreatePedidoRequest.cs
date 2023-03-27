using MediatR;
using TesteAlbertoOpenCore.Domain.Commands.Responses;
using TesteAlbertoOpenCore.Domain.Requests;

namespace TesteAlbertoOpenCore.Domain.Commands.Requests
{
    public class CreatePedidoRequest : IRequest<CreatePedidoResponse>
    {
        public int ClienteId { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
