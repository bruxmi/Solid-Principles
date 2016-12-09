using System;
using System.Collections.Generic;
using Solid._02_SingleResponsibilityPrinciple._03.Interafaces;

namespace Solid._05_InterfaceSegregationPriniciple._01
{
    public class CrudLogging<TEntity>: ICreateReadUpdateDelete<TEntity>
    {
        private readonly ICreateReadUpdateDelete<TEntity> _decoratedCrud;
        private readonly ILogger _logger;

        public CrudLogging(ICreateReadUpdateDelete<TEntity> decoratedCrud, ILogger logger)
        {
            _decoratedCrud = decoratedCrud;
            _logger = logger;
        }

        public void Create(TEntity entity)
        {
            this._logger.LogWarning("Creating entity of type {0}", typeof(TEntity).Name);
            this._decoratedCrud.Create(entity);
        }

        public TEntity ReadOne(Guid identity)
        {
            this._logger.LogWarning("Reading entity of type {0} with identity {1}" , typeof(TEntity).Name, identity);
            return this._decoratedCrud.ReadOne(identity);
        }

        public IEnumerable<TEntity> ReadAll()
        {
            this._logger.LogWarning("Reading  all entities of type {0} with identity {1}", typeof(TEntity).Name);
            return this._decoratedCrud.ReadAll();
        }

        public void Update(TEntity entity)
        {
            this._logger.LogWarning("Updating entity of type {0}", typeof(TEntity).Name);
            this._decoratedCrud.Create(entity);
        }

        public void Delete(TEntity entity)
        {
            this._logger.LogWarning("Deleting entity of type {0}", typeof(TEntity).Name);
            this._decoratedCrud.Delete(entity);
        }
    }
}
