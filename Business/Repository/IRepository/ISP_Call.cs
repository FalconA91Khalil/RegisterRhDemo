using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Repository.IRepository
{
    public interface ISP_Call : IDisposable
    {
        public IEnumerable<T> ReturnList<T>(string procedureName, DynamicParameters parameters = null);
        void ExecuteWithoutReturn(string procedureName, DynamicParameters parameters = null);
        T ExecuteReturnScalar<T>(string procedureName, DynamicParameters parameters = null);
    }
}
