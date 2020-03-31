using BlabberApp.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BlabberApp.DomainTest.Entities
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void TestSetGetEmail_Success()
        {
            // Arrange
            User harness = new User();
            string expected = "example@example.com";
            harness.ChangeEmail("example@example.com");
            // Act
            string actual = harness.Email; // Assert
            Assert.AreEqual(actual.ToString(), expected.ToString());
        }
        [TestMethod]
        public void TestSetGetEmail_Fail00()
        {
            // Arrange
            User harness = new User();
            // Act
            var ex = Assert.ThrowsException<FormatException>(() => harness.ChangeEmail("ExamPLE"));
            // Assert
            Assert.AreEqual("Email is invalid", ex.Message.ToString());
        }
        [TestMethod]
        public void TestSetGetEmail_Fail01()
        {
            // Arrange
            User harness = new User();
            // Act
            var ex = Assert.ThrowsException<FormatException>(() => harness.ChangeEmail("example.com"));
            // Assert
            Assert.AreEqual("Email is invalid", ex.Message.ToString());
        }
        [TestMethod]
        public void TestSetGetEmail_Fail02()
        {
            // Arrange
            User harness = new User();
            // Act
            var ex = Assert.ThrowsException<FormatException>(() => harness.ChangeEmail("ExamPLE.example"));
            // Assert
            Assert.AreEqual("Email is invalid", ex.Message.ToString());
        }
        [TestMethod]
        public void TestGetSysId()
        {
            // Arrange
            User harness = new User();
            string expected = harness.getSysId();
            // Act
            string actual = harness.getSysId();
            // Assert
            Assert.AreEqual(actual.ToString(), expected.ToString());
            Assert.AreEqual(true, harness.getSysId() is string);
        }
    }
}