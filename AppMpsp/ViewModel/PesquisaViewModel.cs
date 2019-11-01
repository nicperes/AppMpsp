using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using AppMPSP.Layers.Business;
using AppMPSP.Model;
using AppMPSP.Views.Components;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace AppMPSP.ViewModel
{
    public class PesquisaViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private PesquisaCPFCNPJModel _pesquisaCPFCNPJ;

        private PesquisaBusiness pesquisaBusiness;


        public PesquisaCPFCNPJModel _pesquisaCpfCnpj;
        public PesquisaCPFCNPJModel PesquisaCPFCNPJ
        {
            get
            {
                return _pesquisaCpfCnpj;
            }
            set
            {
                _pesquisaCpfCnpj = value;
                // Global.Investidor = _pesquisaCPFCNPJ;
            }
        }


        public PesquisaViewModel()
        {
           // _pesquisaCPFCNPJ = Global.Investidor;
            pesquisaBusiness = new PesquisaBusiness();

            PesquisaCPFCNPJ = new PesquisaCPFCNPJModel();

            PesquisarClickedCommand = new Command(() => {
                var mensagem = "Consulta Realizada com Sucesso";
                try
                {
                    ArpenspModel arpenspModel = pesquisaBusiness.Arpensp(PesquisaCPFCNPJ.CPFCNPJ);
                    CagedModel cagedModel = pesquisaBusiness.Caged(PesquisaCPFCNPJ.CPFCNPJ);
                    JucespModel jucespModel = pesquisaBusiness.Jucesp(PesquisaCPFCNPJ.CPFCNPJ);
                    CensecModel censecModel = pesquisaBusiness.Censec(PesquisaCPFCNPJ.CPFCNPJ);
                    SielModel sielModel = pesquisaBusiness.Siel(PesquisaCPFCNPJ.CPFCNPJ);
                    SivecModel sivecModel = pesquisaBusiness.Sivec(PesquisaCPFCNPJ.CPFCNPJ);
                    DetranModel detranModel = pesquisaBusiness.Detran(PesquisaCPFCNPJ.CPFCNPJ);

                } catch (Exception ex) {
                    mensagem = "Não foi possível consultar os dados. Verifique sua conexão! \n Detalhe: " +
                        ex.Message;
                }

                DependencyService.Get<IMessage>().ShortAlert(mensagem);
                MessagingCenter.Send<PesquisaViewModel>(this, "PesquisaSucesso");
            });


        }

        // Commando Clicked
        public ICommand PesquisarClickedCommand { get; private set; }




    }
}
