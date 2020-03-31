using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlabberApp.DataStore;
using BlabberApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlabberApp.DataStoreTest
{
    [TestClass]
    public class InMemoryTest
    {
        private InMemory<Blab> _harness;

        public InMemoryTest()
        {
            var options = new DbContextOptionsBuilder<ApplicationContext>()
                             .UseInMemoryDatabase(databaseName: "Add_writes")
                             .Options;
            _harness = new InMemory<Blab>(new ApplicationContext(options));
        }

        [TestMethod]
        public void Add_Blab_GetByUserId_Success()
        {
            //Arrange
            string Email = "test@example.com";
            Blab Expected = new Blab();
            Expected.Message = "The standard chunk of Lorem Ipsum used below.";
            Expected.UserID = Email;
            var sysId = Expected.getSysId();
            _harness.Add(Expected);
            // Act
            Blab Actual = (Blab)_harness.GetByUserId(Email);
            // Assert
            Assert.AreEqual(Expected, Actual);
        }
    }
}
