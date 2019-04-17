using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharp_Basics
{
    [TestFixture]
    public class EmployeeTests
    {
        [Test]
        public void Employee_Creation_FieldsProperlyField()
        {
            var employee = new Employee("Emka", 666, "Koszalin");
            var employee1 = new Employee("Bartek", 777, "Szczecin");
            var employee2 = new Employee("Aleksandra", 888, "Wrocław");

            Assert.That(employee.FirstName, Is.EqualTo("Emka"));
            Assert.That(employee.IDNumber, Is.EqualTo(666));
            Assert.That(employee.Department, Is.EqualTo("Koszalin"));

            Assert.That(employee1.FirstName, Is.EqualTo("Bartek"));
            Assert.That(employee1.IDNumber, Is.EqualTo(777));
            Assert.That(employee1.Department, Is.EqualTo("Szczecin"));

            Assert.That(employee2.FirstName, Is.EqualTo("Aleksandra"));
            Assert.That(employee2.IDNumber, Is.EqualTo(888));
            Assert.That(employee2.Department, Is.EqualTo("Wrocław"));
        }

        [Test]
        public void Employee_Creation_FieldsProperlyFieldWithProfesion()
        {
            var employee = new EmployeeIT("Emilia", 123, "Koszalin", "Csharp");
            var employee1 = new EmployeeIT("Marek", 234, "Koszalin", "Cplus");
            var employee2 = new EmployeeIT("Bartek", 345, "Szczecin", "Python");

            Assert.That(employee.FirstName, Is.EqualTo("Emilia"));
            Assert.That(employee.IDNumber, Is.EqualTo(123));
            Assert.That(employee.Department, Is.EqualTo("Koszalin"));
            Assert.That(employee.ProgramingLanguage, Is.EqualTo("Csharp"));
        }

        [Test]
        public void Employee_Creation_FieldsProperlyFieldEnum()
        {
            var employee = new EmployeeIT("Emilia", 12345, "Koszalin", "Csharp");

            Assert.That(employee.FirstName, Is.EqualTo("Emilia"));
            Assert.That(employee.IDNumber, Is.EqualTo(12345));
            Assert.That(employee.DepartmentToString, Is.EqualTo("Koszalin"));
            Assert.That(employee.ProgramingLanguagesToString, Is.EqualTo("Csharp"));
        }

        [TestCase(Locations.Szczecin, true)]
        [TestCase(Locations.Koszalin, true)]
        [TestCase(Locations.ZielonaGora, false)]
        [TestCase(Locations.Wroclaw, false)]
        [TestCase(Locations.Krakow, false)]
        public void Employee_LocationTest(Locations loc, bool result)
        {
            var employee = new EmployeeIT("Bartek", 345, loc, "Python");

            Assert.That(employee.IsNorthOfWarsaw, Is.EqualTo(result));
        }

        [TestCase(Locations.Koszalin,11111)]
        [TestCase(Locations.ZielonaGora,66666)]
        public void Employee_IDisInWrongRange()
        {

        }
    }
}
