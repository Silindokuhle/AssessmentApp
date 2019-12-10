using ProjectAssessment.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectAssessment.Services.Interfaces
{
    public interface IUserProfile
    {
        void SetLoggedinUser(User user);
        User GetLoggedInUser();
    }
}
