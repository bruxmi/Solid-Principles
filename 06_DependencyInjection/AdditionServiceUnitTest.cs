﻿using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solid._06_DependencyInjection.Bootstrap;
using Solid._06_DependencyInjection.Interafaces;

namespace Solid._06_DependencyInjection
{
    [TestClass]
    public class AdditionServiceUnitTest: BaseForUnitTest
    {

        [TestMethod]
        public void Add_TenToTen_Expect_Twenty()
        {
            //Arrange
            var additionService = Container.Resolve<IAdd>();

            //Act
            var actual = additionService.Add(10, 10);

            //Assert
            Assert.AreEqual(20, actual);
        }
    }
}