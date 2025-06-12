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
            
            string idProduto = txtIdProduto.Text.Trim();
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

            if (File.Exists(caminhoCsv))
            {
                var linhas = File.ReadAllLines(caminhoCsv);
                var produtos = new List<string[]>();
                foreach (var linha in linhas)
                {
                    var dados = linha.Split(',');
                    if (dados.Length == 3)
                    {
                        produtos.Add(dados);
                    }

                }
                dgvProdutos.DataSource = produtos.Select(p => new
                {
                    CodigoProduto = p[0],
                    NomeProduto = p[1],
                    PrecoProduto = Convert.ToDouble(p[2]),
                    DescricaoProduto = p[3]
                }).ToList();

            }
        }
    }
}

