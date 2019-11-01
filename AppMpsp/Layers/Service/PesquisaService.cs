using System;
using System.Net.Http;
using System.Text;
using AppMPSP.Model;
using Newtonsoft.Json;

namespace AppMPSP.Layers.Service
{
    public class PesquisaService
    {
        PesquisaCPFCNPJModel pesquisaCPFCNPJ = new PesquisaCPFCNPJModel();
        
        public string Arpensp(int _cpfcnpj) {
            pesquisaCPFCNPJ.CPFCNPJ = _cpfcnpj;

            var jsons = new PesquisaCPFCNPJModel { CPFCNPJ = _cpfcnpj, Nome = "Teste" };

            var json = JsonConvert.SerializeObject(jsons);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var uri = String.Format("http://34.67.158.191/Home/Arpensp/");

            System.Net.Http.HttpClient client = new HttpClient();
            var resposta = client.PostAsync(uri, content).Result;

            if (resposta.IsSuccessStatusCode)
            {
                var resultado = resposta.Content.ReadAsStringAsync().Result;
                
                return resultado;
            }
            else
            {
                throw new Exception("Dados do investidor não encontrado!");
            }
        }

        public string Caged(int _cpfcnpj)
        {
            pesquisaCPFCNPJ.CPFCNPJ = _cpfcnpj;

            var jsons = new PesquisaCPFCNPJModel { CPFCNPJ = _cpfcnpj, Nome = "Teste" };

            var json = JsonConvert.SerializeObject(jsons);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var uri = String.Format("http://34.67.158.191/Home/Caged/");

            System.Net.Http.HttpClient client = new HttpClient();
            var resposta = client.PostAsync(uri, content).Result;

            if (resposta.IsSuccessStatusCode)
            {
                var resultado = resposta.Content.ReadAsStringAsync().Result;

                return resultado;
            }
            else
            {
                throw new Exception("Dados do investidor não encontrado!");
            }
        }

        public string Jucesp(int _cpfcnpj)
        {
            pesquisaCPFCNPJ.CPFCNPJ = _cpfcnpj;

            var jsons = new PesquisaCPFCNPJModel { CPFCNPJ = _cpfcnpj, Nome = "Teste" };

            var json = JsonConvert.SerializeObject(jsons);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var uri = String.Format("http://34.67.158.191/Home/Jucesp/");

            System.Net.Http.HttpClient client = new HttpClient();
            var resposta = client.PostAsync(uri, content).Result;

            if (resposta.IsSuccessStatusCode)
            {
                var resultado = resposta.Content.ReadAsStringAsync().Result;

                return resultado;
            }
            else
            {
                throw new Exception("Dados do investidor não encontrado!");
            }
        }


        public string Censec(int _cpfcnpj)
        {
            pesquisaCPFCNPJ.CPFCNPJ = _cpfcnpj;

            var jsons = new PesquisaCPFCNPJModel { CPFCNPJ = _cpfcnpj, Nome = "Teste" };

            var json = JsonConvert.SerializeObject(jsons);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var uri = String.Format("http://34.67.158.191/Home/Censec/");

            System.Net.Http.HttpClient client = new HttpClient();
            var resposta = client.PostAsync(uri, content).Result;

            if (resposta.IsSuccessStatusCode)
            {
                var resultado = resposta.Content.ReadAsStringAsync().Result;

                return resultado;
            }
            else
            {
                throw new Exception("Dados do investidor não encontrado!");
            }
        }


        public string Siel(int _cpfcnpj)
        {
            pesquisaCPFCNPJ.CPFCNPJ = _cpfcnpj;

            var jsons = new PesquisaCPFCNPJModel { CPFCNPJ = _cpfcnpj, Nome = "Teste", Processo = "343" };

            var json = JsonConvert.SerializeObject(jsons);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var uri = String.Format("http://34.67.158.191/Home/Siel/");

            System.Net.Http.HttpClient client = new HttpClient();
            var resposta = client.PostAsync(uri, content).Result;

            if (resposta.IsSuccessStatusCode)
            {
                var resultado = resposta.Content.ReadAsStringAsync().Result;

                return resultado;
            }
            else
            {
                throw new Exception("Dados do investidor não encontrado!");
            }
        }


        public string Sivec(int _cpfcnpj)
        {
            pesquisaCPFCNPJ.CPFCNPJ = _cpfcnpj;

            var jsons = new PesquisaCPFCNPJModel { CPFCNPJ = _cpfcnpj, Nome = "Teste", Processo = "343" };

            var json = JsonConvert.SerializeObject(jsons);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var uri = String.Format("http://34.67.158.191/Home/Sivec/");

            System.Net.Http.HttpClient client = new HttpClient();
            var resposta = client.PostAsync(uri, content).Result;

            if (resposta.IsSuccessStatusCode)
            {
                var resultado = resposta.Content.ReadAsStringAsync().Result;

                return resultado;
            }
            else
            {
                throw new Exception("Dados do investidor não encontrado!");
            }
        }

        public string Detran(int _cpfcnpj)
        {
            pesquisaCPFCNPJ.CPFCNPJ = _cpfcnpj;

            var jsons = new PesquisaCPFCNPJModel { CPFCNPJ = _cpfcnpj, Nome = "Teste", Processo = "343" };

            var json = JsonConvert.SerializeObject(jsons);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var uri = String.Format("http://34.67.158.191/Home/Detran/");

            System.Net.Http.HttpClient client = new HttpClient();
            var resposta = client.PostAsync(uri, content).Result;

            if (resposta.IsSuccessStatusCode)
            {
                var resultado = resposta.Content.ReadAsStringAsync().Result;

                return resultado;
            }
            else
            {
                throw new Exception("Dados do investidor não encontrado!");
            }
        }

    }
}
