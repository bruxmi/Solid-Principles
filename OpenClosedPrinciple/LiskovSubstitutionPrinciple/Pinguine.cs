using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OpenClosedPrinciple.LiskovSubstitutionPrinciple
{
    public class Pinguine: Bird
    {
        public override void Fly()
        {
            throw new InvalidOperationException("I dont know how to fly!!!");
        }
    }
}
