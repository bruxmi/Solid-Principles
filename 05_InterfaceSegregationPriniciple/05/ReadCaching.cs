using System;
using System.Collections.Generic;

namespace Solid._05_InterfaceSegregationPriniciple._05
{
    public class ReadCaching<TEntity>: IRead<TEntity>
    {
        private readonly IRead<TEntity> _decoratedRead;
        private IEnumerable<TEntity> _allCachedEntities;
        private TEntity _cachedEntity;

        public ReadCaching(IRead<TEntity> decoratedRead)
        {
            _decoratedRead = decoratedRead;
        }

        public TEntity ReadOne(Guid identity)
        {
            if (this._cachedEntity == null)
            {
                this._cachedEntity = this._decoratedRead.ReadOne(identity);
            }
            return this._cachedEntity;
        }

        public IEnumerable<TEntity> ReadAll()
        {
            if (this._allCachedEntities == null)
            {
                this._allCachedEntities = this._decoratedRead.ReadAll();
            }
            return this._allCachedEntities;
        }
    }
}
