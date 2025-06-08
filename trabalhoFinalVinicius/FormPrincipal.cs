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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadastrarClientes_Click(object sender, EventArgs e)
        {
            FormCadastroDeClientes formCadastroDeClientes = new FormCadastroDeClientes();
            formCadastroDeClientes.Show();
            this.Hide();
        }

        private void btnCadastarProdutos_Click(object sender, EventArgs e)
        {
            FormCadastroDeProdutos formCadastroDeProdutos = new FormCadastroDeProdutos();
            formCadastroDeProdutos.Show();
            this.Hide();
        }

        private void btnCadastrarPedidos_Click(object sender, EventArgs e)
        {
            FormCadastroDePedidos formCadastroDePedidos = new FormCadastroDePedidos();
            formCadastroDePedidos.Show();
            this.Hide();
        }

        private void btnCadastrarUsuarios_Click(object sender, EventArgs e)
        {
            FormCadastroDeUsuarios formCadastroDeUsuarios = new FormCadastroDeUsuarios();
            formCadastroDeUsuarios.Show();
            this.Hide();
        }
    }
}
