using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solid._06_DependencyInjection.Bootstrap;
using Solid._06_DependencyInjection.Implementations;
using Solid._06_DependencyInjection.Interafaces;

namespace Solid._06_DependencyInjection
{
    [TestClass]
    public class SubstractionServiceUnitTest
    {
        [TestMethod]
        public void Substract_TenFromTwenty_Expect_Ten()
        {
            //Arrange
            var substractionService = new SubstractionService();

            //Act
            var actual = substractionService.Substract(20, 10);

            //Assert
            Assert.AreEqual(10, actual);
        }
    }
}
