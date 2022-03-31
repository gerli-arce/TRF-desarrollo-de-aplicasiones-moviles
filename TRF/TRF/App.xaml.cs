using System;
using TRF.clases;
using TRF.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TRF
{
    public partial class App : Application
    {
        
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ProductosPage());
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
