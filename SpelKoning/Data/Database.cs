using System;
using SQLite;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SpelKoning.Data
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Account>().Wait();
        }

        public Task<List<Account>> GetAccountsAsync()
        {
            return _database.Table<Account>().ToListAsync();
        }

        public Task<int> SavePersonAsync(Account account)
        {
            return _database.InsertAsync(account);
        }
    }
}
