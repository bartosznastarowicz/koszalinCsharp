using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
    public class EmployeeIT:Employee
    {
        public EmployeeIT(string firstName, int idNumber, Locations department, string programingLanguage) : base(firstName, idNumber, department)
        {
            this.ProgramingLanguage = ProgramingLanguage;
        }

        public EmployeeIT(string firstName, int idNumber, string department, string programingLanguage):base(firstName, idNumber, department)
        {
            //this.ProgramingLanguage = programingLanguage;
            ProgramingLanguages temp;
            Enum.TryParse(programingLanguage, out temp);
            this.ProgramingLanguage = temp;
        }
        public ProgramingLanguages ProgramingLanguage { get; }

        public string ProgramingLanguagesToString()
        {
            return ProgramingLanguage.ToString();
        }
    }
}
