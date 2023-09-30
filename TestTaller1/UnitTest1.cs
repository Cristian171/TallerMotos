namespace TestTaller1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.IO;

    [TestClass]
    public class MotoTests
    {
        [TestMethod]
        public void Moto_Constructor_DebeInicializarParametrosCorrectamente()
        {
            // Arrange
            Moto moto = new Moto();

            // Act & Assert
            Assert.AreEqual(1.0f, moto.Speed);
            Assert.AreEqual(1.0f, moto.Acceleration);
            Assert.AreEqual(1.0f, moto.Handling);
            Assert.AreEqual(1.0f, moto.Grip);
        }

        [TestMethod]
        public void Moto_PersonalizarParte_DebeModificarParametrosCorrectamente()
        {
            // Arrange
            Moto moto = new Moto();
            Parte engine = new Engine();

            // Act
            moto.PersonalizarParte(engine);

            // Assert
            Assert.AreEqual(3.0f, moto.Speed);        // (1.0f + 2.0f) = 3.0f
            Assert.AreEqual(2.0f, moto.Acceleration);  // (1.0f + 1.0f) = 2.0f
            Assert.AreEqual(2.0f, moto.Handling);      // (1.0f + 1.0f) = 2.0f
            Assert.AreEqual(1.0f, moto.Grip);         // (1.0f + 0.0f) = 1.0f
        }
    }

    internal class Engine : Parte
    {
    }

    internal class Parte
    {
    }
}