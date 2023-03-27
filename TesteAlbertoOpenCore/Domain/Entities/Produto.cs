using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteAlbertoOpenCore.Domain.Entities
{
    public class Produto
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Nome { get; set; }

        [Column(TypeName = "decimal(8,2)")] 
        public decimal ValorUnitario { get; set; }
    }
}
