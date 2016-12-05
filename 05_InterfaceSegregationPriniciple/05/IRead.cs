using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid._05_InterfaceSegregationPriniciple._05
{
    public interface IRead<TEntity>
    {
        TEntity ReadOne(Guid identity);

        IEnumerable<TEntity> ReadAll();
    }
}
