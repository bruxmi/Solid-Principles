using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid._04_LiskovSubstitutionPrinciple._02
{
    [TestClass]
    public class DuckUnitTest
    {
        [TestMethod]
        public void Swim_When_A_Duck_Swims_IsSwimming_Should_Be_True()
        {
            //Arrange
            var electricDuck = new ElectricDuck();
            
            //Act
            this.LetTheDuckSwim(electricDuck);

            //Assert
            Assert.IsTrue(electricDuck.IsSwimming);
        }

        private void LetTheDuckSwim(IDuck duck)
        {
            duck.Swim();
        }
    }
}
