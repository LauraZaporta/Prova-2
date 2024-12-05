namespace Exercici6Tests
{
    //Classes equval�ncia LlargadaContrasenya:
    //V�lides: [5,12]
    //Inv�lides: (-infinit, 5) U (12, +infinit)
    //Classes equval�ncia TipusChars:
    //V�lides: (a-z, A-Z, 0-9)
    //Inv�lides: Car�cers especials
    //Classes equval�ncia NoNumsExtrems:
    //V�lides: <string>
    //Inv�lides: [0,9]<string>[0,9]

    //Valors l�mit (nom�s de LlargadaContrasenya perqu� �s l'�nica classe d'enters):
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