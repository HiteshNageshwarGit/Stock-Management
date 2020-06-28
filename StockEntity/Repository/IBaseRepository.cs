namespace StockEntity.DataEntity
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entityToUpdate);
        void Delete(TEntity entityToDelete);
        void Delete(int id);
        TEntity GetByID(object id);
    }
}
