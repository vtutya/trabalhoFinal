namespace trabalhoFinalVinicius
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text.Trim();
            string senha = txtSenha.Text.Trim();
            string caminhoCsv = "C:\\Users\\Usuario\\Documents\\RepositorioTrabalhoFinal\\user.csv";
            bool autenticado = false;

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
                        string usuarioCsv = campos[0].Trim();
                        string senhaCsv = campos[1].Trim();

                        if (usuarioCsv == "ADMIN" && senhaCsv == "123")
                        {
                            autenticado = true;
                            MessageBox.Show("Usuário autenticado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FormPrincipal formPrincipal = new FormPrincipal();
                            formPrincipal.Show();
                            break;
                        }
                    }
                }
            }
        }
    }
}