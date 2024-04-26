using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mymovieapp.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Display(Name = "Nombre del cliente")]
        [Required]
        public string? Nombre { get; set; }

        [Display(Name = "Apellido del cliente")]
        [Required]
        public string? Apellido { get; set; }

        [EmailAddress]
        [Display(Name = "Correo Electronico")]
        [Required]
        public string? CorreoElectronico { get; set; }

        [Phone]
        [Required]
        public string? Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}