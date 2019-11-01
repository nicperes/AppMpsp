using AppMPSP.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMPSP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
        protected LoginViewModel loginViewModel;
		
        public LoginPage ()
		{
			InitializeComponent ();
        }
    }
}