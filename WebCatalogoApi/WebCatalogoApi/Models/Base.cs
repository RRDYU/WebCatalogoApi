using System;

namespace WebCatalogoApi.Models
{
    public class Base
    {
        public Base()
        {
            Criacao = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime Criacao { get; set; }
        public DateTime Update { get; set; }
    }
}
