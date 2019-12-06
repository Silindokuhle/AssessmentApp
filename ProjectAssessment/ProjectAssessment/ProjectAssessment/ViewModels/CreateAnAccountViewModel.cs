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
        private Services.Interfaces.SafetyDatabase _database;
        //public INavigationService NavigationService;

        private DelegateCommand _createaccountCommand;
        public DelegateCommand CreateaccountCommand =>
            _createaccountCommand ?? (_createaccountCommand = new DelegateCommand(ExecuteCreateaccountCommand));


        private User _userInfo;
        public User UserInfo
        {
            get { return _userInfo; }
            set { SetProperty(ref _userInfo, value); }
        }

        private IPageDialogService _dialogService;


        public async void ExecuteCreateaccountCommand()
        {
            if (UserInfo.Name == null)
            {
                await _dialogService.DisplayAlertAsync("ALERT!", "Name is required", "ok");
            }
            else if (UserInfo.Surname == null)
            {
                await _dialogService.DisplayAlertAsync("ALERT!", "Surname is required", "ok");
            }
            else if (UserInfo.Email == null)
            {
                await _dialogService.DisplayAlertAsync("ALERT!", "email is required", "ok");
            }
            else if (UserInfo.CellphoneNumber == null)
            {
                await _dialogService.DisplayAlertAsync("ALERT!", "cellphone number is required", "ok");
            }

            else
            {
                var conn = new Services.SafetyDatabase();
                await conn.SaveItemAsync(UserInfo);
                await NavigationService.NavigateAsync("HomePage");
            }
        }
        public CreateAnAccountViewModel(INavigationService navigationService) : base(navigationService)
        {

        }
    }
    
}
