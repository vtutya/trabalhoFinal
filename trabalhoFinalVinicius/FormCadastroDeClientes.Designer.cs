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
            txtNomeCliente = new TextBox();
            txtCpfClient = new TextBox();
            txtEmail = new TextBox();
            txtCep = new TextBox();
            txtTelefone = new TextBox();
            lblCpf = new Label();
            lblEmailClient = new Label();
            lblCepClient = new Label();
            lblTelefoneClient = new Label();
            btnSalvar = new Button();
            dgvClientes = new DataGridView();
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
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(52, 187);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(274, 23);
            txtNomeCliente.TabIndex = 2;
            // 
            // txtCpfClient
            // 
            txtCpfClient.Location = new Point(52, 292);
            txtCpfClient.Name = "txtCpfClient";
            txtCpfClient.Size = new Size(274, 23);
            txtCpfClient.TabIndex = 3;
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
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCpf.Location = new Point(52, 247);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(135, 30);
            lblCpf.TabIndex = 7;
            lblCpf.Text = "Digite o Cpf: ";
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
            btnSalvar.Location = new Point(688, 586);
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
            dgvClientes.Location = new Point(448, 202);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(416, 265);
            dgvClientes.TabIndex = 12;
            // 
            // FormCadastroDeClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 670);
            Controls.Add(dgvClientes);
            Controls.Add(btnSalvar);
            Controls.Add(lblTelefoneClient);
            Controls.Add(lblCepClient);
            Controls.Add(lblEmailClient);
            Controls.Add(lblCpf);
            Controls.Add(txtTelefone);
            Controls.Add(txtCep);
            Controls.Add(txtEmail);
            Controls.Add(txtCpfClient);
            Controls.Add(txtNomeCliente);
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
        private TextBox txtNomeCliente;
        private TextBox txtCpfClient;
        private TextBox txtEmail;
        private TextBox txtCep;
        private TextBox txtTelefone;
        private Label lblCpf;
        private Label lblEmailClient;
        private Label lblCepClient;
        private Label lblTelefoneClient;
        private Button btnSalvar;
        private DataGridView dgvClientes;
    }
}