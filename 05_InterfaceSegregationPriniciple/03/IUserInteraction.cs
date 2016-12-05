using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid._05_InterfaceSegregationPriniciple._03
{
    public interface IUserInteraction
    {
        bool Confirm(string message);
    }
}
