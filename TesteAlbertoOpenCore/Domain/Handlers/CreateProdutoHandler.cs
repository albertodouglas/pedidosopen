using TesteAlbertoOpenCore.Context;
using TesteAlbertoOpenCore.Domain.Commands.Requests;
using TesteAlbertoOpenCore.Domain.Commands.Responses;
using TesteAlbertoOpenCore.Domain.Entities;

namespace TesteAlbertoOpenCore.Domain.Handlers
{
    public class CreateProdutoHandler : ICreateProdutoHandler
    {
        private readonly AppDbContext _context;

        public CreateProdutoHandler(AppDbContext context)
        {
            _context = context;
        }

        public CreateProdutoResponse Handle(CreateProdutoRequest command)
        {
            var produto = new Produto
            {
                Nome = command.Nome,
                ValorUnitario = command.ValorUnitario
            };

            _context.Produtos.Add(produto);
            _context.SaveChanges();

            return new CreateProdutoResponse
            {
                Id = produto.Id,
                Name = produto.Nome,
                ValorUnitario = produto.ValorUnitario
            };
        }
    }
}
