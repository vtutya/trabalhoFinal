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
    public partial class FormCadastroDeUsuarios : Form
    {
        public FormCadastroDeUsuarios()
        {
            InitializeComponent();
        }

        private void FormCadastroDeUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string nomeUsu = txtNomeUser.Text.Trim();
            string senhaUsu = txtSenhaUser.Text.Trim();
            string caminhoCsv = "C:\\Users\\Usuario\\Documents\\RepositorioTrabalhoFinal\\trabalhoFinalVinicius\\usuarios.csv";

            if (string.IsNullOrWhiteSpace(nomeUsu) || string.IsNullOrWhiteSpace(senhaUsu))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            string novaLinha = $"{nomeUsu},{senhaUsu}";
            try
            {
                System.IO.File.AppendAllText(caminhoCsv, Environment.NewLine + novaLinha);
                MessageBox.Show("Usuário cadastrado com sucesso!");
                txtNomeUser.Clear();
                txtSenhaUser.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar usuário: {ex.Message}");
            }
        }
    }
}
