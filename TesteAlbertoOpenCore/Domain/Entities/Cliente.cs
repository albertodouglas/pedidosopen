using System.ComponentModel.DataAnnotations;

namespace TesteAlbertoOpenCore.Domain.Entities
{
    public class Cliente
    {
        public int Id { get; set; }

        [StringLength(80)]
        [Required]
        public string Name { get; set; }

        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }
    }
}
