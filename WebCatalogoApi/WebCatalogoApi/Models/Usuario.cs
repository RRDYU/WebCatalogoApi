using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebCatalogoApi.Models
{
    [Table("tb_usuarios")]
    public class Usuario : Base
    {
        [Required]
        [MaxLength(80)]
        public string Nome { get; set; }
    }
}
