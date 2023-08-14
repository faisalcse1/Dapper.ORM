using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading.Tasks;

namespace Dapper.ORM
{
    public class MySqlContext:IDbContext
    {
        private string connectionString;
        public MySqlContext(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public IEnumerable<T> Query<T>(string query, object data = null, IDbTransaction transaction = null, int? commandTimeOut = null, CommandType? commandType = null)
        {
            using(MySqlConnection con = new MySqlConnection(connectionString))
            {
                return con.Query<T>(query, data, transaction, true, commandTimeOut, commandType);
            }            
        }
        public async Task<IEnumerable<T>> QueryAsync<T>(string query, object data = null, IDbTransaction transaction = null, int? commandTimeOut = null, CommandType? commandType = null)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                return await con.QueryAsync<T>(query, data, transaction, commandTimeOut, commandType);
            }            
        }

        public T QueryFirst<T>(string query, object data = null, IDbTransaction transaction = null, int? commandTimeOut = null, CommandType? commandType = null)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                return con.QueryFirst<T>(query, data, transaction, commandTimeOut, commandType);
            }            
        }

        public async Task<T> QueryFirstAsync<T>(string query, object data = null, IDbTransaction transaction = null, int? commandTimeOut = null, CommandType? commandType = null)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                return await con.QueryFirstAsync<T>(query, data, transaction, commandTimeOut, commandType);
            }            
        }

        public T QuerySingle<T>(string query, object data = null, IDbTransaction transaction = null, int? commandTimeOut = null, CommandType? commandType = null)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                return con.QuerySingle<T>(query, data, transaction, commandTimeOut, commandType);
            }            
        }
        public async Task<T> QuerySingleAsync<T>(string query, object data = null, IDbTransaction transaction = null, int? commandTimeOut = null, CommandType? commandType = null)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                return await con.QuerySingleAsync<T>(query, data, transaction, commandTimeOut, commandType);
            }            
        }

        public T QueryFirstOrDefault<T>(string query, object data = null, IDbTransaction transaction = null, int? commandTimeOut = null, CommandType? commandType = null)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                return con.QueryFirstOrDefault<T>(query, data, transaction, commandTimeOut, commandType);
            }
            
        }
        public async Task<T> QueryFirstOrDefaultAsync<T>(string query, object data = null, IDbTransaction transaction = null, int? commandTimeOut = null, CommandType? commandType = null)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                return await con.QueryFirstOrDefaultAsync<T>(query, data, transaction, commandTimeOut, commandType);
            }            
        }

        public T QuerySingleOrDefault<T>(string query, object data = null, IDbTransaction transaction = null, int? commandTimeOut = null, CommandType? commandType = null)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                return con.QuerySingleOrDefault<T>(query, data, transaction, commandTimeOut, commandType);
            }            
        }
        public async Task<T> QuerySingleOrDefaultAsync<T>(string query, object data = null, IDbTransaction transaction = null, int? commandTimeOut = null, CommandType? commandType = null)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                return await con.QuerySingleOrDefaultAsync<T>(query, data, transaction, commandTimeOut, commandType);
            }            
        }

        public SqlMapper.GridReader QueryMultiple(string query, object data = null, IDbTransaction transaction = null, int? commandTimeOut = null, CommandType? commandType = null)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                return con.QueryMultiple(query, data, transaction, commandTimeOut, commandType);
            }            
        }
        public async Task<SqlMapper.GridReader> QueryMultipleAsync(string query, object data = null, IDbTransaction transaction = null, int? commandTimeOut = null, CommandType? commandType = null)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                return await con.QueryMultipleAsync(query, data, transaction, commandTimeOut, commandType);
            }            
        }

        public int Execute(string query, object data = null, IDbTransaction transaction = null, int? commandTimeOut = null, CommandType? commandType = null)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                return con.Execute(query, data, transaction, commandTimeOut, commandType);
            }            
        }
        public async Task<int> ExecuteAsync(string query, object data = null, IDbTransaction transaction = null, int? commandTimeOut = null, CommandType? commandType = null)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                return await con.ExecuteAsync(query, data, transaction, commandTimeOut, commandType);
            }            
        }

        public IDataReader ExecuteReader(string query, object data = null, IDbTransaction transaction = null, int? commandTimeOut = null, CommandType? commandType = null)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                return con.ExecuteReader(query, data, transaction, commandTimeOut, commandType);
            }            
        }
        public async Task<IDataReader> ExecuteReaderAsync(string query, object data = null, IDbTransaction transaction = null, int? commandTimeOut = null, CommandType? commandType = null)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                return await con.ExecuteReaderAsync(query, data, transaction, commandTimeOut, commandType);
            }            
        }

        public object ExecuteScalar(string query, object data = null, IDbTransaction transaction = null, int? commandTimeOut = null, CommandType? commandType = null)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                return con.ExecuteScalar(query, data, transaction, commandTimeOut, commandType);
            }            
        }
        public async Task<object> ExecuteScalarAsync(string query, object data = null, IDbTransaction transaction = null, int? commandTimeOut = null, CommandType? commandType = null)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                return await con.ExecuteScalarAsync(query, data, transaction, commandTimeOut, commandType);
            }            
        }
    }
}
