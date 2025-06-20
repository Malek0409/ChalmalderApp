using Chalmalder.DataAccess.Data;
using Chalmalder.DataAccess.Repository.IRepository;
using Chalmalder.Models;

namespace Chalmalder.DataAccess.Repository
{
    public class RepositoryCategory : Repository<Category>, IRepositoryCategory
    {
        private readonly ApplicationDbContext _db;

        public RepositoryCategory(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }


        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }

    }
}
