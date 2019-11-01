using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace AppMPSP.Model
{
    public class PesquisaCPFCNPJModel : INotifyPropertyChanged
    {
        private int cpfcnpj;

        public int CPFCNPJ
        {
            get { return cpfcnpj; }
            set
            {
                if (cpfcnpj != value)
                {
                    cpfcnpj = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private String nome;
        public String Nome
        {
            get { return nome; }
            set
            {
                if (nome != value)
                {
                    nome = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private String processo;
        public String Processo
        {
            get { return processo; }
            set
            {
                if (processo != value)
                {
                    processo = value;
                    NotifyPropertyChanged();
                }
            }
        }


        public PesquisaCPFCNPJModel()
        {
        }

        public PesquisaCPFCNPJModel(int _cpfcnpj)
        {
            this.CPFCNPJ = _cpfcnpj;
        }

        

        public PesquisaCPFCNPJModel(int CPFCNPJ, String Nome)
        {
            this.CPFCNPJ = CPFCNPJ;
            this.Nome = Nome;
        }

        public PesquisaCPFCNPJModel(int CPFCNPJ, String Nome, String Processo)
        {
            this.CPFCNPJ = CPFCNPJ;
            this.Nome = Nome;
            this.Processo = Processo;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
