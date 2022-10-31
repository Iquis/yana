// using System.Threading.Tasks;
// using Microsoft.Data.Sqlite;
// using Xunit;
// using yana.Core.Configuration;
// using yana.Core.Configuration.Implementations;
// using yana.Core.Dao;
// using yana.Core.Dao.Implementations;
//
// namespace yana.Tests;
//
// public class SQLiteDaoTests : IClassFixture<DatabaseFixture>
// {
//     private readonly ISQLiteDao _sqLiteDao;
//
//     public SQLiteDaoTests()
//     {
//         IDatabaseConfiguration databaseConfiguration =
//             new DatabaseConfiguration()
//             {
//                 ConnectionString = "Data Source=test.db"
//             };
//         this._sqLiteDao = new SQLiteDao(databaseConfiguration);
//     }
//
//
//     [Fact]
//     public async Task ShouldReturnSubscriptions()
//     {
//
//         var result = await _sqLiteDao.GetSubscriptions();
//         
//         Assert.Empty(result);
//     }
// }