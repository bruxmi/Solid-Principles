using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid._04_LiskovSubstitutionPrinciple._02
{
    public class ElectricDuck : IDuck
    {
        private bool _isSwimming;
        private bool _isTurnedOn;

        public bool IsSwimming => this._isSwimming;
        public bool IsTurnedOn => this._isTurnedOn;

        public void TurnOn()
        {
            this._isTurnedOn = true;
        }

        public void Swim()
        {
            if (!IsTurnedOn)
                throw new InvalidOperationException();

            _isSwimming = true;
        }
    }
}
