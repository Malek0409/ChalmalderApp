using Chalmalder.Models;

namespace Chalmalder.DataAccess.Repository.IRepository
{
    public interface IRepositoryProduct : IRepository<Product>
    {
        void Update(Product obj);
    }
}
