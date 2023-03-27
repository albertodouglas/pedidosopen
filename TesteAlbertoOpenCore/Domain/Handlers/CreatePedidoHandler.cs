using TesteAlbertoOpenCore.Context;
using TesteAlbertoOpenCore.Domain.Commands.Requests;
using TesteAlbertoOpenCore.Domain.Commands.Responses;
using TesteAlbertoOpenCore.Domain.Entities;

namespace TesteAlbertoOpenCore.Domain.Handlers
{
    public class CreatePedidoHandler : ICreatePedidoHandler
    {
        private readonly AppDbContext _context;

        public CreatePedidoHandler(AppDbContext context)
        {
            _context = context;
        }

        public CreatePedidoResponse Handle(CreatePedidoRequest command)
        {
            var pedido = new Pedido
            {
                ClienteId = command.ClienteId,
                DataCriacao = DateTime.Now
            };

            _context.Pedidos.Add(pedido);
            _context.SaveChanges();

            int numPedidoNovo = pedido.Id;

            decimal valorTotalPedido = 0m;
            foreach (var item in command.Produtos)
            {
                // pega o valor unitário do produto
                decimal valorProduto = _context.Produtos.First(x => x.Id == item.Id).ValorUnitario;

                var itemPedido = new ItemPedido
                {
                    PedidoId = numPedidoNovo,
                    ProdutoId = item.Id,
                    Quantidade = item.Quantidade
                };

                // salva o item do pedido no banco
                _context.ItensPedidos.Add(itemPedido);

                valorTotalPedido += (item.Quantidade * valorProduto);
            }

            // saveChanges
            _context.SaveChanges();

            return new CreatePedidoResponse
            {
                Id = pedido.Id,
                DataPedido = DateTime.Now,
                ValorTotal = valorTotalPedido
            };
        }
    }
}
