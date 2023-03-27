using Microsoft.EntityFrameworkCore;
using TesteAlbertoOpenCore.Context;
using TesteAlbertoOpenCore.Domain.Commands.Requests;
using TesteAlbertoOpenCore.Domain.Commands.Responses;
using TesteAlbertoOpenCore.Domain.Requests;

namespace TesteAlbertoOpenCore.Domain.Handlers
{
    public class FindPedidoPerClientHandler : IFindPedidoPerClientHandler
    {
        private readonly AppDbContext _context;

        public FindPedidoPerClientHandler(AppDbContext context)
        {
            _context = context;
        }

        public FindPedidoPerClientResponse Handle(FindPedidoPerClientRequest command)
        {
            var cliente = _context.Clientes.Any(x => x.Id == command.ClientId);
            if (cliente)
            {
                var pedidos = _context.Pedidos
                    .Include(x => x.Cliente)
                    .AsNoTracking()
                    .Where(x => x.ClienteId == command.ClientId)
                    .Select(x => new Pedidos
                    {
                        NomeCliente = x.Cliente.Name,
                        Data = x.DataCriacao,
                        Itens = _context.ItensPedidos
                            .Include(i => i.Produto)
                            .AsNoTracking()
                            .Where(i => i.PedidoId == x.Id)
                            .Select(i => new ItensPedidos
                            {
                                Produto = i.Produto.Nome,
                                Quantidade = i.Quantidade,
                                ValorUnitario = i.Produto.ValorUnitario,
                            })
                            .ToList()
                    })
                    .ToList();

                if (pedidos.Count > 0)
                {
                    return new FindPedidoPerClientResponse
                    {
                        Pedidos = pedidos,
                        Cliente = pedidos[0].NomeCliente
                    };
                }
                throw new Exception("Nenhum pedido encontrado para o cliente informado!");
            }

            throw new Exception("Não existe cliente cadastrado com o Id informado!");
        }
    }
}
