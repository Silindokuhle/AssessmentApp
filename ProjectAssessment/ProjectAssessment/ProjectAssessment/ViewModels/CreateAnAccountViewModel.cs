using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using ProjectAssessment.Model;
using ProjectAssessment.Services;
using ProjectAssessment.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectAssessment.ViewModels
{
    public class CreateAnAccountViewModel : ViewModelBase
    {
        private IDatabase _database;
         public User UserInfo { get; set; }
        //public INavigationService NavigationService;

        private DelegateCommand<User> _createaccountCommand;
        public DelegateCommand<User> CreateaccountCommand =>
            _createaccountCommand ?? (_createaccountCommand = new DelegateCommand<User>(ExecuteCreateaccountCommand));


        //private User _userInfo;
        //public User UserInfo
        //{
        //    get { return _userInfo; }
        //    set { SetProperty(ref _userInfo, value); }
        //}

        private IPageDialogService _dialogService;


        public async void ExecuteCreateaccountCommand(User user)
        {
            var userLogged = await _database.GetUserByUserName(UserInfo.Username);

            if (UserInfo.Name == null || UserInfo.Surname == null)
            {
                await _dialogService.DisplayAlertAsync("ALERT!", "Name or Surname is required", "ok");
            }
            //else if ()
            //{
            //    await _dialogService.DisplayAlertAsync("ALERT!", "Surname is required", "ok");
            //}
            else if (UserInfo.Email == null)
            {
                await _dialogService.DisplayAlertAsync("ALERT!", "email is required", "ok");
            }
            //else if (UserInfo.CellphoneNumber == null)
            //{
            //    await _dialogService.DisplayAlertAsync("ALERT!", "cellphone number is required", "ok");
           // }

            else
            {
                var conn = new SafetyDatabase();
                await conn.SaveItemAsync(UserInfo);
                await NavigationService.NavigateAsync("Login");
            }
        }
        public CreateAnAccountViewModel(INavigationService navigationService, IDatabase database, IPageDialogService pageDialogService) : base(navigationService)
        {
            _database = database;
            var stuff = new User();
            UserInfo = stuff;

            _dialogService = pageDialogService;
        }
    }
    
}
