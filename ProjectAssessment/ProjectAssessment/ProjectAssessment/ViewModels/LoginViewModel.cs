using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using ProjectAssessment.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectAssessment.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private IDatabase _database;
        public INavigationService NavigationService;

        private DelegateCommand _fieldName;
        public DelegateCommand LoginCommand =>
            _fieldName ?? (_fieldName = new DelegateCommand(ExecuteLoginCommand));

        public async void ExecuteLoginCommand()
        {
            await NavigationService.NavigateAsync("Home");

        }
        public LoginViewModel(INavigationService navigationService) : base(navigationService)
        {

        }
    
    }
}
