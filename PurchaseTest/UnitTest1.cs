using MsTesting;

namespace PurchaseTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodOnlyOne()
        {
            // Arrange
            Purches purches = new Purches();
            string inputPrices = "10 20 10 30 40 40";

            // Act
            List<string> result = purches.OnlyOnce(inputPrices);

            // Assert
            CollectionAssert.AreEqual(new List<string> { "20", "30" }, result);
        }

        [TestMethod]
        public void TestMethodOnlyOneForNull()
        {
            // Arrange
            Purches purches = new Purches();
            string inputPrices = "10 20 20 30 10 30 40 40";

            // Act
            List<string> result = purches.OnlyOnce(inputPrices);

            // Assert
            CollectionAssert.AreEqual(new List<string> { null }, result);
        }


        [TestMethod]
        public void TestMethodMoreThanOne()
        {
            // Arrange
            Purches purches = new Purches();
            string inputPrices = "10 20 10 30 40 40";

            // Act
            List<string> result = purches.moreThanOne(inputPrices);

            // Assert
            CollectionAssert.AreEqual(new List<string> { "10", "40" }, result);
        }

        [TestMethod]
        public void TestMethodMoreThanOneForNull()
        {
            // Arrange
            Purches purches = new Purches();
            string inputPrices = "10 20 30 40";

            // Act
            List<string> result = purches.moreThanOne(inputPrices);

            // Assert
            CollectionAssert.AreEqual(new List<string> { null }, result);
        }

    }
}