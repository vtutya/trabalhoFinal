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
    public partial class FormConsultaDePedidos : Form
    {
        public FormConsultaDePedidos()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            carregarClientesNoDgv();
        }

        private void carregarClientesNoDgv()
        {
            string caminhoCsv = "C:\\Users\\Usuario\\Documents\\RepositorioTrabalhoFinal\\trabalhoFinalVinicius\\pedidos.csv";
            try
            {
                if (System.IO.File.Exists(caminhoCsv))
                {
                    var linhas = System.IO.File.ReadAllLines(caminhoCsv);
                    dgvPedidos.Rows.Clear();
                    foreach (var linha in linhas)
                    {
                        var colunas = linha.Split(',');
                        if (colunas.Length >= 3) // Verifica se há pelo menos 3 colunas
                        {
                            dgvPedidos.Rows.Add(colunas[0], colunas[1], colunas[2], colunas[3]);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Arquivo de pedidos não encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar pedidos: {ex.Message}");
            }
        }
    }
}
