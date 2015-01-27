using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Models
{
    public class Office
    {
        public int OfficeID { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        [StringLength(50, ErrorMessage = "El nombre de la oficina no debe ser mayor a 50 caracteres. ")]
        public string nombre { get; set; }

        [Required]
        [Display(Name = "Teléfono")]
        [StringLength(8, ErrorMessage = "El número de teléfono no debe ser mayor a 8 caracteres. ")]
        public string telefono { get; set; }

        [Required]
        [Display(Name = "Dirección")]
        [StringLength(100, ErrorMessage = "La dirección no debe ser mayor a 100 caracteres. ")]
        public string direccion { get; set; }

        [Display(Name = "Descripción")]
        [StringLength(100, ErrorMessage = "La descripción no debe ser mayor a 100 caracteres. ")]
        public string descripcion { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
