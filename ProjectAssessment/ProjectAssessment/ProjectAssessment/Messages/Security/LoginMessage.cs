using Amazon.OpsWorks.Model;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectAssessment.Messages.Security
{
    public class LoginMessage : PubSubEvent<UserProfile>
    {
       
    }
}
