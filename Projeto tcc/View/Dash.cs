using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;


namespace Projeto_tcc
{
    public partial class Dash : Form
    {
        
        //string apiToken = "0f1c0a417cb4a3c4648d38f67d4ff43346ce6ebb0e1ce54e61193808fb236ca3";
        string apiUrl = "http://192.168.0.103/admin/api.php?summary&auth=0f1c0a417cb4a3c4648d38f67d4ff43346ce6ebb0e1ce54e61193808fb236ca3"; // Substitua pelo IP do seu Raspberry

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
            //string summaryResponse = await GetPiHoleData(apiUrl);   
            //MessageBox.Show(summaryResponse);

            try
            {
                string summaryResponse = await GetPiHoleData(apiUrl);
                MessageBox.Show(summaryResponse);

                // Restante do seu código...
                // Desserializar a resposta JSON como um objeto
                JObject jsonObject = JObject.Parse(summaryResponse);

                // Obter o valor de "domains_being_blocked"
                string domainsBeingBlocked = jsonObject["domains_being_blocked"]?.ToString();
                string adsblockedtoday = jsonObject["ads_blocked_today"]?.ToString();
                string percentblocked = jsonObject["ads_percentage_today"]?.ToString();
                string dnsqueriestoday = jsonObject["dns_queries_today"]?.ToString();


                //MessageBox.Show(domainsBeingBlocked);
                // Exibir o valor na Label
                lblQtdeBlack.Text = domainsBeingBlocked;
                lblQtdeAnuncio.Text = adsblockedtoday;

                double adsblocked = Convert.ToDouble(adsblockedtoday);
                double valorAds = 1.75;
                lbl_bandaeco.Text = Convert.ToString(adsblocked * valorAds);
                double valorBanda = 0.002021;
                double resultado = (adsblocked * valorAds) * valorBanda;
                string resultadoFormatado = resultado.ToString("F2"); // "F2" especifica duas casas decimais

                lbl_economizados.Text = Convert.ToString(resultadoFormatado);
                lbl_porcentagem.Text = Convert.ToString(percentblocked);
                lbl_totalConsultas.Text = Convert.ToString(dnsqueriestoday);

            }
            catch (HttpRequestException ex)
            {
                if (ex.InnerException is SocketException socketException)
                {
                    // Lidar com a exceção SocketException específica
                    MessageBox.Show($"Erro de conexão: {socketException.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Se não for uma SocketException, trata de outra forma ou lança novamente.
                    MessageBox.Show($"Falha na conexão com o Pi Hole");
                }
            }
            catch (Exception ex)
            {
                // Tratar outras exceções que podem ocorrer
                MessageBox.Show($"Erro geral: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void lblQtdeBlack_Click(object sender, EventArgs e)
        {

        }

        private void lblQtdeAnuncio_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_bandaeco_Click(object sender, EventArgs e)
        {
            
        }

        private void lbl_economizados_Click(object sender, EventArgs e)
        {

        }

        private void lbl_porcentagem_Click(object sender, EventArgs e)
        {

        }

        private void lbl_totalConsultas_Click(object sender, EventArgs e)
        {

        }
    }
}
