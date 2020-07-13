using System;
using System.Collections.Generic;
using BulkyBook.DataAccess.Data;
using BulkyBook.DataAccess.Repository.IRepository;
using Dapper;
using Microsoft.EntityFrameworkCore;

namespace BulkyBook.DataAccess.Repository
{
    public class StoredProcedureCall:IStoredProcedureCall
    {

        ApplicationDbContext _db;
        string _connectionString;
        public StoredProcedureCall(ApplicationDbContext db)
        {
          _db = db;
            _connectionString = db.Database.GetDbConnection().ConnectionString;
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Execute(string prcedureName, DynamicParameters parameters = null)
        {
            //using (SqlConnection sqlCon = new SqlConnection(_connectionString))
            //{

            //}
        }

        public IEnumerable<T> List<T>(string prcedureName, DynamicParameters parameters = null)
        {
            throw new NotImplementedException();
        }

        public Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string prcedureName, DynamicParameters parameters = null)
        {
            throw new NotImplementedException();
        }

        public T OneRecord<T>(string prcedureName, DynamicParameters parameters = null)
        {
            throw new NotImplementedException();
        }

        public T Single<T>(string prcedureName, DynamicParameters parameters = null)
        {
            throw new NotImplementedException();
        }
    }
}
