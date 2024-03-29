﻿using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using ProjectAssessment.Model.Security;
using ProjectAssessment.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ProjectAssessment.ViewModels
{
    public class MasterDetailViewModel : ViewModelBase
    {
        private ISecurityService _securityService;
        private IEventAggregator _eventAggregator;
       // private INavigationService NavigationService;


        private ObservableCollection<MenuItem> _menuItems;

        public ObservableCollection<MenuItem> MenuItems
        {
            get { return _menuItems; }
            set { SetProperty(ref _menuItems, value); }
        }


        //Button that leads you to the profile page
        private DelegateCommand _profile;
        public DelegateCommand Profile =>
            _profile ?? (_profile = new DelegateCommand(ExecuteProfile));

        // button that leads you to the location page
        private DelegateCommand _locations;
        public DelegateCommand Locations =>
            _locations ?? (_locations = new DelegateCommand(ExecuteLocations));

       

        // button that leads you to the location page
        private DelegateCommand _sendAlertCommand;
        public DelegateCommand SendAlertCommand =>
            _sendAlertCommand ?? (_sendAlertCommand = new DelegateCommand(ExecuteSendAlertCommand));
        private DelegateCommand _about;
        public DelegateCommand About =>
            _about ?? (_about = new DelegateCommand(ExecuteAbout));

      
        // button that leads you to the location page
        private DelegateCommand _exit;
        public DelegateCommand Exit =>
            _exit ?? (_exit = new DelegateCommand(ExecuteExit));

        public MasterDetailViewModel(INavigationService navigationService, IDatabase database, ISecurityService securityService) : base(navigationService)
        {
            _securityService = securityService;
            
           // _eventAggregator = eventAggregator;
        }

        public async void ExecuteAbout()
        {
            await NavigationService.NavigateAsync("NavigationPage/About");
        }



        public async void ExecuteExit()
        {
            await NavigationService.NavigateAsync("NavigationPage/MainPage");

        }

        public async void ExecuteSendAlertCommand()
        {
            await NavigationService.NavigateAsync("NavigationPage/PanicAlert");

        }



       

        public async void ExecuteLocations()
        {
            await NavigationService.NavigateAsync("NavigationPage/Locations");

        }



        public async void ExecuteProfile()
        {
            await NavigationService.NavigateAsync("NavigationPage/Profile");
        }

    }
}
