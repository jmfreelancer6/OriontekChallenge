using System.ComponentModel.DataAnnotations;

namespace Domain.Core.Entity
{
    public class tbl_Clientes
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
