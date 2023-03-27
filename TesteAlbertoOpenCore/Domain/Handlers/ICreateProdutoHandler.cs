using TesteAlbertoOpenCore.Domain.Commands.Requests;
using TesteAlbertoOpenCore.Domain.Commands.Responses;

namespace TesteAlbertoOpenCore.Domain.Handlers
{
    public interface ICreateProdutoHandler
    {
        CreateProdutoResponse Handle(CreateProdutoRequest command);
    }
}
