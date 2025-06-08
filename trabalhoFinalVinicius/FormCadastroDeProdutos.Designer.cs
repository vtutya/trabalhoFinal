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
            SuspendLayout();
            // 
            // lblCadastroDeProdutos
            // 
            lblCadastroDeProdutos.AutoSize = true;
            lblCadastroDeProdutos.Location = new Point(389, 61);
            lblCadastroDeProdutos.Name = "lblCadastroDeProdutos";
            lblCadastroDeProdutos.Size = new Size(38, 15);
            lblCadastroDeProdutos.TabIndex = 0;
            lblCadastroDeProdutos.Text = "label1";
            // 
            // FormCadastroDeProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 663);
            Controls.Add(lblCadastroDeProdutos);
            Name = "FormCadastroDeProdutos";
            Text = "FormCadastroDeProdutos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCadastroDeProdutos;
    }
}