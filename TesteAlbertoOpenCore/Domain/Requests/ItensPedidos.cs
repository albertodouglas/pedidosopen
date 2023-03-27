namespace TesteAlbertoOpenCore.Domain.Requests
{
    public class ItensPedidos
    {
        public int Quantidade { get; set; }
        public string Produto { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotalItem => ValorUnitario * Quantidade;
    }
}
