using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebCatalogoApi.Models
{
    [Table("tb_enderecos")]
    public class Endereco : Base
    {
        [Required]
        [MaxLength(150)]
        public string Logradouro { get; set; }
        [Required]
        [MaxLength(80)]
        public string Referencia { get; set; }
        [Required]
        [MaxLength(80)]
        public string Cidade { get; set; }
        [Required]
        [MaxLength(30)]
        public string UF { get; set; }
    }
}
