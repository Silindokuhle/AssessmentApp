using Prism.Commands;
using Prism.Mvvm;
using ProjectAssessment.Model;

using ProjectAssessment.Services.Interfaces;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAssessment.Services
{
    public class SafetyDatabase : IDatabase
    {
        readonly SQLiteAsyncConnection database;

        public SafetyDatabase()
        {
            string dbPath = GetDbPath();
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<User>().Wait();
        }
        private string GetDbPath()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),  "safety.db3");
        }
        
        public Task<List<User>> GetItemsAsync()
        {
            return database.Table<User>().ToListAsync();
        }

        public async Task<User> GetUserByUserName(string userName)
        {
            return await database.Table<User>().Where(x => x.Username == userName).FirstOrDefaultAsync();
        }
        public Task<List<User>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<User>("SELECT * FROM [Tshirt] WHERE [Done] = 0");
        }

        public Task<User> GetItemAsync(int id)
        {
            return database.Table<User>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }
        public Task<int> SaveItemAsync(User item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }
        public Task<int> DeleteItemAsync(User item)
        {
            return database.DeleteAsync(item);
        }
        public Task<List<User>> GetUnSubmittedOrders()
        {
            return database.Table<User>().Where(x => x.Posted == false).ToListAsync();
        }

        //public Task<User> GetUserByUserName(string userName)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
