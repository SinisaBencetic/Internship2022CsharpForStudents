using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship2022CsharpForStudents
{
    [TestClass]
    public class Challenges
    {
        public string Likes(string[] name)
        {
            throw new NotImplementedException();
        }

        [TestMethod, Description("It should return correct text")]
        public void FirstChallenge()
        {

            //[] --> "no one likes this"
            //["Peter"]-- > "Peter likes this"
            //["Jacob", "Alex"]-- > "Jacob and Alex like this"
            //["Max", "John", "Mark"]-- > "Max, John and Mark like this"
            //["Alex", "Jacob", "Mark", "Max"]-- > "Alex, Jacob and 2 others like this"

            Assert.AreEqual("no one likes this", Likes(new string[0]));
            Assert.AreEqual("Peter likes this", Likes(new string[] { "Peter" }));
            Assert.AreEqual("Jacob and Alex like this", Likes(new string[] { "Jacob", "Alex" }));
            Assert.AreEqual("Max, John and Mark like this", Likes(new string[] { "Max", "John", "Mark" }));
            Assert.AreEqual("Alex, Jacob and 2 others like this", Likes(new string[] { "Alex", "Jacob", "Mark", "Max" }));
        }


        public string Maskify(string cc)
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void SecondChallenge()
        {
            //Your task is to write a function maskify, which changes all but the last four characters into '#'.
            //"4556364607935616" --> "############5616"
            //"64607935616"-- > "#######5616"
            //   "1"-- > "1"
            //    ""-- > ""
            // "What was the name of your first pet?"
            //"Skippy"-- > "##ippy"
            

                Assert.AreEqual("############5616", Maskify("4556364607935616"));
                Assert.AreEqual("1", Maskify("1"));
                Assert.AreEqual("#1111", Maskify("11111"));
            
        }

        public bool CheckXO(string text)
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void ThirdChallenge()
        {
            //Check to see if a string has the same amount of 'x's and 'o's. The method must return a boolean and be case insensitive. The string can contain any char.
            // Examples:
            //XO("ooxx") => true
            //XO("xooxx") => false
            //XO("ooxXm") => true
            //XO("zpzpzpp") => true // when no 'x' and 'o' is present should return true
            //XO("zzoo") => false
            Assert.AreEqual(true, CheckXO("xo"));
            Assert.AreEqual(true, CheckXO("xxOo"));
            Assert.AreEqual(false, CheckXO("xxxm"));
            Assert.AreEqual(false, CheckXO("Oo"));
            Assert.AreEqual(false, CheckXO("ooom"));

        }

        public int SquareDigits(int number)
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void FourthChallenge()
        {
            //You are asked to square every digit of a number and concatenate them.

            //For example, if we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1.

            //Note: The function accepts an integer and returns an integer

            Assert.AreEqual(811181, SquareDigits(9119));
            Assert.AreEqual(0, SquareDigits(0));
        }

        public string AddBinary(int a, int b)
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void FifthChallenge()
        {            
            //Implement a function that adds two numbers together and returns their sum in binary. The conversion can be done before, or after the addition.
            //The binary number returned should be a string.
            //1, 1 --> "10" (1 + 1 = 2 in decimal or 10 in binary)            
            //5, 9-- > "1110"(5 + 9 = 14 in decimal or 1110 in binary)
            
            Assert.AreEqual("11", AddBinary(1, 2), "Should return \"11\" for 1 + 2");
        }

        public string[] FriendOrFoe(string[] names)
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void SixthChallenge()
        {
            //Make a program that filters a list of strings and returns a list with only your friends name in it.

            //If a name has exactly 4 letters in it, you can be sure that it has to be a friend of yours! Otherwise, you can be sure he's not...

            //Ex: Input = ["Ryan", "Kieran", "Jason", "Yous"], Output = ["Ryan", "Yous"]

            //i.e.

            //friend["Ryan", "Kieran", "Mark"] `shouldBe` ["Ryan", "Mark"]
            //Note: keep the original order of the names in the output.

            string[] expected = { "Ryan", "Mark" };
            string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };
            CollectionAssert.AreEqual(expected, FriendOrFoe(names));
        }
    }
}
