using System.ComponentModel.DataAnnotations;

namespace Domain.Core.Entity
{
    public class tbl_Clientes_Contacto
    {
        [Key]
        public int Id { get; set; }
        public int IDCliente { get; set; }
        public string Address { get; set; }
        public string TelePhone { get;set; }
    }
}
