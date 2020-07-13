using System;
using BulkyBook.DataAccess.Data;
using BulkyBook.DataAccess.Repository.IRepository;

namespace BulkyBook.DataAccess.Repository
{
    public class UnitOfWork:IUnitOfWork
    {
        public ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            StoredProcedureCall = new StoredProcedureCall(_db);


        }

        public ICategoryRepository Category { get; private set; }

        public IStoredProcedureCall StoredProcedureCall { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
