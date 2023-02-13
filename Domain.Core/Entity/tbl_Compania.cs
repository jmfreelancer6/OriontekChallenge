using System.ComponentModel.DataAnnotations;

namespace Domain.Core.Entity
{
    public class tbl_Compania
    {
        [Key]
        public int ID { get; set; }
        public string? CompaniaName { get; set; }
    }
}
