using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class ClienteDto
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El maximo permitido es 100 caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El maximo permitido es 100 caracteres.")]
        public string LastName { get; set; }
    }
}
