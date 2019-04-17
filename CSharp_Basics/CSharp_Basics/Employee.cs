using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
    public class Employee
    { 
        public Employee(string firstName, int idNumber, string department)
        {
            this.FirstName = firstName;
            this.IDNumber = idNumber;
            Locations temp;
            Enum.TryParse(department, out temp);
            ValidateIDNumber(idNumber, temp);
            this.Department = temp;

        }

        public Employee(string firstName, int idNumber, Locations department)
        {
            ValidateIDNumber(idNumber, department);
            this.FirstName = firstName;
            this.IDNumber = idNumber;
            this.Department = department;
        }

        public string FirstName { get; }
        public int IDNumber { get; }
        public Locations Department { get; }

        public string DepartmentToString()
        {
            return Department.ToString();
        }

        public bool IsNorthOfWarsaw()
        {
            if(Department == Locations.Koszalin || Department == Locations.Szczecin)
            {
                return true;
            }else {
                return false;
            }
        }

        private bool CheckIDLength()
        {
            var id = IDNumber.ToString();
            var idLength = id.Length;
            if (idLength == 5)
            {
                return true;
            }else {
                return false; }
        }

        private void ValidateIDNumber(int idNumber, Locations department)
        {
            if(idNumber < 10000 || idNumber > 99999)
            {
                throw new ArgumentOutOfRangeException("IDNumber should have 5 digits");
            }

            if(IsNorthOfWarsaw() && IDNumber >= 60000)
            {
                return;
            }
            if(!IsNorthOfWarsaw() && IDNumber < 60000)
            {
                return;
            }
        }
    }
}
