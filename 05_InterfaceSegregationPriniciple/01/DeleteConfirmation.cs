using System;
using System.Collections.Generic;

namespace Solid._05_InterfaceSegregationPriniciple._01
{
    public class DeleteConfirmation<TEntity> : ICreateReadUpdateDelete<TEntity>
    {
        private readonly ICreateReadUpdateDelete<TEntity> _decoratedCrud;

        public DeleteConfirmation(ICreateReadUpdateDelete<TEntity> decoratedCrud)
        {
            _decoratedCrud = decoratedCrud;
        }

        public void Create(TEntity entity)
        {
            this._decoratedCrud.Create(entity);
        }

        public TEntity ReadOne(Guid identity)
        {
            return this._decoratedCrud.ReadOne(identity);
        }

        public IEnumerable<TEntity> ReadAll()
        {
            return this._decoratedCrud.ReadAll();
        }

        public void Update(TEntity entity)
        {
            this._decoratedCrud.Update(entity);
        }

        /// <summary>
        /// DeleteConfirmation decorates only the delete method.
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(TEntity entity)
        {
            Console.WriteLine("Are you sure you want to delete the entity? [Y/N]");
            var keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.Y)
            {
                this._decoratedCrud.Delete(entity);
            }
        }
    }
}
