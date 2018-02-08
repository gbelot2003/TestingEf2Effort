using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingEf2.Models
{
    public class MiTestContext : DbContext
    {
        public DbSet<Contactos> Contactos { get; set; }
    }
}
