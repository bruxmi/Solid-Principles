using System.Net.Http.Headers;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using Solid._06_DependencyInjection.Bootstrap;
using Solid._06_DependencyInjection.Implementations;
using Solid._06_DependencyInjection.Interafaces;

namespace Solid._06_DependencyInjection
{
    [TestClass]
    public class CalculationServiceUnitTest 
    {
        //[TestMethod]
        //public void AddTenAndSubstractTwenty_InputNumberIsFifteen_Expect_Forty()
        //{
        //    //Arrange
        //    var inputNumber = 50;
        //    var additionService = Substitute.For<IAdd>();
        //    var substractionService = Substitute.For<ISubstract>();
        //    var calculationService = new CalculationService(additionService, substractionService);

        //    additionService.Add(inputNumber, Arg.Any<int>()).Returns(inputNumber + 10);
        //    substractionService.Substract(Arg.Any<int>(), Arg.Any<int>()).Returns(inputNumber + 10 - 20);

        //    //Act
        //    var actual = calculationService.AddTenAndSubstractTwenty(inputNumber);

        //    //Assert
        //    additionService.Received().Add(Arg.Any<int>(), Arg.Any<int>());
        //    substractionService.Received().Substract(Arg.Any<int>(), Arg.Any<int>());
        //    Assert.AreEqual(40, actual);
        //}

        [TestMethod]
        public void AddTenAndSubstractTwenty_InputNumberIsFifteen_Expect_Forty_BadPractice()
        {
            //Arrange
            var calculationService = new CalculationService();

            //Act
            var actual = calculationService.AddTenAndSubstractTwenty(50);

            //Assert
            Assert.AreEqual(40, actual);
        }
    }
}
