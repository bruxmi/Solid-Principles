using System;
using System.Collections.Generic;
using System.Transactions;

namespace Solid._05_InterfaceSegregationPriniciple._01
{
    public class CrudTransactional<TEntity> : ICreateReadUpdateDelete<TEntity>
    {
        private readonly ICreateReadUpdateDelete<TEntity> _decoratedCrud;

        public CrudTransactional(ICreateReadUpdateDelete<TEntity> decoratedCrud)
        {
            _decoratedCrud = decoratedCrud;
        }

        public void Create(TEntity entity)
        {
            using (var transaction = new TransactionScope())
            {
                this._decoratedCrud.Create(entity);
                transaction.Complete();
            }
        }

        public TEntity ReadOne(Guid identity)
        {
            TEntity entity;
            using (var transaction = new TransactionScope())
            {
                entity = this._decoratedCrud.ReadOne(identity);
                transaction.Complete();
            }
            return entity;
        }

        public IEnumerable<TEntity> ReadAll()
        {
            IEnumerable<TEntity> entities;
            using (var transaction = new TransactionScope())
            {
                entities = this._decoratedCrud.ReadAll();
                transaction.Complete();
            }
            return entities;
        }

        public void Update(TEntity entity)
        {
            using (var transaction = new TransactionScope())
            {
                this._decoratedCrud.Update(entity);
                transaction.Complete();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var transaction = new TransactionScope())
            {
                this._decoratedCrud.Delete(entity);
                transaction.Complete();
            }
        }
    }
}

