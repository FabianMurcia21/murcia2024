using System.ComponentModel.DataAnnotations;

namespace ProyectoMejoramiento.Models
{
    public class Employee
    {
        [Key]
        public int Id_Emplo {  get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(30, ErrorMessage = "El nombre no acepta mas de 30 caracteres")]
        public string Name_Emplo { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(30, ErrorMessage = "El apellido no acepta mas de 30 caracteres")]
        public string LastName_Emplo { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(30, ErrorMessage = "El cargo no acepta mas de 30 caracteres")]
        public string Rol_Emplo { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Ingreso")]
        public DateTime EntryDate_Emplo { get; set; }

    }
}
