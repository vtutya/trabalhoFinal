namespace trabalhoFinalVinicius
{
    partial class FormCadastroDeUsuarios
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
            lblCadUsuarios = new Label();
            lblNomeDeUsu = new Label();
            txtNomeUser = new TextBox();
            lblSenhaUsuario = new Label();
            txtSenhaUser = new TextBox();
            btnEnviar = new Button();
            SuspendLayout();
            // 
            // lblCadUsuarios
            // 
            lblCadUsuarios.AutoSize = true;
            lblCadUsuarios.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCadUsuarios.Location = new Point(252, 9);
            lblCadUsuarios.Name = "lblCadUsuarios";
            lblCadUsuarios.Size = new Size(457, 50);
            lblCadUsuarios.TabIndex = 0;
            lblCadUsuarios.Text = "CADASTRO DE USUARIOS";
            // 
            // lblNomeDeUsu
            // 
            lblNomeDeUsu.AutoSize = true;
            lblNomeDeUsu.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomeDeUsu.Location = new Point(52, 117);
            lblNomeDeUsu.Name = "lblNomeDeUsu";
            lblNomeDeUsu.Size = new Size(259, 30);
            lblNomeDeUsu.TabIndex = 1;
            lblNomeDeUsu.Text = "Digite o nome de usuário: ";
            // 
            // txtNomeUser
            // 
            txtNomeUser.Location = new Point(52, 159);
            txtNomeUser.Name = "txtNomeUser";
            txtNomeUser.Size = new Size(358, 23);
            txtNomeUser.TabIndex = 2;
            // 
            // lblSenhaUsuario
            // 
            lblSenhaUsuario.AutoSize = true;
            lblSenhaUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSenhaUsuario.Location = new Point(52, 213);
            lblSenhaUsuario.Name = "lblSenhaUsuario";
            lblSenhaUsuario.Size = new Size(157, 30);
            lblSenhaUsuario.TabIndex = 3;
            lblSenhaUsuario.Text = "Digite a senha: ";
            // 
            // txtSenhaUser
            // 
            txtSenhaUser.Location = new Point(52, 261);
            txtSenhaUser.Name = "txtSenhaUser";
            txtSenhaUser.Size = new Size(358, 23);
            txtSenhaUser.TabIndex = 4;
            // 
            // btnEnviar
            // 
            btnEnviar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnviar.Location = new Point(383, 317);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(116, 34);
            btnEnviar.TabIndex = 5;
            btnEnviar.Text = "ENVIAR";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // FormCadastroDeUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 663);
            Controls.Add(btnEnviar);
            Controls.Add(txtSenhaUser);
            Controls.Add(lblSenhaUsuario);
            Controls.Add(txtNomeUser);
            Controls.Add(lblNomeDeUsu);
            Controls.Add(lblCadUsuarios);
            Name = "FormCadastroDeUsuarios";
            Text = "FormCadastroDeUsuarios";
            Load += FormCadastroDeUsuarios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCadUsuarios;
        private Label lblNomeDeUsu;
        private TextBox txtNomeUser;
        private Label lblSenhaUsuario;
        private TextBox txtSenhaUser;
        private Button btnEnviar;
    }
}