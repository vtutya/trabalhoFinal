namespace trabalhoFinalVinicius
{
    partial class FormCadastroDeClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCadClientes = new Label();
            lblNomeClient = new Label();
            txtNome = new TextBox();
            txtCpf = new TextBox();
            txtEmail = new TextBox();
            txtCep = new TextBox();
            txtTelefone = new TextBox();
            lblCpfClient = new Label();
            lblEmailClient = new Label();
            lblCepClient = new Label();
            lblTelefoneClient = new Label();
            btnSalvar = new Button();
            dgvClientes = new DataGridView();
            txtLogadouro = new TextBox();
            txtBairro = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // lblCadClientes
            // 
            lblCadClientes.AutoSize = true;
            lblCadClientes.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCadClientes.Location = new Point(252, 62);
            lblCadClientes.Name = "lblCadClientes";
            lblCadClientes.Size = new Size(440, 50);
            lblCadClientes.TabIndex = 0;
            lblCadClientes.Text = "CADASTRO DE CLIENTES";
            // 
            // lblNomeClient
            // 
            lblNomeClient.AutoSize = true;
            lblNomeClient.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomeClient.Location = new Point(52, 142);
            lblNomeClient.Name = "lblNomeClient";
            lblNomeClient.Size = new Size(156, 30);
            lblNomeClient.TabIndex = 1;
            lblNomeClient.Text = "Digite o nome: ";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(52, 187);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(274, 23);
            txtNome.TabIndex = 2;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(52, 292);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(274, 23);
            txtCpf.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(52, 388);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(274, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(52, 489);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(274, 23);
            txtCep.TabIndex = 5;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(52, 604);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(274, 23);
            txtTelefone.TabIndex = 6;
            // 
            // lblCpfClient
            // 
            lblCpfClient.AutoSize = true;
            lblCpfClient.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCpfClient.Location = new Point(52, 247);
            lblCpfClient.Name = "lblCpfClient";
            lblCpfClient.Size = new Size(135, 30);
            lblCpfClient.TabIndex = 7;
            lblCpfClient.Text = "Digite o Cpf: ";
            // 
            // lblEmailClient
            // 
            lblEmailClient.AutoSize = true;
            lblEmailClient.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmailClient.Location = new Point(52, 341);
            lblEmailClient.Name = "lblEmailClient";
            lblEmailClient.Size = new Size(153, 30);
            lblEmailClient.TabIndex = 8;
            lblEmailClient.Text = "Digite o Email: ";
            // 
            // lblCepClient
            // 
            lblCepClient.AutoSize = true;
            lblCepClient.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCepClient.Location = new Point(52, 437);
            lblCepClient.Name = "lblCepClient";
            lblCepClient.Size = new Size(139, 30);
            lblCepClient.TabIndex = 9;
            lblCepClient.Text = "Digite o CEP: ";
            // 
            // lblTelefoneClient
            // 
            lblTelefoneClient.AutoSize = true;
            lblTelefoneClient.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefoneClient.Location = new Point(52, 550);
            lblTelefoneClient.Name = "lblTelefoneClient";
            lblTelefoneClient.Size = new Size(179, 30);
            lblTelefoneClient.TabIndex = 10;
            lblTelefoneClient.Text = "Digite o telefone: ";
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(840, 604);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(176, 56);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(662, 146);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(416, 265);
            dgvClientes.TabIndex = 12;
            // 
            // txtLogadouro
            // 
            txtLogadouro.Location = new Point(402, 187);
            txtLogadouro.Name = "txtLogadouro";
            txtLogadouro.Size = new Size(237, 23);
            txtLogadouro.TabIndex = 17;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(402, 292);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(237, 23);
            txtBairro.TabIndex = 18;
            // 
            // FormCadastroDeClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 765);
            Controls.Add(txtBairro);
            Controls.Add(txtLogadouro);
            Controls.Add(dgvClientes);
            Controls.Add(btnSalvar);
            Controls.Add(lblTelefoneClient);
            Controls.Add(lblCepClient);
            Controls.Add(lblEmailClient);
            Controls.Add(lblCpfClient);
            Controls.Add(txtTelefone);
            Controls.Add(txtCep);
            Controls.Add(txtEmail);
            Controls.Add(txtCpf);
            Controls.Add(txtNome);
            Controls.Add(lblNomeClient);
            Controls.Add(lblCadClientes);
            Name = "FormCadastroDeClientes";
            Text = "FormCadastroDeClientes";
            Load += FormCadastroDeClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCadClientes;
        private Label lblNomeClient;
        private TextBox txtNome;
        private TextBox txtCpf;
        private TextBox txtEmail;
        private TextBox txtCep;
        private TextBox txtTelefone;
        private Label lblCpfClient;
        private Label lblEmailClient;
        private Label lblCepClient;
        private Label lblTelefoneClient;
        private Button btnSalvar;
        private DataGridView dgvClientes;
        private TextBox txtLogadouro;
        private TextBox txtBairro;
    }
}