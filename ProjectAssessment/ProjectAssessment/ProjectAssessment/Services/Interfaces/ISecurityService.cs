using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using ProjectAssessment.Model.Security;

namespace ProjectAssessment.Services.Interfaces
{
    public interface IFakeSecurityService
    {
        IList<MenuItem> GetAllowedAccessItems();
        bool LogIn(string userName, string password);
        void LogOut();
    }
}
