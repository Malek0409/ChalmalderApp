using Chalmalder.Models;

namespace Chalmalder.DataAccess.Repository.IRepository
{
    public interface IRepositoryCategory : IRepository<Category>
    {
        void Update(Category obj);
    }
}
