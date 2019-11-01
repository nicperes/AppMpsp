using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMPSP.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPage : ContentPage
	{
		public MenuPage ()
		{
			InitializeComponent ();
		}


        public void PesquisaClicked(object o, EventArgs e)
        {
            MessagingCenter.Send<string>("", "PesquisaPageAbrir");
        }


        public void SairClicked(object o, EventArgs e) {

            MessagingCenter.Send<String>("","Logoff");
            
        }



    }
}