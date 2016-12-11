using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid._04_LiskovSubstitutionPrinciple._03
{
    public class PimpedCar : Car
    {
        public PimpedCar(Color color) : base(color)
        {

        }

        public void SetTemperature(int degrees)
        {
            if (degrees > 20)
            {
                Color = Color.Black;
            }
        }
    }
}
