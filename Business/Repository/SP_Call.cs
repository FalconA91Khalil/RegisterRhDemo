using Business.Repository.IRepository;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Persistance;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Business.Repository
{
    public class SP_Call : ISP_Call
    {
        private readonly ApplicationDbContext _dbContext;
        private static string ConnectionString = string.Empty;

        public SP_Call(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            ConnectionString = _dbContext.Database.GetDbConnection().ConnectionString;
        }
        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public T ExecuteReturnScalar<T>(string procedureName, DynamicParameters parameters = null)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                return (T)Convert.ChangeType(sqlConnection.ExecuteScalar<T>(procedureName, parameters, commandType: CommandType.StoredProcedure), typeof(T));
            }
        }

        public void ExecuteWithoutReturn(string procedureName, DynamicParameters parameters = null)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                sqlConnection.Execute(procedureName, parameters, commandType: CommandType.StoredProcedure); ;
            }
        }

        public IEnumerable<T> ReturnList<T>(string procedureName, DynamicParameters parameters = null)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                return sqlConnection.Query<T>(procedureName, parameters, commandType: CommandType.StoredProcedure); ;
            }
        }
    }

}
