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
        private User _loggedInUser;
        public User LoggedInUser
        {
            get { return _loggedInUser; }
            set { SetProperty(ref _loggedInUser, value); }
        }

        private DelegateCommand _updateCommand;
        public DelegateCommand UpdateCommand =>
            _updateCommand ?? (_updateCommand = new DelegateCommand(ExecuteUpdateCommand));

        async void ExecuteUpdateCommand()
        {
            var userLogged = await _database.GetUserByUserName(LoggedInUser.Username);

            await _database.SaveItemAsync(LoggedInUser);

            await NavigationService.NavigateAsync("MasterDetail/NavigationPage/Profile", useModalNavigation: true); return;
        }
        private IDatabase _database;
        private IUserProfile _userProfile;
        public User UserInfo { get; set; }
        private IPageDialogService _dialogService;

        public List<User> CustomerDetails { get; set; }

        private User _loggedin;
        private object IUserProfile;
        //public User LoggedInUser
        //{
        //    get { return _loggedin; }
        //    set { SetProperty(ref _loggedin, value); }
        //}
        public override void Initialize(INavigationParameters parameters)
        {
            base.Initialize(parameters);
            LoggedInUser = _userProfile.GetLoggedInUser();

           


        }

        public ProfileViewModel(INavigationService navigationService, IDatabase database, IUserProfile userProfile) : base(navigationService)
        {
            _database = database;
            _userProfile = userProfile;
            //var customerdetails = user();
            //UserInfo = customerdetails;

            //_dialogService = pageDialogService;
        }
    }
}
