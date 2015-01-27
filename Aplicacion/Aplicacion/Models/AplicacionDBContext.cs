using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Models
{
    public class AplicacionDBContext : DbContext
    {
        public DbSet<Office> Offices { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
