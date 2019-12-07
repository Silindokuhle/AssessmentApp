using Prism.Commands;
using Prism.Mvvm;
using ProjectAssessment.Enums.Security;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectAssessment.Model.Security
{
    public class MenuItem 
    {
        public int ID { get; set; }
        public int MenuItemId { get; set; }
        public int MenuOrder { get; set; }
        public string ImageName { get; set; }
        public string MenuItemName { get; set; }
        public string NavigationPath { get; set; }
        public MenuTypeEnum MenuType { get; set; }
    }
}
