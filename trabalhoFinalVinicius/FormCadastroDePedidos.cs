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
                        string cpfClienteArquivo = campos[1].Trim(); ;
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
            dgvTotal.Columns.Add("Nome", "Nome do Produto");
            dgvTotal.Columns.Add("Preco", "Preço");
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


                            dgvTotal.Rows.Add(nomeProduto, $"R$ {precoProduto}");


                            // adicionar calculo do total 

                            return;
                        }
                    }
                }
                MessageBox.Show("Produto não encontrado.");
            }
        }

        private void calcularTotalDosProdutos()
        {
            double total = 0.0;

            if (dgvTotal.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum produto adicionado.");
                return;
            }




            int precoColIndex = -1;
            foreach (DataGridViewColumn column in dgvTotal.Columns)
            {
                if (column.HeaderText == "Preço")
                    {
                    precoColIndex = column.Index;
                    break;
                }
            }


            if (precoColIndex == -1)
            {
                precoColIndex = dgvTotal.Columns.Add("Preço", "Preço");   // adiciona a coluna de preco 
            }


            foreach (DataGridViewRow row in dgvTotal.Rows)
            {
                if (row.IsNewRow) continue;
                var cellValue = row.Cells[precoColIndex].Value;
                if (cellValue != null)
                {
                    string precoStr = cellValue.ToString().Replace("R$", "").Trim().Replace(",", ".");
                    if (double.TryParse(precoStr, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double preco))
                    {
                        total += preco;
                    }
                    else
                    {
                        MessageBox.Show($"Valor inválido na linha {row.Index + 1}: '{precoStr}' ");
                        return;
                    }
                }
            }
            dgvTotal.Rows.Add("Total",$"{total:F2}"); // Adiciona a linha de total
        }






        private void btnSalvar_Click(object sender, EventArgs e)
        {
            calcularTotalDosProdutos();
        }
    }
}
