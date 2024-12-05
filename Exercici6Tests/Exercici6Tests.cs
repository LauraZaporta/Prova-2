namespace Exercici6Tests
{
    //Classes equvalència LlargadaContrasenya:
    //Vàlides: [5,12]
    //Invàlides: (-infinit, 5) U (12, +infinit)
    //Classes equvalència TipusChars:
    //Vàlides: (a-z, A-Z, 0-9)
    //Invàlides: Caràcers especials
    //Classes equvalència NoNumsExtrems:
    //Vàlides: <string>
    //Invàlides: [0,9]<string>[0,9]

    //Valors límit (només de LlargadaContrasenya perquè és l'única classe d'enters):
    //4, 5, 12, 13

    //Casos de prova:

    [TestClass]
    public class Exercici6Tests
    {
        [TestMethod]
        public void RangValid()
        {
            //Arrange
            string test = "rat4atata";
            bool result;
            //Act
            result = ValidRange(test);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void RangInvalid()
        {
            //Arrange
            string test = "ra"
            bool result;
            //Act
            result = ValidRange(test)
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void SpecialCharsPresent()
        {
            //Arrange
            string test = "ratatata&";
            bool result;
            //Act
            result = ValidChars(test);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void NumbersInExtrems()
        {
            //Arrange
            string test = "ratatata9";
            bool result;
            //Act
            result = ValidNotNumsExtrems(test);
            //Assert
            Assert.IsFalse(result);
        }
    }
}