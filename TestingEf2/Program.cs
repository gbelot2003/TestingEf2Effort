using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingEf2.Models;

namespace TestingEf2
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MiTestContext())
            {
                context.Contactos.Add(new Contactos
                {
                    Nombre = "Pedro Perez",
                    Correo = "pedro@test.com"
                });

                context.SaveChanges();
            }
        }
    }
}
