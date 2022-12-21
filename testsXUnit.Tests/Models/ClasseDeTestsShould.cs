using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testsXUnit.Tests.Models
{
    public class ClasseDeTestsShould
    {
        [Fact]
        public void TestTrue()
        {
            Assert.True(true);
        }

        public double Discount(double price, double disocuntPourcentahe)
        {
            double discount = price * disocuntPourcentahe / 100;
            return discount;
        }

        public bool EqualStrings(string str1, string str2)
        {
            string str_1_lowercase = str1.ToLower();
            string str_2_lowercase = str2.ToLower();

            return str_1_lowercase.Equals(str_2_lowercase);
        }

        public List<int> AddIntToList(List<int> myList, int element)
        {
            myList.Add(element);
            return myList;
        }

        /*          ***   TESTS   ***          */

        [Theory]
        [InlineData(100, 80, 80)]
        [InlineData(0,30,0)]
        [InlineData(150, 20, 30)]
        public void CalculerDiscount(double price, double discountPercentage, double expected)
        {
            ClasseDeTestsShould classeEcemple = new ClasseDeTestsShould();
            double returnedDiscount = classeEcemple.Discount(price, discountPercentage);
            Assert.Equal(expected, returnedDiscount);
        }

        [Theory]
        [InlineData("HELLO WORLD", "hello world")]
        [InlineData("Hello World", "hello world")]
        [InlineData("", "")]
        public void AcceptEqualStrings(string str1, string str2)
        {
            ClasseDeTestsShould exemple = new ClasseDeTestsShould();
            Assert.True(exemple.EqualStrings(str1, str2));
        }

        [Theory]
        [InlineData("This is a string", "this is another string")]
        [InlineData("helloworld", "hello world")]
        [InlineData("", "  ")]
        public void RejectUnequalStrins(string str1, string str2)
        {
            ClasseDeTestsShould exemple = new ClasseDeTestsShould();
            Assert.False(exemple.EqualStrings(str1, str2));
        }
    }
}
