using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid._04_LiskovSubstitutionPrinciple._01
{
    [TestClass]
    public class DuckUnitTest
    {
        [TestMethod]
        public void Swim_When_A_Duck_Swims_IsSwimming_Should_Be_True()
        {
            //Arrange
            var organicDuck = new OrganicDuck();
            //var electricDuck = new ElectricDuck();
            
            //Act
            //electricDuck.TurnOn();
            this.LetTheDuckSwim(organicDuck);

            //Assert
            Assert.IsTrue(organicDuck.IsSwimming);
        }

        private void LetTheDuckSwim(IDuck duck)
        {
            duck.Swim();
        }
    }
}
