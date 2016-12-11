using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solid._06_DependencyInversion.Bootstrap;
using Solid._06_DependencyInversion.Implementations;
using Solid._06_DependencyInversion.Interfaces;

namespace Solid._06_DependencyInversion
{
    [TestClass]
    public class AdditionServiceUnitTest
    {

        [TestMethod]
        public void Add_TenToTen_Expect_Twenty()
        {
            //Arrange
            var additionService = new AdditionServiceCorrect();

            //Act
            var actual = additionService.Add(10, 10);

            //Assert
            Assert.AreEqual(20, actual);
        }
    }
}
