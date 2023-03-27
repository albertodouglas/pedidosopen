namespace TesteAlbertoOpenCore.Domain.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }
    }
}
