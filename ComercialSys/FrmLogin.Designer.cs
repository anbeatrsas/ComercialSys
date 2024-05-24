namespace ComercialSys
{
    partial class FrmLogin
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
            btnConfirmar = new Button();
            btnCancelar = new Button();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(167, 259);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 0;
            btnConfirmar.Text = "&Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(306, 259);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancela&r";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(167, 204);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(144, 23);
            txtSenha.TabIndex = 1;
            txtSenha.UseSystemPasswordChar = true;

            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(167, 144);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(214, 23);
            txtEmail.TabIndex = 1;

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.ForeColor = SystemColors.InfoText;
            label1.Location = new Point(167, 123);
            label1.Name = "label1";
            label1.Size = new Size(39, 17);
            label1.TabIndex = 2;
            label1.Text = "Email";

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.ForeColor = SystemColors.InfoText;
            label2.Location = new Point(167, 183);
            label2.Name = "label2";
            label2.Size = new Size(43, 17);
            label2.TabIndex = 2;
            label2.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(183, 59);
            label3.Name = "label3";
            label3.Size = new Size(187, 37);
            label3.TabIndex = 3;
            label3.Text = "ComercialSys";
            label3.Click += label3_Click;
            // 
            // FrmLogin
            // 
            AcceptButton = btnConfirmar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            CancelButton = btnCancelar;
            ClientSize = new Size(557, 344);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(txtSenha);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            Text = "FrmLogin";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmar;
        private Button btnCancelar;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}