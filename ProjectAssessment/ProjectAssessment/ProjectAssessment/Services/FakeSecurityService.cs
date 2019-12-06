using System;
using Prism.Events;
using ProjectAssessment.Enums;
using ProjectAssessment.Messages.Security;
using ProjectAssessment.Model.Security;
using ProjectAssessment.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;
using ProjectAssessment.Enums.Security;

namespace ProjectAssessment.Services.Interfaces
{
    public interface FakeSecurityService : IFakeSecurityService
    {
        IList<MenuItem> GetAllowedAccessItems();
        bool LogIn(string Username, string Password);
        void LogOut();
    }
        /*private IEventAggregator _eventAggregator;
            public IList<MenuItem> _allMenuItems;
            public bool LoggedIn { get; set; }
        

        public FakeSecurityService(IEventAggregator eventAggregator)
        {
            CreateMenuItems();

            _eventAggregator = eventAggregator;
        }
        public IList<MenuItem> GetAllowedAccessItem()
        {
            if (LoggedIn)
            {
                var accessItems = new List<MenuItem>();
                foreach (var item in _allMenuItems)
                {
                    if (item.MenuType == MenuTypeEnum.Secured || item.MenuType == MenuTypeEnum.UnSecured || item.MenuType == MenuTypeEnum.LogOut)
                    {
                        accessItems.Add(item);
                    }
                }
                return accessItems.OrderBy(x => x.MenuOrder).ToList();

            }
            else
            {
                var accessItems = new List<MenuItem>();

                foreach (var item in _allMenuItems)
                {
                    if (item.MenuType == MenuTypeEnum.UnSecured || item.MenuType == MenuTypeEnum.Login)
                    {
                        accessItems.Add(item);
                    }
                }
                return accessItems.OrderBy(x => x.MenuOrder).ToList();
            }
        }
        public bool LogIn(string userName, string password)
        {

            // Do Your Stuff to Check if Legit (ie API Calls)

            LoggedIn = true;

            return true;
        }
        public void LogOut()
        {
            LoggedIn = false;

            _eventAggregator.GetEvent<LogOutMessage>().Publish();
        }
        private void CreateMenuItems()
        {
            _allMenuItems = new List<MenuItem>();

            var menuItem = new MenuItem();
            menuItem.MenuItemId = 1;
            menuItem.MenuItemName = "Profile";
            menuItem.NavigationPath = "NavigationPage/LoginView";
            menuItem.MenuType = MenuTypeEnum.Login;
            menuItem.MenuOrder = 1;
            menuItem.ImageName = "login.png";

            _allMenuItems.Add(menuItem);

            menuItem = new MenuItem();
            menuItem.MenuItemId = 2;
            menuItem.MenuItemName = "Logout";
            menuItem.NavigationPath = "";
            menuItem.MenuOrder = 99;
            menuItem.MenuType = MenuTypeEnum.LogOut;
            menuItem.ImageName = "logout.png";

            _allMenuItems.Add(menuItem);

            menuItem = new MenuItem();
            menuItem.MenuItemId = 3;
            menuItem.MenuItemName = "Maps View";
            menuItem.NavigationPath = "NavigationPage/MapsView";
            menuItem.MenuOrder = 3;
            menuItem.MenuType = MenuTypeEnum.Secured;
            menuItem.ImageName = "map.png";

            _allMenuItems.Add(menuItem);

            menuItem = new MenuItem();
            menuItem.MenuItemId = 4;
            menuItem.MenuItemName = "Other View";
            menuItem.NavigationPath = "NavigationPage/OtherView";
            menuItem.MenuOrder = 4;
            menuItem.MenuType = MenuTypeEnum.Secured;
            menuItem.ImageName = "other.png";

            _allMenuItems.Add(menuItem); */
        
    }

