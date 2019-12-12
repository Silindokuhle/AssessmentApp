using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ProjectAssessment.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private IEventAggregator _eventAggregator;

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
        public Action DisplayInvalidLoginPromp;
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
       
      
        public async void ExecuteLoginCommand()
        {
            await NavigationService.NavigateAsync("Login");
           // await NavigationService.NavigateAsync("Login");

        }



        public MainPageViewModel(INavigationService navigationService, IEventAggregator eventAggregator) : base(navigationService)
        {
            Title = "Main Page";
            _eventAggregator = eventAggregator;
        }
        public Action DisplayInvalidLoginPrompt;
       
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }
    }
}
       