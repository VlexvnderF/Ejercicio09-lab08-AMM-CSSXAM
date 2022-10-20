using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio09
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new InheritanceDemo();
            //MainPage = new DynamicDemo();
            //MainPage = new ExplicitControlDemo();
            //MainPage = new ExplicitDemo();
            //MainPage = new GlobalDemo();
            //MainPage = new ImplicitControlDemo();
            //MainPage = new ImplicitDemo();
            MainPage = new CssXama();

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
