using TesteAlbertoOpenCore.Domain.Commands.Requests;
using TesteAlbertoOpenCore.Domain.Commands.Responses;

namespace TesteAlbertoOpenCore.Domain.Handlers
{
    public interface ICreatePedidoHandler
    {
        CreatePedidoResponse Handle(CreatePedidoRequest command);
    }
}
