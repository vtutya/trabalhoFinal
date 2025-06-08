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

namespace trabalhoFinalVinicius
{
    public partial class FormCadastroDeClientes : Form
    {
        private static readonly HttpClient httpClient = new HttpClient();
        public FormCadastroDeClientes()
        {
            
            InitializeComponent();
        }

        private void buscarCep()
        {
            string cep = txtCep.Text.Trim();
            if (cep.Length != 8)
            {
                MessageBox.Show("CEP inválido. Deve conter 8 dígitos.");
                return;
            }
            else
            {
                try
                {
                    string url = $"https://viacep.com.br/ws/{cep}/json/";
                    var response = httpClient.GetAsync(url).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var content = response.Content.ReadAsStringAsync().Result;
                        dynamic json = Newtonsoft.Json.JsonConvert.DeserializeObject(content);
                        if (json != null && json.logradouro != null)
                        {
                            var logadouro = json.logradouro;
                            var bairro = json.bairro;
                            var cidade = json.localidade;
                            var utf = json.uf;
                        }
                        else
                        {
                            MessageBox.Show("CEP não encontrado.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro ao buscar CEP.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                }
            }
        }

        private void FormCadastroDeClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
