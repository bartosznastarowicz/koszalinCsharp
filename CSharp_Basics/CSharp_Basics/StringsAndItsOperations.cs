﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharp_Basics
{
    [TestFixture]
    public class StringsAndItsOperations
    {
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

            double x = 5;
            double y = 10;
            double add = x + y;
            string basic = "Sum of " + x + " and " + y + " is equal " + add;
            string formated = string.Format("Sum of {0} and {1} is equal {2}", x, y, add);
            string formatedNew = $"Sum of {x} and {y} is equal {add}";

            Assert.That(itsEmpty, Is.Not.Null);
            Assert.IsEmpty(itsEmpty);

            Console.WriteLine(basic);
            Console.WriteLine(formated);
            Console.WriteLine(formatedNew);
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
