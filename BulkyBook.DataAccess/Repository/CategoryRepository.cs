using System;
using System.Linq;
using BulkyBook.DataAccess.Data;
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;

namespace BulkyBook.DataAccess.Repository
{
    public class CategoryRepository:Repository<Category>,ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }

        public void Update(Category item)
        {
            var dbObject = _db.Categories.FirstOrDefault(s => s.Id == item.Id);
            if (dbObject == null)
                return;
            dbObject.Name = item.Name;
            _db.SaveChanges();
        }
    }
}
