using TesteAlbertoOpenCore.Domain.Entities;

namespace TesteAlbertoOpenCore.Domain.Requests
{
    public class Pedidos
    {
        public DateTime Data { get; set; }
        public string NomeCliente { get; set; }
        public decimal ValorTotal => Itens.Sum(x => x.ValorTotalItem);
        public List<ItensPedidos> Itens { get; set; }
    }
}
