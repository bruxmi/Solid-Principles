using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid._04_LiskovSubstitutionPrinciple._01
{
    public class OrganicDuck : IDuck
    {
        private bool _isSwimming;

        public bool IsSwimming { get { return this._isSwimming; } }

        public void Swim()
        {
            this._isSwimming = true;
        }
    }
}
