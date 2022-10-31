using Dapper;
using Microsoft.Data.Sqlite;
using yana.Core.Configuration;

namespace yana.Core.Dao.Implementations;

public class SQLiteDao : ISQLiteDao
{

    private readonly IDatabaseConfiguration _databaseConfiguration;
    public SQLiteDao(IDatabaseConfiguration databaseConfiguration)
    {
        _databaseConfiguration = databaseConfiguration;
    }
    public Task<IEnumerable<string>> GetSubscriptions()
    {

        using var connection = new SqliteConnection(_databaseConfiguration.ConnectionString);
        
        connection.Open();
        
        
        
        
        throw new NotImplementedException();
    }
}