using Prism.Commands;
using Prism.Mvvm;
using ProjectAssessment.Services.Interfaces;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectAssessment.Model.Security
{
    public class UserProfile : IUserProfile
    {
        private User _loggedInUser;

        public void SetLoggedinUser(User user)
        {
            _loggedInUser = user;
        }

        public User GetLoggedInUser()
        {
            return _loggedInUser;
        }

       
    }
}
