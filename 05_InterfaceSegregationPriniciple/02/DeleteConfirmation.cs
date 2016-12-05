using System;

namespace Solid._05_InterfaceSegregationPriniciple._02
{
    public class DeleteConfirmation<TEntity>: IDelete<TEntity>
    {
        private readonly IDelete<TEntity> _decoratedDelete;

        public DeleteConfirmation(IDelete<TEntity> decoratedDelete)
        {
            _decoratedDelete = decoratedDelete;
        }

        /// <summary>
        /// It does less but still to many things. Single Responsiblity Principle is broken!
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(TEntity entity)
        {
            Console.WriteLine("Are you sure you want to delete the entity? [Y/N]");
            var keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.Y)
            {
                this._decoratedDelete.Delete(entity);
            }
        }
    }
}
