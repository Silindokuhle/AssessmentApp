using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using ProjectAssessment.Messages.Security;
using ProjectAssessment.Model;
using ProjectAssessment.Model.Security;
using ProjectAssessment.Services.Interfaces;
using ProjectAssessment.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectAssessment.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {

        private IDatabase _database;

        //private User _userInfo;
        //private User UserInfo
        //{
        //    get { return _userInfo; }
        //    set { SetProperty(ref _userInfo, value); }
        //}

        public User UserInfo { get; set; }


        //private ISecurityService _securityService;
        // private IEventAggregator _eventAggregator;

        // public INavigationService NavigationService;

        private DelegateCommand _loginCommand;
        public DelegateCommand LoginCommand =>
            _loginCommand ?? (_loginCommand = new DelegateCommand(ExecuteLoginCommand));

        public bool PasswExist { get; set; }
        public List<User> CustomerDetails { get; set; }

        private IPageDialogService _dialogService;
        public User Access { get; set; }

        public LoginViewModel(INavigationService navigationService, IDatabase database, IPageDialogService pageDialogService) : base(navigationService)
        {
            //securityService = securityService;
            //eventAggregator = eventAggregator;
            _database = database;
            _dialogService = pageDialogService;

            var loginInfor = new User();
            UserInfo = loginInfor;
        }

        public override void Initialize(INavigationParameters parameters)
        {
            //base.Initialize(parameters);
            UserInfo = new User();
        }

        private async void ExecuteLoginCommand()
        {
            var knownUser = await _database.GetUserByUserName(UserInfo.Username);

            //var Infor = UserInfo;
            if (UserInfo.Username == null)
            {
                await _dialogService.DisplayAlertAsync("Alert", "Username is required!", "ok");
            }else if (UserInfo.Password == null)
            {
                await _dialogService.DisplayAlertAsync("Alert", "Username is required!", "ok");
            }else if (UserInfo.Password != knownUser.Password || UserInfo.Username != knownUser.Username)
            {
                await _dialogService.DisplayAlertAsync("Alert", "Wrong Username or Password, Please Try again!", "ok");
            }
             else
            {
                if (knownUser.Password == UserInfo.Password)
                {
                    PasswExist = true;
                    await NavigationService.NavigateAsync("Profile");
                    return;
                }
                else
                {
                    PasswExist = false;
                }
                if (PasswExist == false)
                {
                    await _dialogService.DisplayAlertAsync("ALERT!", "Incorrect password, please try again", "ok");
                }
            }
            





            // DO YOUR OWN LOGIN LOGIC AND VALIDATION
            // var loginResult = _securityService.LogIn("Test User", "Password");

            // I may have gotten a user profile somewhere..  Use whatever your app does
            //var userProfile = new UserProfile();

            // if (loginResult)
            // {
            //    _eventAggregator.GetEvent<LoginMessage>().Publish(userProfile);
        }
            //await NavigationService.NavigateAsync("Login");

    }
}
        
        
    
    
    

