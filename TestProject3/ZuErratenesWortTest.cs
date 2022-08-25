using NUnit.Framework;
using Hangman3;

namespace TestProject3
{
    [TestFixture]
    public class ZuErratenesWortTest
    {
       /* [SetUp]
        public void Setup()
        {
        }*/

        [Test]
        public void GetOriginalWort_NameOnlyLetters_NoError()
        {
            //Arrange
            ZuErratenesWort OriginalWort = new ZuErratenesWort("hallo");
            //ACT
            string wort = OriginalWort.GetOriginalWort();
            //Assert
            Assert.IsTrue("hallo"==wort);
        }
        [Test]
        public void GetOriginalWort_NameWithSpace_NoError()
        {
            //Arrange
            ZuErratenesWort OriginalWort = new ZuErratenesWort("hallo a");
            //ACT
            //was hier tun?
            //Assert
            Assert.IsTrue("hallo a" == OriginalWort.GetOriginalWort());
        }
        [Test]
        public void SetOriginalWort_Name_NoError()
        {
            //Arrange
            ZuErratenesWort OriginalWort = new ZuErratenesWort("hallo a123");
            //ACT
            OriginalWort.SetOriginalWort("test");
            //Assert
            Assert.IsTrue("test" == OriginalWort.GetOriginalWort());
        }
        [Test]
        public void SetOriginalWort_Name_Error()
        {
            //Arrange
            ZuErratenesWort OriginalWort = new ZuErratenesWort("hallo a123");
            //ACT
            OriginalWort.SetOriginalWort("test");
            //Assert
            Assert.IsFalse("hallo a123" == OriginalWort.GetOriginalWort());
        }
        [Test]
        public void GetErstelltesWort()
        {
            //Arrange
            ZuErratenesWort OriginalWort = new ZuErratenesWort("hallo a");
            //ACT
            OriginalWort.GetErstelltesWort();
            string erwartet = "----- -";
            //Assert
            Assert.IsTrue(erwartet == OriginalWort.GetErstelltesWort());
        }
        [Test]
        public void SetErstelltesWortNeu_NoError()
        {
            //Arrange
            ZuErratenesWort OriginalWort = new ZuErratenesWort("hallo a");
            //ACT
            OriginalWort.SetErstelltesWortNeu('a');
            string erwartet = "-a--- a";
            //Assert
            Assert.IsTrue(erwartet == OriginalWort.GetErstelltesWort());
        }
        [Test]
        public void NeuGeratenerBuchstabe_string_NoError()
        {
            //Arrange
            ZuErratenesWort OriginalWort = new ZuErratenesWort("hallo");
            //ACT
            OriginalWort.NeuGeratenerBuchstabe('l');
            string erg = OriginalWort.GetErstelltesWort();
            string erwartet = "--ll-";
            //Assert
            Assert.IsTrue(erwartet == OriginalWort.GetErstelltesWort());
        }
        [Test]
        public void NeuGeratenerBuchstabeNichtFertig_bool_NoError()
        {
            //Arrange
            ZuErratenesWort OriginalWort = new ZuErratenesWort("hallo");
            //ACT
            OriginalWort.NeuGeratenerBuchstabe('l');
            bool erg = OriginalWort.GetFertigGeraten();
            bool erwartet = false;
            //Assert
            Assert.IsTrue(erwartet == erg);
        }
        [Test]
        public void NeuGeratenerBuchstabeFertig_bool_NoError()
        {
            //Arrange
            ZuErratenesWort OriginalWort = new ZuErratenesWort("aaa");
            //ACT
            OriginalWort.NeuGeratenerBuchstabe('a');
            bool erg = OriginalWort.GetFertigGeraten();
            bool erwartet = true;
            //Assert
            Assert.IsTrue(erwartet == erg);
        }

    }
}
