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

            try
            {
                string url = $"https://viacep.com.br/ws/{cep}/json/";
                var response = httpClient.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                    dynamic json = JsonConvert.DeserializeObject(content);
                    if (json != null && json.logradouro != null)
                    {
                        txtLogadouro.Text = json.logradouro;
                        txtBairro.Text = json.bairro;

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
    

        private void FormCadastroDeClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string caminhoCsv = "C:\\Users\\Usuario\\Documents\\RepositorioTrabalhoFinal\\trabalhoFinalVinicius\\clientes.csv";

            string nome = txtNome.Text.Trim();
            string cpf = txtCpf.Text.Trim();
            string cep = txtCep.Text.Trim();
            buscarCep();
            string logradouro = txtLogadouro.Text.Trim();
            string bairro = txtBairro.Text.Trim();
            string telefone = txtTelefone.Text.Trim();  


            string novaLinha = $"{nome},{cpf},{cep},{logradouro},{bairro},{telefone}";

            File.AppendAllText(caminhoCsv, Environment.NewLine + novaLinha);

            MessageBox.Show("Cliente cadastrado com sucesso!");

            CarregarClientesNoDataGridView();
        }

        private void CarregarClientesNoDataGridView()
        {
            string caminhoCsv = "C:\\Users\\Usuario\\Documents\\RepositorioTrabalhoFinal\\trabalhoFinalVinicius\\clientes.csv";
            if (File.Exists(caminhoCsv))
            {
                var linhas = File.ReadAllLines(caminhoCsv);
                var clientes = new List<string[]>();
                foreach (var linha in linhas)
                {
                    var dados = linha.Split(',');
                    if (dados.Length == 6)
                    {
                        clientes.Add(dados);
                    }
                }
                dgvClientes.DataSource = clientes.Select(c => new
                {
                    Nome = c[0],
                    CPF = c[1],
                    Email = c[2],
                    CEP = c[3],
                    Logradouro = c[4],
                    Bairro = c[5],
                }).ToList();
            }
        }
    }
}
