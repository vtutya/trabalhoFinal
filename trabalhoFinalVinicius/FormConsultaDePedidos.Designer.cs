namespace trabalhoFinalVinicius
{
    partial class FormConsultaDePedidos
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
            dgvPedidos = new DataGridView();
            btnEnviar = new Button();
            lblDigCpf = new Label();
            txtCpf = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            SuspendLayout();
            // 
            // dgvPedidos
            // 
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Location = new Point(397, 322);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.Size = new Size(438, 172);
            dgvPedidos.TabIndex = 0;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(737, 160);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 1;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // lblDigCpf
            // 
            lblDigCpf.AutoSize = true;
            lblDigCpf.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDigCpf.Location = new Point(397, 43);
            lblDigCpf.Name = "lblDigCpf";
            lblDigCpf.Size = new Size(144, 32);
            lblDigCpf.TabIndex = 2;
            lblDigCpf.Text = "Digite o cpf:";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(397, 109);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(347, 23);
            txtCpf.TabIndex = 3;
            // 
            // FormConsultaDePedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 848);
            Controls.Add(txtCpf);
            Controls.Add(lblDigCpf);
            Controls.Add(btnEnviar);
            Controls.Add(dgvPedidos);
            Name = "FormConsultaDePedidos";
            Text = "FormConsultaDePedidos";
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPedidos;
        private Button btnEnviar;
        private Label lblDigCpf;
        private TextBox txtCpf;
    }
}