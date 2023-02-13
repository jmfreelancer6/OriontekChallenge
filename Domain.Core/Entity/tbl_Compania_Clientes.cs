using System.ComponentModel.DataAnnotations;

namespace Domain.Core.Entity
{
    public class tbl_Compania_Clientes
    {
        [Key]
        public int ID { get; set; }
        public int IDCliente { get; set; }
        public int IDCompania { get; set; }
    }
}
