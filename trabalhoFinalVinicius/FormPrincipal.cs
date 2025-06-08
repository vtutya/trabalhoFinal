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
            formCadastroDeClientes.ShowDialog();
            this.Hide();
        }
    }
}
