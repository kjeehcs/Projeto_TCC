using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;


namespace Projeto_tcc
{
    public partial class Dash : Form
    {
        // Substitua 'SUA_RAW_API_TOKEN_AQUI' pelo seu token Pi-hole
        string apiToken = "0f1c0a417cb4a3c4648d38f67d4ff43346ce6ebb0e1ce54e61193808fb236ca3";
        string apiUrl = "http://172.20.10.9/admin/api.php?summaryRaw&auth=0f1c0a417cb4a3c4648d38f67d4ff43346ce6ebb0e1ce54e61193808fb236ca3"; // Substitua pelo IP do seu Raspberry

        public Dash()
        {
            InitializeComponent();
            CarregarAPI();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        public async void CarregarAPI()
        {
            //string summaryResponse = await GetPiHoleData(apiUrl + "?summary", apiToken);
            //MessageBox.Show("Summary Response:\n" + summaryResponse, "API Response");

            string summaryResponse = await GetPiHoleData(apiUrl);   
            MessageBox.Show(summaryResponse);

            try
            {
                // Desserializar a resposta JSON como um objeto
                JObject jsonObject = JObject.Parse(summaryResponse);

                // Obter o valor de "domains_being_blocked"
                string domainsBeingBlocked = jsonObject["domains_being_blocked"]?.ToString();
                string topADS = jsonObject["top_ads"]?.ToString();

                //MessageBox.Show(domainsBeingBlocked);
                // Exibir o valor na Label
                lblQtdeAnuncio.Text = topADS;

            }
            catch (Exception ex)
            {
                // Tratar exceções ao analisar a resposta JSON
                MessageBox.Show("Erro ao processar a resposta JSON: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private async Task<string> GetPiHoleData(string apiUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", "PiHoleApiClient");

                // Adicione o cabeçalho de autorização, se necessário
                // client.DefaultRequestHeaders.Add("Authorization", "Bearer " + authToken);

                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    return $"Error: {response.StatusCode}";
                }
            }
        }

        private async Task<string> PostPiHoleData(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", "PiHoleApiClient");

                // Adicione o cabeçalho de autorização, se necessário
                // client.DefaultRequestHeaders.Add("Authorization", "Bearer " + authToken);

                HttpResponseMessage response = await client.PostAsync(url, null);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    return $"Error: {response.StatusCode}";
                }
            }
        }
    }
}
