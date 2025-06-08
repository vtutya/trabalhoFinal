namespace trabalhoFinalVinicius
{
    partial class FormPrincipal
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
            lblFrmPrincipal = new Label();
            btnCadastrarClientes = new Button();
            btnCadastarProdutos = new Button();
            btnCadastrarPedidos = new Button();
            btnCadastrarUsuarios = new Button();
            SuspendLayout();
            // 
            // lblFrmPrincipal
            // 
            lblFrmPrincipal.AutoSize = true;
            lblFrmPrincipal.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFrmPrincipal.Location = new Point(400, 80);
            lblFrmPrincipal.Name = "lblFrmPrincipal";
            lblFrmPrincipal.Size = new Size(207, 50);
            lblFrmPrincipal.TabIndex = 0;
            lblFrmPrincipal.Text = "PRINCIPAL";
            // 
            // btnCadastrarClientes
            // 
            btnCadastrarClientes.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrarClientes.Location = new Point(123, 228);
            btnCadastrarClientes.Name = "btnCadastrarClientes";
            btnCadastrarClientes.Size = new Size(259, 55);
            btnCadastrarClientes.TabIndex = 1;
            btnCadastrarClientes.Text = "Cadastrar Clientes";
            btnCadastrarClientes.UseVisualStyleBackColor = true;
            // 
            // btnCadastarProdutos
            // 
            btnCadastarProdutos.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastarProdutos.Location = new Point(123, 320);
            btnCadastarProdutos.Name = "btnCadastarProdutos";
            btnCadastarProdutos.Size = new Size(259, 55);
            btnCadastarProdutos.TabIndex = 2;
            btnCadastarProdutos.Text = "Cadastrar Produtos";
            btnCadastarProdutos.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarPedidos
            // 
            btnCadastrarPedidos.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrarPedidos.Location = new Point(123, 404);
            btnCadastrarPedidos.Name = "btnCadastrarPedidos";
            btnCadastrarPedidos.Size = new Size(259, 55);
            btnCadastrarPedidos.TabIndex = 3;
            btnCadastrarPedidos.Text = "Cadastrar Pedidos";
            btnCadastrarPedidos.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarUsuarios
            // 
            btnCadastrarUsuarios.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrarUsuarios.Location = new Point(123, 482);
            btnCadastrarUsuarios.Name = "btnCadastrarUsuarios";
            btnCadastrarUsuarios.Size = new Size(259, 55);
            btnCadastrarUsuarios.TabIndex = 4;
            btnCadastrarUsuarios.Text = "Cadastrar Usuários";
            btnCadastrarUsuarios.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 644);
            Controls.Add(btnCadastrarUsuarios);
            Controls.Add(btnCadastrarPedidos);
            Controls.Add(btnCadastarProdutos);
            Controls.Add(btnCadastrarClientes);
            Controls.Add(lblFrmPrincipal);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFrmPrincipal;
        private Button btnCadastrarClientes;
        private Button btnCadastarProdutos;
        private Button btnCadastrarPedidos;
        private Button btnCadastrarUsuarios;
    }
}