using System;
using System.Collections.Generic;
using System.Windows.Input;
using AppMPSP.Layers.Business;
using AppMPSP.Model;
using AppMPSP.Views.Components;
using Xamarin.Forms;

namespace AppMPSP.ViewModel
{
    public class RelatorioViewModel
    {
        
        public RelatorioViewModel()
        {
            Arpensp = Global.Arpensp;
            Caged = Global.Caged;
            Jucesp = Global.Jucesp;
            Censec = Global.Censec;
            Siel = Global.Siel;
            Sivec = Global.Sivec;
            Detran = Global.Detran;
        }


        private ArpenspModel arpensp;
        public ArpenspModel Arpensp
        {
            get
            {
                return arpensp;
            }
            set
            {
                arpensp = value;
                
            }
        }

        private CagedModel caged;
        public CagedModel Caged
        {
            get
            {
                return caged;
            }
            set
            {
                caged = value;

            }
        }

        private JucespModel jucesp;
        public JucespModel Jucesp
        {
            get
            {
                return jucesp;
            }
            set
            {
                jucesp = value;

            }
        }

        private CensecModel censec;
        public CensecModel Censec
        {
            get
            {
                return censec;
            }
            set
            {
                censec = value;

            }
        }

        private SielModel siel;
        public SielModel Siel
        {
            get
            {
                return siel;
            }
            set
            {
                siel = value;

            }
        }

        private SivecModel sivec;
        public SivecModel Sivec
        {
            get
            {
                return sivec;
            }
            set
            {
                sivec = value;

            }
        }

        private DetranModel detran;
        public DetranModel Detran
        {
            get
            {
                return detran;
            }
            set
            {
                detran = value;

            }
        }

        public ICommand MoedaTappedCommand { get; private set; }

    }


}
