﻿using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using ProjectAssessment.Model;
using ProjectAssessment.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms.Maps;

namespace ProjectAssessment.ViewModels
{
//    public class LocationsViewModel : ViewModelBase
//    {
//        private IMapping _mappingService;

//        private ObservableCollection<CustomLocation> _locations;
//        public ObservableCollection<CustomLocation> Locations
//        {
//            get { return _locations; }
//            set { SetProperty(ref _locations, value); }
//        }

//        private MapSpan _centerPosition;
//        public MapSpan CenterPosition
//        {
//            get { return _centerPosition; }
//            set { SetProperty(ref _centerPosition, value); }
//        }

//        public LocationsViewModel(INavigationService navigationService, IMapping mapping) : base(navigationService)
//        {
//             _locations = new ObservableCollection<CustomLocation>()

//             {
//                new CustomLocation("UWC", "Future Innovation Lab", new Position(-33.9333296, 18.6333308),"Uwc","https://www.uwc.ac.za"),
//                new CustomLocation("Microsoft", "Office", new Position(-33.971200, 18.464900),"Microsoft","http://www.microsoft.com"),
//                new CustomLocation("Nandos", "Cause why not?", new Position(-33.933533,  18.407378), "Nandos","http://www.nandos.co.za")
//             };

//                _mappingService = mapping;

//                Title = "Maps Example";

//        }

//        public override void Initialize(INavigationParameters parameters)
//        {
//            base.Initialize(parameters);

//            CenterPosition = MapSpan.FromCenterAndRadius(new Position(-33.933329, 18.6333308), Distance.FromMiles(10));
//        }

//    }
}

