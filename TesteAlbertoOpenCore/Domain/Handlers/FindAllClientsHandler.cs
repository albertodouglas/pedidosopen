using MediatR;
using Microsoft.EntityFrameworkCore;
using TesteAlbertoOpenCore.Context;
using TesteAlbertoOpenCore.Domain.Commands.Requests;
using TesteAlbertoOpenCore.Domain.Commands.Responses;

namespace TesteAlbertoOpenCore.Domain.Handlers
{
    public class FindAllClientsHandler : IRequestHandler<FindAllClientsRequest, FindAllClientesResponse>
    {
        private readonly AppDbContext _context;

        public FindAllClientsHandler(AppDbContext context)
        {
            _context = context;
        }

        public Task<FindAllClientesResponse> Handle(FindAllClientsRequest request, CancellationToken cancellationToken)
        {
            var clients = _context.Clientes.AsNoTracking().ToList();

            var result = new FindAllClientesResponse
            {
                Clientes = clients
            };

            return Task.FromResult(result);
        }
    }
}
