using Prism.Commands;
using Prism.Mvvm;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectAssessment.Models
{
    public class IDatabase 
    {
       [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
       public string Username { get; set; }
       public string Password { get; set; }

    }
}
