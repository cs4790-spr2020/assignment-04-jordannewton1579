using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlabberApp.Domain.Entities;

namespace BlabberApp.DomainTest.Entities
{
    [TestClass]
    public class BaseDatumTest
    {

        private BaseDatum _harness;
        public BaseDatumTest()
        {
            _harness = new BaseDatum();
        }

        [TestMethod]
        public void TestGetSysId()
        {
            // Arrange
            string expected = _harness.getSysId();
            // Act
            string actual = _harness.getSysId();
            // Assert
            Assert.AreEqual(actual.ToString(), expected.ToString());
            Assert.AreEqual(true, _harness.getSysId() is string);
        }

        [TestMethod]
        public void TestCreatedDTTM()
        {
            // Arrange
            BaseDatum Expected = new BaseDatum();
            // Act
            BaseDatum Actual = new BaseDatum();
            // Assert
            Assert.AreEqual(Expected.CreatedDTTM.ToString(), Actual.CreatedDTTM.ToString());

        }

        [TestMethod]
        public void TestModifiedDTTM()
        {
            // Arrange
            BaseDatum Expected = new BaseDatum();
            // Act
            BaseDatum Actual = new BaseDatum();
            // Assert
            Assert.AreEqual(Expected.ModifiedDTTM.ToString(), Actual.ModifiedDTTM.ToString());
        }
    }
}