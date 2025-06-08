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
            lblCadastroDeClientes = new Label();
            lblDigNome = new Label();
            txtNome = new TextBox();
            lblDigCpf = new Label();
            lblDigEmail = new Label();
            lblDigCep = new Label();
            lblTelefone = new Label();
            txtCpf = new TextBox();
            txtEmail = new TextBox();
            txtCep = new TextBox();
            this.txtTelefone = new TextBox();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // lblCadastroDeClientes
            // 
            lblCadastroDeClientes.AutoSize = true;
            lblCadastroDeClientes.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCadastroDeClientes.Location = new Point(251, 18);
            lblCadastroDeClientes.Name = "lblCadastroDeClientes";
            lblCadastroDeClientes.Size = new Size(450, 50);
            lblCadastroDeClientes.TabIndex = 0;
            lblCadastroDeClientes.Text = "CADASTRO DE CLIENTES ";
            // 
            // lblDigNome
            // 
            lblDigNome.AutoSize = true;
            lblDigNome.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDigNome.Location = new Point(66, 89);
            lblDigNome.Name = "lblDigNome";
            lblDigNome.Size = new Size(176, 30);
            lblDigNome.TabIndex = 1;
            lblDigNome.Text = "Digite seu nome: ";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(66, 139);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(276, 23);
            txtNome.TabIndex = 2;
            // 
            // lblDigCpf
            // 
            lblDigCpf.AutoSize = true;
            lblDigCpf.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDigCpf.Location = new Point(66, 181);
            lblDigCpf.Name = "lblDigCpf";
            lblDigCpf.Size = new Size(164, 30);
            lblDigCpf.TabIndex = 3;
            lblDigCpf.Text = "Digite seu CPF:  ";
            // 
            // lblDigEmail
            // 
            lblDigEmail.AutoSize = true;
            lblDigEmail.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDigEmail.Location = new Point(66, 270);
            lblDigEmail.Name = "lblDigEmail";
            lblDigEmail.Size = new Size(173, 30);
            lblDigEmail.TabIndex = 4;
            lblDigEmail.Text = "Digite seu Email: ";
            // 
            // lblDigCep
            // 
            lblDigCep.AutoSize = true;
            lblDigCep.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDigCep.Location = new Point(66, 360);
            lblDigCep.Name = "lblDigCep";
            lblDigCep.Size = new Size(159, 30);
            lblDigCep.TabIndex = 5;
            lblDigCep.Text = "Digite seu Cep: ";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefone.Location = new Point(66, 453);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(199, 30);
            lblTelefone.TabIndex = 6;
            lblTelefone.Text = "Digite seu telefone: ";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(66, 223);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(276, 23);
            txtCpf.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(66, 315);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(276, 23);
            txtEmail.TabIndex = 9;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(66, 408);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(276, 23);
            txtCep.TabIndex = 10;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new Point(66, 499);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new Size(276, 23);
            this.txtTelefone.TabIndex = 11;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(714, 562);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(157, 57);
            btnSalvar.TabIndex = 13;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // FormCadastroDeClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 669);
            Controls.Add(btnSalvar);
            Controls.Add(this.txtTelefone);
            Controls.Add(txtCep);
            Controls.Add(txtEmail);
            Controls.Add(txtCpf);
            Controls.Add(lblTelefone);
            Controls.Add(lblDigCep);
            Controls.Add(lblDigEmail);
            Controls.Add(lblDigCpf);
            Controls.Add(txtNome);
            Controls.Add(lblDigNome);
            Controls.Add(lblCadastroDeClientes);
            Name = "FormCadastroDeClientes";
            Text = "FormCadastroDeClientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCadastroDeClientes;
        private Label lblDigNome;
        private TextBox txtNome;
        private Label lblDigCpf;
        private Label lblDigEmail;
        private Label lblDigCep;
        private Label lblTelefone;
        private Label label5;
        private TextBox txtCpf;
        private TextBox txtEmail;
        private TextBox txtCep;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button btnSalvar;
    }
}