namespace Solid._05_InterfaceSegregationPriniciple._02
{
    public interface IDelete<TEntity>
    {
        void Delete(TEntity entity);
    }
}
