using System;
using Solid._05_InterfaceSegregationPriniciple._02;

namespace Solid._05_InterfaceSegregationPriniciple._03
{
    public class DeleteConfirmation<TEntity>: IDelete<TEntity>
    {
        private readonly IDelete<TEntity> _decoratedDelete;
        private readonly IUserInteraction _userInteraction;

        public DeleteConfirmation(IDelete<TEntity> decoratedDelete, IUserInteraction userInteraction)
        {
            _decoratedDelete = decoratedDelete;
            _userInteraction = userInteraction;
        }

        public void Delete(TEntity entity)
        {
            if (this._userInteraction.Confirm("Are you sure you want to delete the entity? [Y/N]"))
            {
                this._decoratedDelete.Delete(entity);
            }
        }
    }
}
