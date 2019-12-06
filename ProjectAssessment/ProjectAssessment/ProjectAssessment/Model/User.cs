using Prism.Commands;
using Prism.Mvvm;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectAssessment.Model
{
    public class User 
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }

        public string CellphoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Posted { get; set; }

    }
}
