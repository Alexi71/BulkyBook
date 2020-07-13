using System;
using System.Collections.Generic;
using Dapper;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IStoredProcedureCall:IDisposable
    {
        T Single<T>(string prcedureName, DynamicParameters parameters = null);

        void Execute(string prcedureName, DynamicParameters parameters = null);

        T OneRecord<T> (string prcedureName, DynamicParameters parameters = null);

        IEnumerable<T> List<T>(string prcedureName, DynamicParameters parameters = null);
        Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1,T2>(string prcedureName, DynamicParameters parameters = null);
    }
}
