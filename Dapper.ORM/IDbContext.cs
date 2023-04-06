using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Dapper.ORM
{
    public interface IDbContext
    {
        IEnumerable<T> Query<T>(string query, object data = null, IDbTransaction transaction = null,
            int? commandTimeOut = null, CommandType? commandType = null);

        Task<IEnumerable<T>> QueryAsync<T>(string query, object data = null, IDbTransaction transaction = null,
            int? commandTimeOut = null, CommandType? commandType = null);

        T QueryFirst<T>(string query, object data = null, IDbTransaction transaction = null, int? commandTimeOut = null,
            CommandType? commandType = null);

        Task<T> QueryFirstAsync<T>(string query, object data = null, IDbTransaction transaction = null,
            int? commandTimeOut = null, CommandType? commandType = null);

        T QuerySingle<T>(string query, object data = null, IDbTransaction transaction = null,
            int? commandTimeOut = null, CommandType? commandType = null);

        Task<T> QuerySingleAsync<T>(string query, object data = null, IDbTransaction transaction = null,
            int? commandTimeOut = null, CommandType? commandType = null);

        T QueryFirstOrDefault<T>(string query, object data = null, IDbTransaction transaction = null,
            int? commandTimeOut = null, CommandType? commandType = null);

        Task<T> QueryFirstOrDefaultAsync<T>(string query, object data = null, IDbTransaction transaction = null,
            int? commandTimeOut = null, CommandType? commandType = null);

        T QuerySingleOrDefault<T>(string query, object data = null, IDbTransaction transaction = null,
            int? commandTimeOut = null, CommandType? commandType = null);

        Task<T> QuerySingleOrDefaultAsync<T>(string query, object data = null, IDbTransaction transaction = null,
            int? commandTimeOut = null, CommandType? commandType = null);

        SqlMapper.GridReader QueryMultiple(string query, object data = null, IDbTransaction transaction = null,
            int? commandTimeOut = null, CommandType? commandType = null);

        Task<SqlMapper.GridReader> QueryMultipleAsync(string query, object data = null,
            IDbTransaction transaction = null, int? commandTimeOut = null, CommandType? commandType = null);

        int Execute(string query, object data = null, IDbTransaction transaction = null, int? commandTimeOut = null,
            CommandType? commandType = null);

        Task<int> ExecuteAsync(string query, object data = null, IDbTransaction transaction = null,
            int? commandTimeOut = null, CommandType? commandType = null);

        IDataReader ExecuteReader(string query, object data = null, IDbTransaction transaction = null,
            int? commandTimeOut = null, CommandType? commandType = null);

        Task<IDataReader> ExecuteReaderAsync(string query, object data = null, IDbTransaction transaction = null,
            int? commandTimeOut = null, CommandType? commandType = null);

        object ExecuteScalar(string query, object data = null, IDbTransaction transaction = null, int? commandTimeOut = null,
            CommandType? commandType = null);

        Task<object> ExecuteScalarAsync(string query, object data = null, IDbTransaction transaction = null,
            int? commandTimeOut = null, CommandType? commandType = null);
    }
}
