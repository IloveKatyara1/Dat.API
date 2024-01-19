namespace Dat.API.Utils.Interfaces
{
    public interface IService<T> where T : class
    {
        public Task<IEnumerable<T>> GetAll();
        public Task<T> GetById(Guid id);
        public Task<T> Insert(T entity);
        public Task<T> Put(T entity);
        public Task<bool> Delete(Guid id);
    }
}
