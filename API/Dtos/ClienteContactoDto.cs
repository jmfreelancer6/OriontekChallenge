using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class ClienteContactoDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio.")]
        public int IDCliente { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio.")]
        [MaxLength(400, ErrorMessage = "El maximo permitido es 400 caracteres.")]
        public string Address { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio.")]
        [MaxLength(14, ErrorMessage = "El maximo permitido es 14 caracteres.")]
        [RegularExpression(@"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}", ErrorMessage = "Formato invalido, el formato correcto es (999)999-9999")]
        public string TelePhone { get; set; }
    }
}
