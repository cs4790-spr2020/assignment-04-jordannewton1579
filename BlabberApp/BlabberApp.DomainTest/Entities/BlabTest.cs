using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlabberApp.Domain;

namespace BlabberApp.DomainTest
{
    [TestClass]
    public class BlabTest
    {
        [TestMethod]
        public void TestSetGetMessage()
        {
            //Arrange
            Blab harness = new Blab();
            string expected = "This is a test";
            harness.setMessage("This is a test");

            //Act
            string actual = harness.getMessage();

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestSetGetMessageFalse()
        {
            //Arrange
            Blab harness = new Blab();
            string expected = "This is a test";
            harness.setMessage("This is a false test");

            //Act
            string actual = harness.getMessage();

            //Assert
            Assert.AreNotEqual(actual, expected);
        }

        [TestMethod]
        public void TestSetGetUserId()
        {
            //Arrange
            Blab harness = new Blab();
            string expected = "8e3e53aa-4c75-11ea-b77f-2e728ce88125";
            harness.setUserId("8e3e53aa-4c75-11ea-b77f-2e728ce88125");

            //Act
            string actual = harness.getUserId();

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestSetGetUserIdFalse()
        {
            //Arrange
            Blab harness = new Blab();
            string expected = "8e3e53aa-4c75-11ea-b77f-2e728ce88125";
            harness.setUserId("user-id-false-test-2346");

            //Act
            string actual = harness.getUserId();

            //Assert
            Assert.AreNotEqual(actual, expected);
        }

        [TestMethod]
        public void TestGetSysId()
        {
            // Arrange
            Blab harness = new Blab();
            string expected = harness.getSysId();
            // Act
            string actual = harness.getSysId();
            // Assert
            Assert.AreEqual(actual, expected);
            Assert.AreEqual(true, harness.getSysId() is string);
        }
    }
}
