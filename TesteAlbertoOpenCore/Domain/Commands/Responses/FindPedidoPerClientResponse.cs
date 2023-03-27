using TesteAlbertoOpenCore.Domain.Requests;

namespace TesteAlbertoOpenCore.Domain.Commands.Responses
{
    public class FindPedidoPerClientResponse
    {
        public string Cliente { get; set; }
        public List<Pedidos>? Pedidos { get; set; }
    }
}
