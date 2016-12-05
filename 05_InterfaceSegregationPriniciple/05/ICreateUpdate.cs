using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid._05_InterfaceSegregationPriniciple._05
{
    /// <summary>
    /// Thats all what is left.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface ICreateUpdate<TEntity>
    {
        void Create(TEntity entity);

        void Update(TEntity entity);
    }
}
