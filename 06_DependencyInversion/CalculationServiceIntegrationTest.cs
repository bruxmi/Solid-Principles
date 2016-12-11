using System.Net.Http.Headers;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using Solid._06_DependencyInversion.Bootstrap;
using Solid._06_DependencyInversion.Implementations;
using Solid._06_DependencyInversion.Interfaces;

namespace Solid._06_DependencyInversion
{
    [TestClass]
    public class CalculationServiceIntegrationTest: BaseForIntegrationTest 
    {
        [TestMethod]
        public void AddTenAndSubstractTwenty_InputNumberIsFifteen_Expect_Forty_BadPractice()
        {
            //Arrange
            var calculationService = Container.Resolve<ICalculate>();

            //Act
            var actual = calculationService.AddTenAndSubstractTwenty(50);

            //Assert
            Assert.AreEqual(40, actual);
        }
    }
}
