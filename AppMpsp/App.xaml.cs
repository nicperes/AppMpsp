using System;
using AppMPSP.Layers.Business;
using AppMPSP.ViewModel;
using AppMPSP.Views;
using Xamarin.Forms;

namespace AppMPSP
{
    public partial class App : Application
	{
        

		public App ()
		{
			InitializeComponent();

            // Método Interno que carrega variáveis (Objetos) Globais
            LoadGlobalVariables();

                MainPage = new AppMPSP.Views.LoginPage();
            

        }

        protected override void OnStart()
        {

            // Handle when your app starts
            MessagingCenter.Subscribe<LoginViewModel>(this, "LoginSucesso",
                (sender) =>
                {
                    MainPage = new PrincipalPage();
                });

            // Handle when your app starts
            MessagingCenter.Subscribe<String>("", "Logoff",
                (sender) =>
                {

                    new LogoffBusiness().Logoff();
                    
                    MainPage = new LoginPage();
                });


        }

        protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}

        internal static void LoadGlobalVariables()
        {
            

        }


        internal static void MensagemAlerta(string texto)
        {
            App.Current.MainPage.DisplayAlert("Título", texto, "Ok");
        }




	}
}
