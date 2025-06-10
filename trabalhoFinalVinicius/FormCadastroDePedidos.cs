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
            carregarClientesNoDgv();
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string caminhoCsv = "C:\\Users\\Usuario\\Documents\\RepositorioTrabalhoFinal\\trabalhoFinalVinicius\\clientes.csv";
            string cpf = txtCpf.Text.Trim();

            using (StreamReader sr = new StreamReader(caminhoCsv))
            {
                string linha;
                bool clienteEncontrado = false;
                while ((linha = sr.ReadLine()) != null)
                {
                    string[] campos = linha.Split(';');
                    if (campos.Length >= 2 && campos[0].Trim() == cpf)
                    {
                        clienteEncontrado = true;
                        carregarClientesNoDgv();
                        break;
                    }
                }
            }
        }
        private void carregarClientesNoDgv()
        {
            string caminhoCsv = "C:\\Users\\Usuario\\Documents\\RepositorioTrabalhoFinal\\trabalhoFinalVinicius\\clientes.csv";
            using (StreamReader sr = new StreamReader(caminhoCsv))
            {
                string linha;
                bool primeiraLinha = true;
                while ((linha = sr.ReadLine()) != null)
                {
                    if (primeiraLinha)
                    {
                        primeiraLinha = false;
                        continue;
                    }


                    string[] campos = linha.Split(';');
                    if (campos.Length >= 2)
                    {
                        string cpf = campos[0].Trim();
                        string nome = campos[1].Trim();
                        dgvTotal.Rows.Add(cpf, nome);
                    }
                }
            }
        }

        private void FormCadastroDePedidos_Load(object sender, EventArgs e)
        {
            carregarClientesNoDgv();
        }
    }
}
