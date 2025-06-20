using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chalmalder.DataAccess.Data;
using Chalmalder.DataAccess.Repository.IRepository;
using Chalmalder.Models;

namespace Chalmalder.DataAccess.Repository
{
    public class RepositoryProduct : Repository<Product>, IRepositoryProduct
    {
        private readonly ApplicationDbContext _db;

        public RepositoryProduct(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product obj)
        {
            var objFromDb = _db.Products.FirstOrDefault(p => p.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Title = obj.Title;
                objFromDb.Description = obj.Description;
                objFromDb.ISBN = obj.ISBN;
                objFromDb.Author = obj.Author;
                objFromDb.ListPrice = obj.ListPrice;
                objFromDb.Price = obj.Price;
                objFromDb.Price50 = obj.Price50;
                objFromDb.Price100 = obj.Price100;
                objFromDb.CategoryId = obj.CategoryId;

                if (!string.IsNullOrEmpty(obj.ImageUrl))
                {
                    objFromDb.ImageUrl = obj.ImageUrl;
                }
            }
        }
    }
}
