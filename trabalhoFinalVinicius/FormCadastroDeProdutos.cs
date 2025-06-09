using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalhoFinalVinicius
{
    public partial class FormCadastroDeProdutos : Form
    {
        public FormCadastroDeProdutos()
        {
            InitializeComponent();
        }

        private void FormCadastroDeProdutos_Load(object sender, EventArgs e)
        {
            carregarProdutosNoDataGridView()
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {   // ARRUMAR AQUI 

            //string caminhoCsv = "C:\\Users\\Usuario\\Documents\\RepositorioTrabalhoFinal\\trabalhoFinalVinicius\\produtos.csv";

            string nomeProduto = txtNomeProduto.Text.Trim();
            string precoProduto = txtPrecoProduto.Text.Trim();
            double precoDecimal = Convert.ToDouble(precoProduto);
            string descricaoProduto = txtDescricaoProduto.Text.Trim();

            if (string.IsNullOrEmpty(nomeProduto) || string.IsNullOrEmpty(precoProduto) || string.IsNullOrEmpty(descricaoProduto))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            try
            {
                using (StreamWriter sw = new StreamWriter(caminhoCsv, true))
                {
                    sw.WriteLine($"{nomeProduto},{precoDecimal},{descricaoProduto}");

                }
                MessageBox.Show("Produto salvo com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar produto: {ex.Message}");
            }

        }
        private void carregarProdutosNoDataGridView()
        {
            string caminhoCsv = "C:\\Users\\Usuario\\Documents\\RepositorioTrabalhoFinal\\trabalhoFinalVinicius\\produtos.csv";
            try
            {
                if (File.Exists(caminhoCsv))
                {
                    var linhas = File.ReadAllLines(caminhoCsv);
                    var produtos = new List<string[]>();
                    foreach (var linha in linhas)
                    {
                        var campos = linha.Split(',');
                        produtos.Add(campos);
                    }
                    dgvProdutos.DataSource = produtos.Select(p => new
                    {
                        Nome = p[0],
                        Preco = p[1],
                        Descricao = p[2]
                    }).ToList();
                }
                else
                {
                    MessageBox.Show("Arquivo de produtos não encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar produtos: {ex.Message}");
            }
        }
    }
}
