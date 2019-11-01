using System.Windows.Input;
using Xamarin.Forms;
using AppMPSP.Model;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AppMPSP.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public ICommand EntrarClickedCommand { get; private set; }


        public Usuario _usuario;
        public Usuario Usuario { 
            get {
                return _usuario;
            }
            set {
                _usuario = value;
                NotifyPropertyChanged();
            }
        }



        public LoginViewModel() {

            Usuario = new Usuario();
            Usuario.Email = "fiap";
            Usuario.Senha = "mpsp";


            EntrarClickedCommand = new Command(() => {
                try
                {
                    //var investidor = 
                    //    new Layers.Business.UsuarioBusiness().Login(Usuario.Email,Usuario.Senha);

                    App.LoadGlobalVariables();

                    MessagingCenter.Send<LoginViewModel>(this, "LoginSucesso");
                } catch (Exception ex) {
                    App.MensagemAlerta("Login ou senha inválida. Detalhe: " + ex.Message);
                }
            });


        }
    }
}
