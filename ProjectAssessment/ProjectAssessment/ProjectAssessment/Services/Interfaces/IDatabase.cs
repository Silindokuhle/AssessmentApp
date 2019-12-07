using Prism.Commands;
using Prism.Mvvm;
using ProjectAssessment.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAssessment.Services.Interfaces
{
    public interface IDatabase
    {
        Task<List<User>> GetItemsAsync();
        Task<List<User>> GetItemsNotDoneAsync();
        Task<User> GetItemAsync(int id);
        Task<int> SaveItemAsync(User item);
        Task<int> DeleteItemAsync(User item);
        Task<List<User>> GetUnSubmittedOrders();
        Task<User> GetUserByUserName(string userName);
    }
}
