namespace trabalhoFinalVinicius
{
    partial class FormCadastroDePedidos
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
            lblCadDePedidos = new Label();
            lblDigCpf = new Label();
            txtCpf = new TextBox();
            btnVerificar = new Button();
            listProdutos = new ListBox();
            dgvTotal = new DataGridView();
            btnAdicionar = new Button();
            btnSalvar = new Button();
            txtNome = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvTotal).BeginInit();
            SuspendLayout();
            // 
            // lblCadDePedidos
            // 
            lblCadDePedidos.AutoSize = true;
            lblCadDePedidos.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCadDePedidos.Location = new Point(278, 9);
            lblCadDePedidos.Name = "lblCadDePedidos";
            lblCadDePedidos.Size = new Size(372, 45);
            lblCadDePedidos.TabIndex = 0;
            lblCadDePedidos.Text = "CADASTRO DE PEDIDOS";
            // 
            // lblDigCpf
            // 
            lblDigCpf.AutoSize = true;
            lblDigCpf.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDigCpf.Location = new Point(50, 92);
            lblDigCpf.Name = "lblDigCpf";
            lblDigCpf.Size = new Size(235, 30);
            lblDigCpf.TabIndex = 1;
            lblDigCpf.Text = "Digite o CPF do cliente: ";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(50, 134);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(335, 23);
            txtCpf.TabIndex = 2;
            // 
            // btnVerificar
            // 
            btnVerificar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerificar.Location = new Point(50, 175);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(116, 29);
            btnVerificar.TabIndex = 3;
            btnVerificar.Text = "VERIFICAR";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // listProdutos
            // 
            listProdutos.FormattingEnabled = true;
            listProdutos.ItemHeight = 15;
            listProdutos.Location = new Point(444, 72);
            listProdutos.Name = "listProdutos";
            listProdutos.Size = new Size(461, 154);
            listProdutos.TabIndex = 4;
            // 
            // dgvTotal
            // 
            dgvTotal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTotal.Location = new Point(50, 341);
            dgvTotal.Name = "dgvTotal";
            dgvTotal.Size = new Size(481, 233);
            dgvTotal.TabIndex = 5;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(800, 275);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(105, 23);
            btnAdicionar.TabIndex = 6;
            btnAdicionar.Text = "ADICIONAR";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(773, 588);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(107, 42);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(401, 276);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(335, 23);
            txtNome.TabIndex = 8;
            // 
            // FormCadastroDePedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 661);
            Controls.Add(txtNome);
            Controls.Add(btnSalvar);
            Controls.Add(btnAdicionar);
            Controls.Add(dgvTotal);
            Controls.Add(listProdutos);
            Controls.Add(btnVerificar);
            Controls.Add(txtCpf);
            Controls.Add(lblDigCpf);
            Controls.Add(lblCadDePedidos);
            Name = "FormCadastroDePedidos";
            Text = "FormCadastroDePedidos";
            Load += FormCadastroDePedidos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTotal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCadDePedidos;
        private Label lblDigCpf;
        private TextBox txtCpf;
        private Button btnVerificar;
        private ListBox listProdutos;
        private DataGridView dgvTotal;
        private Button btnAdicionar;
        private Button btnSalvar;
        private TextBox txtNome;
    }
}