using System;
using System.IO;
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
    public partial class FormCadastroDePedidos : Form
    {
        public FormCadastroDePedidos()
        {

            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string caminhoCsvClientes = "C:\\Users\\Usuario\\Documents\\RepositorioTrabalhoFinal\\trabalhoFinalVinicius\\clientes.csv";
            string nomeCliente = null;
            string cpfCliente = txtCpf.Text.Trim();
            if (File.Exists(caminhoCsvClientes))
            {
            
                string[] linhas = File.ReadAllLines(caminhoCsvClientes);
                if (linhas.Length <= 1)
                {
                    MessageBox.Show("Nenhum cliente cadastrado.");
                    return;
                }
                for (int i = 1; i < linhas.Length; i++)
                {
                    if (string.IsNullOrWhiteSpace(linhas[i])) continue;
                    string[] campos = linhas[i].Split(';');
                    if (campos.Length >= 2)
                    {
                        string nomeClienteCsv = campos[0].Trim();
                        string cpfClienteArquivo = campos[1].Trim();;
                        dgvTotal.Columns.Add(nomeClienteCsv, cpfCliente);
                    }
                }
            }

        }

        private void exibirProdutosNaLista()
        {
            string caminhoCsvProdutos = "C:\\Users\\Usuario\\Documents\\RepositorioTrabalhoFinal\\trabalhoFinalVinicius\\produtos.csv";
            if (File.Exists(caminhoCsvProdutos))
            {
                string[] linhas = File.ReadAllLines(caminhoCsvProdutos);
                if (linhas.Length <= 1)
                {
                    MessageBox.Show("Nenhum produto cadastrado.");
                    return;
                }
                for (int i = 1; i < linhas.Length; i++)
                {
                    if (string.IsNullOrWhiteSpace(linhas[i])) continue;
                    string[] campos = linhas[i].Split(';');
                    if (campos.Length >= 3)
                    {
                        string idProduto = campos[0].Trim();
                        string nomeProduto = campos[1].Trim();
                        string precoProduto = campos[2].Trim();
                        listProdutos.Items.Add($" {idProduto} - {nomeProduto} - R$ {precoProduto}");
                    }
                }
            }
        }

        private void FormCadastroDePedidos_Load(object sender, EventArgs e)
        {
            exibirProdutosNaLista();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string iDProdString = txtId.Text.Trim();
            int idProduto = Convert.ToInt32(iDProdString);
            string caminhoCsvProdutos = "C:\\Users\\Usuario\\Documents\\RepositorioTrabalhoFinal\\trabalhoFinalVinicius\\produtos.csv";

            if (File.Exists(caminhoCsvProdutos))
            {
                string[] linhas = File.ReadAllLines(caminhoCsvProdutos);
                if (linhas.Length <= 1)
                {
                    MessageBox.Show("Nenhum produto cadastrado.");
                    return;
                }
                for (int i = 1; i < linhas.Length; i++)
                {
                    if (string.IsNullOrWhiteSpace(linhas[i])) continue;
                    string[] campos = linhas[i].Split(';');
                    if (campos.Length >= 3)
                    {
                        int idProdutoArquivo = Convert.ToInt32(campos[0].Trim());
                        if (idProdutoArquivo == idProduto)
                        {
                            string nomeProduto = campos[1].Trim();
                            string precoProduto = campos[2].Trim();
                            

                            dgvTotal.Rows.Add(nomeProduto, precoProduto);
                            return;
                        }
                    }
                }
                MessageBox.Show("Produto não encontrado.");
            }
        }
    }
}
