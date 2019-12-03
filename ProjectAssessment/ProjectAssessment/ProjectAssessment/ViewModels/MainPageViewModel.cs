using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectAssessment.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        //button for logging in
        private DelegateCommand _loginCommand;
        public DelegateCommand LoginCommand =>
            _loginCommand ?? (_loginCommand = new DelegateCommand(ExecuteLoginCommand));

        //button for creating an account
        private DelegateCommand _createanaccountCommand;
        public DelegateCommand CreateanaccountCommand =>
            _createanaccountCommand ?? (_createanaccountCommand = new DelegateCommand(ExecuteCreateanaccountCommand));

        public async void ExecuteCreateanaccountCommand()
        {

            await NavigationService.NavigateAsync("CreateAnAccount");
        }
        

        public async void ExecuteLoginCommand()
        {
            await NavigationService.NavigateAsync("Login");

        }


        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
        }
    }
}
       