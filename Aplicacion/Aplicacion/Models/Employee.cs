using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        [StringLength(50, ErrorMessage = "El nombre del empleado no debe ser mayor a 50 caracteres. ")]
        public string nombre { get; set; }

        [Required]
        [Display(Name = "Apellido")]
        [StringLength(50, ErrorMessage = "El apellido del empleado no debe ser mayor a 50 caracteres. ")]
        public string apellido { get; set; }

        [Display(Name = "Dirección")]
        [StringLength(100, ErrorMessage = "La dirección no debe ser mayor a 100 caracteres. ")]
        public string direccion { get; set; }

        [Required]
        [Display(Name = "Teléfono")]
        [StringLength(8, ErrorMessage = "El número de teléfono no debe ser mayor a 8 caracteres. ")]
        public string telefono { get; set; }

        [Required]
        [Display(Name = "Activo")]
        public bool estado { get; set; }

        [Required]
        [Display(Name = "Fecha de Ingreso")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime f_ingreso { get; set; }

        [ForeignKey("Office")]
        [Display(Name = "Oficina")]
        public int OfficeID { get; set; }
        public virtual Office Office { get; set; }
    }
}
