using TesteAlbertoOpenCore.Domain;
using TesteAlbertoOpenCore.Domain.Entities;

namespace TesteAlbertoOpen.Services
{
    public interface IPedidoService
    {
        Task<IEnumerable<Pedido>> GetAll();

        Task CreatePedido(Pedido pedido);

    }
}
