namespace trabalhoFinalVinicius
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblLogin = new Label();
            lblDigUser = new Label();
            lblDigSenha = new Label();
            txtUser = new TextBox();
            txtSenha = new TextBox();
            btnEnviar = new Button();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Arial Black", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(370, 51);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(153, 52);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "LOGIN";
            // 
            // lblDigUser
            // 
            lblDigUser.AutoSize = true;
            lblDigUser.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDigUser.Location = new Point(113, 175);
            lblDigUser.Name = "lblDigUser";
            lblDigUser.Size = new Size(259, 40);
            lblDigUser.TabIndex = 1;
            lblDigUser.Text = "Digite seu usuário: ";
            // 
            // lblDigSenha
            // 
            lblDigSenha.AutoSize = true;
            lblDigSenha.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDigSenha.Location = new Point(113, 383);
            lblDigSenha.Name = "lblDigSenha";
            lblDigSenha.Size = new Size(240, 40);
            lblDigSenha.TabIndex = 2;
            lblDigSenha.Text = "Digite sua senha: ";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(113, 244);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(335, 23);
            txtUser.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(113, 467);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(335, 23);
            txtSenha.TabIndex = 4;
            // 
            // btnEnviar
            // 
            btnEnviar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnviar.Location = new Point(752, 572);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(130, 51);
            btnEnviar.TabIndex = 5;
            btnEnviar.Text = "ENVIAR";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 655);
            Controls.Add(btnEnviar);
            Controls.Add(txtSenha);
            Controls.Add(txtUser);
            Controls.Add(lblDigSenha);
            Controls.Add(lblDigUser);
            Controls.Add(lblLogin);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private Label lblDigUser;
        private Label lblDigSenha;
        private TextBox txtUser;
        private TextBox txtSenha;
        private Button btnEnviar;
    }
}
