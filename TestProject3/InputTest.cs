using NUnit.Framework;
using Hangman3;

namespace TestProject3
{
    [TestFixture]
    public class InputTest
    {
       /* [SetUp]
        public void Setup()
        {
        }*/

        [Test]
        public void IsInputWrong_InputLetter_IsCorrect()
        {
            //Arrange

            //ACT
            bool test = Input.IsInputWrong('a');
            //Assert
            Assert.IsFalse(test);
        }
        [Test]
        public void IsInputWrong_InputLetterSpace_IsWrong()
        {
            //Arrange

            //ACT
            bool test = Input.IsInputWrong(' ');
            //Assert
            Assert.IsTrue(test);
        }
        [Test]
        public void IsInputWrong_InputLetter_IsNotCorrect()
        {
            //Arrange

            //ACT
            bool test = Input.IsInputWrong('1');
            //Assert
            Assert.IsTrue(test);
        }
        [Test]
        public void IsInputWrong_InputStringBigSmallLetters_IsCorrect()
        {
            //Arrange

            //ACT
            bool test = Input.IsInputWrong("Aa");
            //Assert
            Assert.IsFalse(test);
        }
        [Test]
        public void IsInputWrong_InputStringWithNumbers_IsNotCorrect()
        {
            //Arrange

            //ACT
            bool test = Input.IsInputWrong("Aa1");
            //Assert
            Assert.IsTrue(test);
        }
    }
}
