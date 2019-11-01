using AppMPSP.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMPSP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrincipalPage : MasterDetailPage
    {
        public PrincipalPage()
        {
            InitializeComponent();

            this.Detail = new NavigationPage(new MenuPage());
            
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<string>("", "PesquisaPageAbrir",
                (sender) =>
                {

                    this.Detail = new NavigationPage(new PesquisaPage());
                    this.IsPresented = false;
                });

            MessagingCenter.Subscribe<PesquisaViewModel>("", "PesquisaSucesso",
                (sender) =>
                {
                    this.Detail = new NavigationPage(new RelatorioPage());
                    this.IsPresented = false;
                });
            MessagingCenter.Subscribe<string>("", "Voltar",
                (sender) =>
                {
                    this.Detail = new NavigationPage(new MenuPage());
                    this.IsPresented = false;
                });

        }


        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<string>("", "PesquisaPageAbrir");
            MessagingCenter.Unsubscribe<string>("", "PesquisaSucesso");
            MessagingCenter.Unsubscribe<string>("", "Voltar");

        }
    }
}