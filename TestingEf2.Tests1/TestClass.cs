using NUnit.Framework;
using System.Linq;
using TestingEf2.Models;

namespace TestingEf2.Tests1
{
    [TestFixture]
    public class TestClass
    {
        [SetUp]
        public void Setup()
        {
            PFactory.ResetDb();
            using (var context = new MiTestContext())
            {
                context.Contactos.Add(new Contactos
                {
                    Nombre = "Juan Lopez",
                    Correo = "juan@test.com"
                });
                context.SaveChanges();
            }
        }

        [Test]
        public void IsJuanLopezTest()
        {
            using (var c = new MiTestContext())
            {
                Assert.AreEqual("juan@test.com", c.Contactos.First().Correo);
            }
        }
    }
}