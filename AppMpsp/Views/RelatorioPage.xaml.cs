using AppMPSP.Views.Components;
using System;
using Xamarin.Forms;

namespace AppMPSP.Views
{
    public partial class RelatorioPage : ContentPage
    {
        public RelatorioPage()
        {
            InitializeComponent();
        }

        public void VoltarClicked(object o, EventArgs e)
        {
            MessagingCenter.Send<string>("", "Voltar");
        }
        protected override void OnAppearing()
        {

            

        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            

        }
    }
}
