namespace TesteAlbertoOpenCore.Domain.Commands.Responses
{
    public class CreatePedidoResponse
    {
        public int Id { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime DataPedido { get; set; }
    }
}
