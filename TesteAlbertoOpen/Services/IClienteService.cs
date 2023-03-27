using TesteAlbertoOpenCore.Domain.Entities;

namespace TesteAlbertoOpen.Services
{
    public interface IClienteService
    {
        Task<IEnumerable<Cliente>> GetClientes();
    }
}
