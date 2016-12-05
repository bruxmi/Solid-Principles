using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid._05_InterfaceSegregationPriniciple._02;
using Solid._05_InterfaceSegregationPriniciple._05;
using Solid._05_InterfaceSegregationPriniciple._06;

namespace Solid._05_InterfaceSegregationPriniciple._07
{
    public class CreateReadUpdateDelete<TEntity>: IRead<TEntity>, ISave<TEntity>, IDelete<TEntity>
    {
        private readonly IRead<TEntity> _decoratedRead;
        private readonly ISave<TEntity> _decoratedSave;
        private readonly IDelete<TEntity> _decoratedDelete;

        public CreateReadUpdateDelete(IRead<TEntity> decoratedRead, ISave<TEntity> decoratedSave, IDelete<TEntity> decoratedDelete)
        {
            _decoratedRead = decoratedRead;
            _decoratedSave = decoratedSave;
            _decoratedDelete = decoratedDelete;
        }

        public TEntity ReadOne(Guid identity)
        {
            return this._decoratedRead.ReadOne(identity);
        }

        public IEnumerable<TEntity> ReadAll()
        {
            return this._decoratedRead.ReadAll();
        }

        public void Save(TEntity entity)
        {
            this._decoratedSave.Save(entity);
        }

        public void Delete(TEntity entity)
        {
            this._decoratedDelete.Delete(entity);
        }
    }
}
