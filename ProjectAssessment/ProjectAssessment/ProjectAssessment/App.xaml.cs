using Prism;
using Prism.Ioc;
using ProjectAssessment.Services;
using ProjectAssessment.Services.Interfaces;
using ProjectAssessment.ViewModels;
using ProjectAssessment.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ProjectAssessment
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized() 
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("MasterDetail/NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<ISecurityService, FakeSecurityService>();

            containerRegistry.RegisterSingleton<IDatabase, SafetyDatabase>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();

            containerRegistry.RegisterForNavigation<CreateAnAccount, CreateAnAccountViewModel>();
            containerRegistry.RegisterForNavigation<Login, LoginViewModel>();

            containerRegistry.RegisterForNavigation<MasterDetail, MasterDetailViewModel>();
            containerRegistry.RegisterForNavigation<Profile, ProfileViewModel>();
            containerRegistry.RegisterForNavigation<Locations, LocationsViewModel>();
            containerRegistry.RegisterForNavigation<Circle, CircleViewModel>();
            containerRegistry.RegisterForNavigation<PanicAlert, PanicAlertViewModel>();
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>();
            containerRegistry.RegisterForNavigation<LoginCopy, LoginCopyViewModel>();
        }
    }
}
