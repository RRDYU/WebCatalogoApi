using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebCatalogoApi.Models
{
    [Table("tb_categorias")]
    public class Categoria : Base
    {
        public Categoria()
        {
            Produtos = new Collection<Produto>();
        }

        [Required]
        [MaxLength(80)]
        public string Nome { get; set; }
        [Required]
        [MaxLength(300)]
        public int ImagemUrl { get; set; }
        public ICollection<Produto> Produtos { get; set; }
    }
}
