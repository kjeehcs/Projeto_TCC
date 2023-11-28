using Npgsql;
using Projeto_tcc.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;

namespace Projeto_tcc
{
    public partial class Listas : Form
    {
        public Listas()
        {
            InitializeComponent();
            CarregarDadosDaAPI();
        }
        private async void CarregarDadosDaAPI()
        {
            string url = "http://192.168.0.103/admin/api.php?list=regex_black&auth=0f1c0a417cb4a3c4648d38f67d4ff43346ce6ebb0e1ce54e61193808fb236ca3";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string json = await client.GetStringAsync(url);
                    var response = JsonConvert.DeserializeObject<ApiResponse>(json);

                    if (response?.Data != null)
                    {
                        dataGridBlackList.Columns.Clear();

                        DataGridViewTextBoxColumn colunaId = new DataGridViewTextBoxColumn();
                        colunaId.DataPropertyName = "Id";
                        colunaId.HeaderText = "Id";
                        dataGridBlackList.Columns.Add(colunaId);

                        DataGridViewTextBoxColumn colunaDomain = new DataGridViewTextBoxColumn();
                        colunaDomain.DataPropertyName = "Domain";
                        colunaDomain.HeaderText = "Domain";
                        dataGridBlackList.Columns.Add(colunaDomain);

                        dataGridBlackList.DataSource = response.Data;
                    }
                    else
                    {
                        MessageBox.Show("Os dados da API estão vazios ou em um formato não esperado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar dados da API: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public class ApiResponse
        {
            public List<ListaItem> Data { get; set; }
        }

        public class ListaItem
        {
            public int Id { get; set; }
            public string Domain { get; set; }
            
        }

        private async void btn_addlist_Click(object sender, EventArgs e)
        {
            string baseUrl = "http://192.168.0.103/admin/api.php";
            string lista = "regex_black";
            string auth = "0f1c0a417cb4a3c4648d38f67d4ff43346ce6ebb0e1ce54e61193808fb236ca3";

            try
            {
                if (string.IsNullOrWhiteSpace(Txb_Url.Text))
                {
                    MessageBox.Show("O campo de inserção está vazio. Preencha-o antes de prosseguir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }

                string domainParaInserir = Txb_Url.Text;

                var apiData = await ObterDadosDaAPI();

                if (apiData.Any(item => item.Domain.Equals(domainParaInserir, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show($"O valor '{domainParaInserir}' já existe na lista. Não é possível inserir duplicatas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }

                string url = $"{baseUrl}?list={lista}&add={domainParaInserir}&auth={auth}";

                using (HttpClient client = new HttpClient())
                {
                    var response = await client.PostAsync(url, null);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Inserção bem-sucedida!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CarregarDadosDaAPI();
                    }
                    else
                    {
                        MessageBox.Show($"Erro ao inserir dados. Código de status: {response.StatusCode}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar a inserção: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void btn_deletelist_Click(object sender, EventArgs e)
        {
            string baseUrl = "http://192.168.0.103/admin/api.php";
            string lista = "regex_black";
            string auth = "0f1c0a417cb4a3c4648d38f67d4ff43346ce6ebb0e1ce54e61193808fb236ca3";

            try
            {
                if (string.IsNullOrWhiteSpace(Txb_Url.Text))
                {
                    MessageBox.Show("O campo de exclusão está vazio. Preencha-o antes de prosseguir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }

                string domainParaDeletar = Txb_Url.Text;

                var apiData = await ObterDadosDaAPI();

                if (apiData.Any(item => item.Domain.Equals(domainParaDeletar, StringComparison.OrdinalIgnoreCase)))
                {
                    string url = $"{baseUrl}?list={lista}&sub={domainParaDeletar}&auth={auth}";

                    using (HttpClient client = new HttpClient())
                    {
                        var response = await client.DeleteAsync(url);

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Deletado com Sucesso!!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CarregarDadosDaAPI();
                        }
                        else
                        {
                            MessageBox.Show($"Erro ao deletar dados. Código de status: {response.StatusCode}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"O valor '{domainParaDeletar}' não existe na lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<List<ListaItem>> ObterDadosDaAPI()
        {
            string url = "http://192.168.0.103/admin/api.php?list=regex_black&auth=0f1c0a417cb4a3c4648d38f67d4ff43346ce6ebb0e1ce54e61193808fb236ca3";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string json = await client.GetStringAsync(url);
                    var response = JsonConvert.DeserializeObject<ApiResponse>(json);

                    return response.Data;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao obter dados da API: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }


        private void dataGridBlackList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Listas_Load(object sender, EventArgs e)
        {

        }
    }
}
