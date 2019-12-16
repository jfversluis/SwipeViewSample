using Xamarin.Forms;

namespace SwipeViewSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Enable your flags here!
            Device.SetFlags(new[] {
                "SwipeView_Experimental"
            });

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}