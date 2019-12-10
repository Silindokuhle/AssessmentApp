using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using ProjectAssessment.Model;
using ProjectAssessment.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectAssessment.ViewModels
{
    public class ProfileViewModel : ViewModelBase
    {
        private IDatabase _database;
        public User UserInfo { get; set; }
        private IPageDialogService _dialogService;

        public List<User> CustomerDetails { get; set; }



        public ProfileViewModel(INavigationService navigationService, IDatabase database, IPageDialogService pageDialogService) : base(navigationService)
        {
            //_database = database;
            //var customerdetails = user();
            //UserInfo = customerdetails;

            //_dialogService = pageDialogService;
        }
    }
}
