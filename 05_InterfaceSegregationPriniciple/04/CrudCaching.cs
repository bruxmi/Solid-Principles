using System;
using System.Collections.Generic;

namespace Solid._05_InterfaceSegregationPriniciple._04
{
    public class CrudCaching<TEntity> : ICreateReadUpdate<TEntity>
    {
        private TEntity _cachedEntity;
        private IEnumerable<TEntity> _allCachedEntities;
        private readonly ICreateReadUpdate<TEntity> _decorated;

        public CrudCaching(ICreateReadUpdate<TEntity> decorated)
        {
            _decorated = decorated;
        }
        public void Create(TEntity entity)
        {
            this._decorated.Create(entity);
        }
        public TEntity ReadOne(Guid identity)
        {
            if (this._cachedEntity == null)
            {
                this._cachedEntity = this._decorated.ReadOne(identity);
            }
            return this._cachedEntity;
        }

        public IEnumerable<TEntity> ReadAll()
        {
            if (this._allCachedEntities == null)
            {
                this._allCachedEntities = this._decorated.ReadAll();
            }
            return this._allCachedEntities;
        }


        public void Update(TEntity entity)
        {
            this._decorated.Update(entity);
        }
    }
}
