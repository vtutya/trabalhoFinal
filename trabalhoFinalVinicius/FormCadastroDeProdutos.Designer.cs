namespace trabalhoFinalVinicius
{
    partial class FormCadastroDeProdutos
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
            lblCadastroDeProdutos = new Label();
            lblNomeProd = new Label();
            txtNomeProduto = new TextBox();
            lblPrecoProd = new Label();
            lblDescProd = new Label();
            txtPrecoProduto = new TextBox();
            txtDescricaoProduto = new TextBox();
            btnSalvar = new Button();
            dgvProdutos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // lblCadastroDeProdutos
            // 
            lblCadastroDeProdutos.AutoSize = true;
            lblCadastroDeProdutos.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCadastroDeProdutos.Location = new Point(242, 59);
            lblCadastroDeProdutos.Name = "lblCadastroDeProdutos";
            lblCadastroDeProdutos.Size = new Size(474, 50);
            lblCadastroDeProdutos.TabIndex = 0;
            lblCadastroDeProdutos.Text = "CADASTRO DE PRODUTOS";
            // 
            // lblNomeProd
            // 
            lblNomeProd.AutoSize = true;
            lblNomeProd.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomeProd.Location = new Point(74, 159);
            lblNomeProd.Name = "lblNomeProd";
            lblNomeProd.Size = new Size(266, 30);
            lblNomeProd.TabIndex = 1;
            lblNomeProd.Text = "Digite o nome do produto: ";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(74, 207);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(331, 23);
            txtNomeProduto.TabIndex = 2;
            // 
            // lblPrecoProd
            // 
            lblPrecoProd.AutoSize = true;
            lblPrecoProd.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecoProd.Location = new Point(74, 292);
            lblPrecoProd.Name = "lblPrecoProd";
            lblPrecoProd.Size = new Size(265, 30);
            lblPrecoProd.TabIndex = 3;
            lblPrecoProd.Text = "Digite o preço do produto: ";
            // 
            // lblDescProd
            // 
            lblDescProd.AutoSize = true;
            lblDescProd.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescProd.Location = new Point(74, 445);
            lblDescProd.Name = "lblDescProd";
            lblDescProd.Size = new Size(299, 30);
            lblDescProd.TabIndex = 4;
            lblDescProd.Text = "Digite a descrição do produto: ";
            // 
            // txtPrecoProduto
            // 
            txtPrecoProduto.Location = new Point(74, 354);
            txtPrecoProduto.Name = "txtPrecoProduto";
            txtPrecoProduto.Size = new Size(331, 23);
            txtPrecoProduto.TabIndex = 2;
            // 
            // txtDescricaoProduto
            // 
            txtDescricaoProduto.Location = new Point(74, 504);
            txtDescricaoProduto.Name = "txtDescricaoProduto";
            txtDescricaoProduto.Size = new Size(331, 23);
            txtDescricaoProduto.TabIndex = 2;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(671, 521);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(156, 72);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(517, 159);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.Size = new Size(370, 217);
            dgvProdutos.TabIndex = 6;
            // 
            // FormCadastroDeProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 663);
            Controls.Add(dgvProdutos);
            Controls.Add(btnSalvar);
            Controls.Add(lblDescProd);
            Controls.Add(lblPrecoProd);
            Controls.Add(txtDescricaoProduto);
            Controls.Add(txtPrecoProduto);
            Controls.Add(txtNomeProduto);
            Controls.Add(lblNomeProd);
            Controls.Add(lblCadastroDeProdutos);
            Name = "FormCadastroDeProdutos";
            Text = "FormCadastroDeProdutos";
            Load += FormCadastroDeProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCadastroDeProdutos;
        private Label lblNomeProd;
        private TextBox txtNomeProduto;
        private Label lblPrecoProd;
        private Label lblDescProd;
        private TextBox txtPrecoProduto;
        private TextBox txtDescricaoProduto;
        private Button btnSalvar;
        private DataGridView dgvProdutos;
    }
}