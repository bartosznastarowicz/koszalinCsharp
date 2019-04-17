using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace CSharp_Basics
{
    [TestFixture]
    public class StringsAndItsOperations
    {
        private string Poem = "Powiem szczerze, znajomych mam wielu,Ale tylko do Ciebie mogę powiedzieć: Mój przyjacielu.Po dodaniu imienia wiersz będzie już wierszykiem spersonalizowanym:Powiem szczerze, znajomych mam wielu,Ale tylko do Ciebie Andrzeju mogę powiedzieć: Mój przyjacielu.";
        [Test]
        public void replace1()
        {
            char[] delimiters = {',', ':', ';', '.'};
            string[] lines = Poem.Split(delimiters);
            string parsedPoem = string.Join("\n", lines);

            Console.WriteLine(parsedPoem);
        }

        [Test]
        public void replace2()
        {
            string[] lines = Regex.Split(Poem, "(?<=[.,:;!?])");
            string parsedPoem = string.Join("\n", lines);

            Console.WriteLine(parsedPoem);
        }

        [Test]
        public void replace3()
        {
            char[] delimiters = { ',', ':', ';', '.' };

        }
        
        /// <summary>
        /// String is diffrent then previues types we talk about
        /// values of string we are passing in quotation marks
        /// 
        /// Create new string with your name and then add them together
        /// </summary>
        [Test]
        public void Bascis_Of_Strings()
        {
            string Example = "This is example string";
            string myName = "Bartek";

            string strAdd = Example + " " + myName;

            Assert.AreEqual(strAdd, "This is example string Bartek");
        }

        /// <summary>
        ///  string is  first Reference Type you see (We will talk more about them later)
        ///  which means he doesn't have to have value.
        ///  use string.Empty;
        ///  create new strings itsEmpty and make it empty
        /// </summary>
        [Test]
        public void String_Initialization()
        {
            string itsEmpty = string.Empty;
            {
                double x = 5;
                double y = 10;
                double add = x + y;
                string basic = "Sum of " + x + " and " + y + " is equal " + add;
                string formated = string.Format("Sum of {0} and {1} is equal {2}", x, y, add);
                string formatedNew = $"Sum of {x} and {y} is equal {add}";
                Console.WriteLine(basic);
                Console.WriteLine(formated);
                Console.WriteLine(formatedNew);
                Assert.That(itsEmpty, Is.Not.Null);
                Assert.IsEmpty(itsEmpty);
                double z = 5;
                string errorMessage = "There was error with operation values \n" + x + " and " + z;
                string errorMessageFormat = string.Format("There was error with operation values \n{0} and {1}", x, z);
                string errorMessageFormatDollar = $"There was error with operation values \n{x} and {z}               ";
                Console.WriteLine(errorMessage);
                Console.WriteLine(errorMessageFormat);
                Console.WriteLine(errorMessageFormatDollar);
                
                Assert.That(z, Is.EqualTo(6));
                
            }
        }
        /// <summary>
        /// + is not best way of adding string
        ///  use string.Concat();
        ///  put sentence together
        /// </summary>
        [Test]
        public void Adding_String()
        {
            string first = "pancakes.";
            string second = "I like";

            string result = string.Concat(second, " ", first);

            Assert.AreEqual(result, "I like pancakes.");
            Console.WriteLine(result);
        }

        /// <summary>
        /// there is few more ways of cosntructing strings for example if you need add values of other variables inside you can do
        /// https://docs.microsoft.com/en-us/dotnet/api/system.string.format?view=netframework-4.7.1#starting
        /// create string with both x and y insed
        /// </summary>
        [Test]
        public void string_format()
        {
            int x = 500;
            int y = 453;
            string result = $"{x}{y}";
      
            StringAssert.Contains(x.ToString(), result);
            StringAssert.Contains(y.ToString(), result);
        }

        /// <summary>
        /// From theString return word "thing".
        /// hint use Substring() method
        /// </summary>
        [Test]
        public void Substrings()
        {
            var theString =
                "The interesting thing about London is that there are always stylish surprises around every corner.";

            string var = "thing";
            int startIndex = theString.IndexOf(var);
            string result = theString.Substring(startIndex, var.Length);

            Console.WriteLine(result);
            Assert.AreEqual(result, "thing");
        }
    }
}
