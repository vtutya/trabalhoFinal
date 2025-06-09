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
            carregarProdutosNoDataGridView();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string caminhoCsv = "C:\\Users\\Usuario\\Documents\\RepositorioTrabalhoFinal\\trabalhoFinalVinicius\\produtos.csv";

            string nomeProduto = txtNomeProduto.Text.Trim();
            string precoProduto = txtPrecoProduto.Text.Trim();
            double precoDecimal = Convert.ToDouble(precoProduto);
            string descricaoProduto = txtDescricaoProduto.Text.Trim();

            string novaLinha = $"{nomeProduto},{precoDecimal},{descricaoProduto}";

            File.AppendAllText(caminhoCsv, Environment.NewLine + novaLinha);

            MessageBox.Show("Produto salvo com sucesso!");
            carregarProdutosNoDataGridView();
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

                    int contador = 0;
                    if (linhas.Length > 0 && linhas[0].StartsWith("Nome"))
                        contador = 1;

                    for (int i = contador; i < linhas.Length; i++)
                    {
                        var campos = linhas[i].Split(',');
                        if (campos.Length == 3)
                            produtos.Add(campos);
                    }
                    dgvProdutos.DataSource = produtos.Select(p => new
                    {
                        Nome = p[0],
                        Preço = p[1],
                        Descrição = p[2]
                    }).ToList();
                }
                else
                {
                    dgvProdutos.DataSource = null;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro ao carregar produtos: {e.Message}");
            }
        }
    }
}

