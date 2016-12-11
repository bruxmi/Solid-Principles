﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid._04_LiskovSubstitutionPrinciple._03
{
    public class Car
    {
        public Car(Color color)
        {
            this.Color = color;
        }
        public Color Color { get; protected set; }
    }
}
