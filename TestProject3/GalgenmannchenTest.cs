using NUnit.Framework;
using Hangman3;

namespace TestProject3
{
    class GalgenmannchenTest
    {
        [Test]
        public void RateBuchstabe_NameOnlyLetters_NoError()
        {
            //Arrange
            Galgenmannchen Testrunde = new Galgenmannchen("hall o");
            //ACT
            string wort = Testrunde.RateBuchstabe('a');
            //Assert
            Assert.IsTrue("-a-- -" == wort);
        }
        [Test]
        public void RateBuchstabe_NameOnlyLetters_FULL_NoError()
        {
            //Arrange
            Galgenmannchen Testrunde = new Galgenmannchen("a a");
            //ACT
            string wort = Testrunde.RateBuchstabe('a');
            //Assert
            Assert.IsTrue("a a" == wort);
        }
    }
}
