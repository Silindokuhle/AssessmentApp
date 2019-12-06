using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using ProjectAssessment.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectAssessment.ViewModels
{
    public class MasterDetailViewModel : ViewModelBase
    {
        private SafetyDatabase _database;
        public INavigationService NavigationService;

        //Button that leads you to the profile page
        private DelegateCommand _profile;
        public DelegateCommand Profile =>
            _profile ?? (_profile = new DelegateCommand(ExecuteProfile));

        // button that leads you to the location page
        private DelegateCommand _locations;
        public DelegateCommand Locations =>
            _locations ?? (_locations = new DelegateCommand(ExecuteLocations));

        // button that leads you to the location page
        private DelegateCommand _myCircle;
        public DelegateCommand MyCircle =>
            _myCircle ?? (_myCircle = new DelegateCommand(ExecuteMyCircle));

        // button that leads you to the location page
        private DelegateCommand _sendAlertCommand;
        public DelegateCommand SendAlertCommand =>
            _sendAlertCommand ?? (_sendAlertCommand = new DelegateCommand(ExecuteSendAlertCommand));

        // button that leads you to the location page
        private DelegateCommand _exit;
        public DelegateCommand Exit =>
            _exit ?? (_exit = new DelegateCommand(ExecuteExit));

        public MasterDetailViewModel(INavigationService navigationService) : base(navigationService)
        {

        }


        public async void ExecuteExit()
        {
            await NavigationService.NavigateAsync("MainPage");

        }

        public async void ExecuteSendAlertCommand()
        {
            await NavigationService.NavigateAsync("PanicAlert");

        }



        public async void ExecuteMyCircle()
        {
            await NavigationService.NavigateAsync("Circle");

        }

        public async void ExecuteLocations()
        {
            await NavigationService.NavigateAsync("Locations");

        }



        public async void ExecuteProfile()
        {
            await NavigationService.NavigateAsync("Profile");
        }

    }
}
