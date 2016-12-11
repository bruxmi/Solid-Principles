using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid._04_LiskovSubstitutionPrinciple._03
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        public void Make_Sure_Car_Is_Painted_Correctly_Expect_Red()
        {
            //Arrange
            var car = new Car(Color.Red);
            //var car = new PimpedCar(Color.Red);
            //car.SetTemperature(25);
            //Assert
            Assert.AreEqual(Color.Red, car.Color);
        }
    }
}
