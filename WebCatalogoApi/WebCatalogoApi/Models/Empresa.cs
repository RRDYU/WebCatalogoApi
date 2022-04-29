using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebCatalogoApi.Models
{
    [Table("tb_empresas")]
    public class Empresa : Base
    {
        [Required]
        [MaxLength(80)]
        public string Nome { get; set; }
    }
}
