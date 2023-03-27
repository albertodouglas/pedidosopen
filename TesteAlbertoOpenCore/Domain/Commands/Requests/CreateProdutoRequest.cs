using MediatR;
using TesteAlbertoOpenCore.Domain.Commands.Responses;

namespace TesteAlbertoOpenCore.Domain.Commands.Requests
{
    public class CreateProdutoRequest : IRequest<CreateProdutoResponse>
    {
        public string Nome { get; set; }
        public decimal ValorUnitario { get; set; }
    }
}
