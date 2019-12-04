using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using ProjectAssessment.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectAssessment.ViewModels
{
    public class CreateAnAccountViewModel : ViewModelBase
    {
        private IDatabase _database;
        public INavigationService NavigationService;

        private DelegateCommand _createaccount;
        public DelegateCommand Createaccount =>
            _createaccount ?? (_createaccount = new DelegateCommand(ExecuteCreateaccount));

        public async void ExecuteCreateaccount()
        {
            await NavigationService.NavigateAsync("HomePage");

        }
        public CreateAnAccountViewModel(INavigationService navigationService) : base(navigationService)
        {

        }
    }
    
}
