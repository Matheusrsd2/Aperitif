using System.ComponentModel.DataAnnotations;

namespace Aperitif.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public int DisplayOrder { get; set; }
    }
}
