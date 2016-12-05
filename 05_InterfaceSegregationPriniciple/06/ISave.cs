using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid._05_InterfaceSegregationPriniciple._06
{
    public interface ISave<TEntity>
    {
        void Save(TEntity entity);
    }
}
