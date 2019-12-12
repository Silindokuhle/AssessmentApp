using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace ProjectAssessment.ViewModels
{
    public class PanicAlertViewModel : ViewModelBase
    {
        private DelegateCommand _panicAlert;
        public DelegateCommand PanicAlert =>
             _panicAlert ?? (_panicAlert = new DelegateCommand(ExecutePanicAlert));

        public async void ExecutePanicAlert()
        {
            var contactNumbers = new List<string>();
            contactNumbers.Add("0718980404");
            contactNumbers.Add("0638771175");
            contactNumbers.Add("0639620424");
            contactNumbers.Add("0793709715");
            await SendSms("I need Help, I'm in Danger", contactNumbers.ToArray());
            await NavigationService.NavigateAsync("MainPage");

        }
        public PanicAlertViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Panic Button";
        }


        public async Task SendSms(string messageText, string[] recipients)
        {
            try
            {
                var message = new SmsMessage(messageText, recipients);
                await Sms.ComposeAsync(message);

            }
            catch (FeatureNotSupportedException ex)
            {
                // Sms is not supported on this device.
            }
            catch (Exception ex)
            {
                // Other error has occurred.
            }


        }
    }
}
    

    
