using MediatR;
using Microsoft.EntityFrameworkCore;
using TesteAlbertoOpenCore.Context;
using TesteAlbertoOpenCore.Domain.Commands.Requests;
using TesteAlbertoOpenCore.Domain.Commands.Responses;
using TesteAlbertoOpenCore.Domain.Entities;

namespace TesteAlbertoOpenCore.Domain.Handlers
{
    public class CreateClienteHandler : IRequestHandler<CreateClienteRequest, CreateClienteResponse>
    {
        private readonly AppDbContext _context;

        public CreateClienteHandler(AppDbContext context)
        {
            _context = context;
        }

        public Task<CreateClienteResponse> Handle(CreateClienteRequest request, CancellationToken cancellationToken)
        {
            bool clienteDb = _context.Clientes.Any(x => x.Email.ToLower() == request.Email.ToLower());
            if (clienteDb)
            {
                throw new Exception("E-mail já existe");
            }

            var cliente = new Cliente
            {
                Name = request.Nome,
                Email = request.Email
            };

            _context.Clientes.Add(cliente);
            _context.SaveChanges();

            var result = new CreateClienteResponse
            {
                Id = cliente.Id,
                Name = cliente.Name,
                Email = cliente.Email,
            };

            return Task.FromResult(result);
        }
    }
}
