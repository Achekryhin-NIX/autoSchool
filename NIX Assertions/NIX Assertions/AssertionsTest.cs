using System;
using NUnit.Framework;
using System.Collections.Generic;
namespace NIX_Assertions
{
    public class AssertionsTest
    {
        public void Asserttwostrings()
        {
            string str2 = "s";
            string str1 = "s";

            Assert.IsTrue(str2 == str1);


        }

        public void AsserttwoList()

        {
            List<string> Names1 = new List<string> { "Tom", "Maria", "Ann" };

            List<string> Names2 = new List<string> { "Tom", "Maria", "Ann" };

            Assert.AreEqual(Names1, Names2);
        }

        public void AssertListContainString()
        {
            List<string> Company = new List<string> { "ABC", "NIX", "Microsoft" };
            string NIX = "NIX";

            Assert.Contains(NIX, Company);

        }
        public void ReturnsTrue()
        {
            int a = 10;
            int b = 5;

            Assert.IsTrue(a > b);


        }
    }
}







    


      
 

