using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid._04_LiskovSubstitutionPrinciple._01
{
    public interface IDuck
    {
        void Swim();

        // contract says that IsSwimming should be true if Swim has been called.
        bool IsSwimming { get; }
    }
}
