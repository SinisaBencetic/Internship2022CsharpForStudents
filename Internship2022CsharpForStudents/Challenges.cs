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
            return "";
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
    }
}
