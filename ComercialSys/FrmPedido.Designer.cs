namespace ComercialSys
{
    partial class FrmPedido
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
            label1 = new Label();
            groupBox = new GroupBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label3 = new Label();
            txtVendedor = new TextBox();
            btnAbrirPedido = new Button();
            groupBox1 = new GroupBox();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 34);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(textBox3);
            groupBox.Controls.Add(textBox2);
            groupBox.Location = new Point(81, 191);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(622, 108);
            groupBox.TabIndex = 1;
            groupBox.TabStop = false;
            groupBox.Text = "Dados Cliente";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(152, 43);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(421, 23);
            textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(28, 43);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(618, 34);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Número";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.ForeColor = Color.Red;
            textBox1.Location = new Point(675, 34);
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.Yes;
            textBox1.Size = new Size(100, 34);
            textBox1.TabIndex = 3;
            textBox1.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(335, 29);
            label6.Name = "label6";
            label6.Size = new Size(125, 45);
            label6.TabIndex = 7;
            label6.Text = "Pedido";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(357, 74);
            label7.Name = "label7";
            label7.Size = new Size(73, 13);
            label7.TabIndex = 8;
            label7.Text = "ComercialSys";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 138);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 9;
            label3.Text = "Vendedor";
            // 
            // txtVendedor
            // 
            txtVendedor.Location = new Point(144, 135);
            txtVendedor.Name = "txtVendedor";
            txtVendedor.ReadOnly = true;
            txtVendedor.Size = new Size(200, 23);
            txtVendedor.TabIndex = 10;
            // 
            // btnAbrirPedido
            // 
            btnAbrirPedido.Location = new Point(581, 435);
            btnAbrirPedido.Name = "btnAbrirPedido";
            btnAbrirPedido.Size = new Size(113, 23);
            btnAbrirPedido.TabIndex = 11;
            btnAbrirPedido.Text = "&Abrir Pedido";
            btnAbrirPedido.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(93, 358);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Produto";
            // 
            // FrmPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 552);
            Controls.Add(groupBox1);
            Controls.Add(btnAbrirPedido);
            Controls.Add(txtVendedor);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(groupBox);
            Controls.Add(label1);
            Name = "FrmPedido";
            Text = "FrmPedido";
            Load += FrmPedido_Load;
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label6;
        private Label label7;
        private Label label3;
        private TextBox txtVendedor;
        private Button btnAbrirPedido;
        private GroupBox groupBox1;
    }
}