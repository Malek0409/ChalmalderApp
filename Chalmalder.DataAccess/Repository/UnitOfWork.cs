using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chalmalder.DataAccess.Data;
using Chalmalder.DataAccess.Repository.IRepository;

namespace Chalmalder.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public IRepositoryCategory Category { get; private set; }
        public IRepositoryProduct Product { get; private set; }
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new RepositoryCategory(_db);
            Product = new RepositoryProduct(_db);
        }




        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
