using System;
using AppMPSP.Model;
using System.Linq;
using Newtonsoft.Json;

namespace AppMPSP.Layers.Business
{
    public class PesquisaBusiness
    {

        public ArpenspModel Arpensp(int cpfcnpj){

            var arpensp = new Service.PesquisaService().Arpensp(cpfcnpj);

            ArpenspModel arpenspModel = JsonConvert.DeserializeObject<ArpenspModel>(arpensp);

            //variavel global
            Global.Arpensp = arpenspModel;

            return arpenspModel;
        }


        public CagedModel Caged(int cpfcnpj)
        {
            var caged = new Service.PesquisaService().Caged(cpfcnpj);

            CagedModel cagedModel = JsonConvert.DeserializeObject<CagedModel>(caged);

            //variavel global
            Global.Caged = cagedModel;

            return cagedModel;
        }


        public JucespModel Jucesp(int cpfcnpj)
        {
            var jucesp = new Service.PesquisaService().Jucesp(cpfcnpj);

            JucespModel jucespModel = JsonConvert.DeserializeObject<JucespModel>(jucesp);

            //variavel global
            Global.Jucesp = jucespModel;

            return jucespModel;
        }

        public CensecModel Censec(int cpfcnpj)
        {
            var censec = new Service.PesquisaService().Censec(cpfcnpj);

            CensecModel censecModel = JsonConvert.DeserializeObject<CensecModel>(censec);

            //variavel global
            Global.Censec = censecModel;

            return censecModel;
        }

        public SielModel Siel(int cpfcnpj)
        {
            var siel = new Service.PesquisaService().Siel(cpfcnpj);

            SielModel sielModel = JsonConvert.DeserializeObject<SielModel>(siel);

            //variavel global
            Global.Siel = sielModel;

            return sielModel;
        }

        public SivecModel Sivec(int cpfcnpj)
        {
            var sivec = new Service.PesquisaService().Sivec(cpfcnpj);

            SivecModel sivecModel = JsonConvert.DeserializeObject<SivecModel>(sivec);

            //variavel global
            Global.Sivec = sivecModel;

            return sivecModel;
        }

        public DetranModel Detran(int cpfcnpj)
        {
            var detran = new Service.PesquisaService().Detran(cpfcnpj);

            DetranModel detranModel = JsonConvert.DeserializeObject<DetranModel>(detran);

            //variavel global
            Global.Detran = detranModel;

            return detranModel;
        }

    }
}
