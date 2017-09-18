using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppGourmet.Models;
using AppGourmet.Views;
using Xamarin.Forms;

namespace AppGourmet
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ListagemView(Usuario);
        }

        protected override void OnStart()
        {
			//MessagingCenter.Subscribe<Usuario>(this, "SucessoLogin",
			//(Usuario) =>
			//{
   //             MainPage = new NavigationPage(new ListagemView(Usuario));   
			//	//MainPage = new MasterDetailView(Usuario);
			//});
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
