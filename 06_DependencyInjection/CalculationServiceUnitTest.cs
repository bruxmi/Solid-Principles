using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solid._06_DependencyInjection.Bootstrap;
using Solid._06_DependencyInjection.Interafaces;

namespace Solid._06_DependencyInjection
{
    [TestClass]
    public class CalculationServiceUnitTest
    {
        private readonly IUnityContainer _container;

        public CalculationServiceUnitTest()
        {
            _container = new UnityContainer();
            _container.InitializeStub();
        }

        [TestMethod]
        public void AddTenAndSubstractTwenty_InputNumberIsFifteen_Expect_Forty()
        {
            //Arrange
            var calculationService = this._container.Resolve<ICalculate>();

            //Act
            var actual = calculationService.AddTenAndSubstractTwenty(50);

            //Assert
            Assert.AreEqual(40, actual);
        }
    }
}
