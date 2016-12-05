using System;

namespace Solid._04_LiskovSubstitutionPrinciple
{
    public class Pinguine: Bird
    {
        public override void Fly()
        {
            throw new InvalidOperationException("I dont know how to fly!!!");
        }
    }
}
