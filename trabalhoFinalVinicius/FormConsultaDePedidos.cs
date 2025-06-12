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
            carregarClienteNoDgv();
        }
    }
}
