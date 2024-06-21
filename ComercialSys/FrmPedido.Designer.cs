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
            txtNumeroPedido = new TextBox();
            label6 = new Label();
            label3 = new Label();
            txtVendedor = new TextBox();
            btnAbrirNovo = new Button();
            gbxProduto = new GroupBox();
            btnInserirItem = new Button();
            txtQuantidade = new TextBox();
            txtValorUnit = new TextBox();
            label8 = new Label();
            txtDescricao = new TextBox();
            label7 = new Label();
            txtCodBarras = new TextBox();
            label5 = new Label();
            label4 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            groupBox.SuspendLayout();
            gbxProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            groupBox.Location = new Point(81, 125);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(596, 108);
            groupBox.TabIndex = 1;
            groupBox.TabStop = false;
            groupBox.Text = "Dados Cliente";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(152, 50);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(407, 23);
            textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(28, 50);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 9;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(835, 34);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Número";
            // 
            // txtNumeroPedido
            // 
            txtNumeroPedido.Font = new Font("Segoe UI", 15F);
            txtNumeroPedido.ForeColor = Color.Red;
            txtNumeroPedido.Location = new Point(892, 34);
            txtNumeroPedido.Name = "txtNumeroPedido";
            txtNumeroPedido.RightToLeft = RightToLeft.Yes;
            txtNumeroPedido.Size = new Size(100, 34);
            txtNumeroPedido.TabIndex = 3;
            txtNumeroPedido.Text = "0";
            txtNumeroPedido.TextChanged += txtNumeroPedido_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(72, 34);
            label6.Name = "label6";
            label6.Size = new Size(107, 37);
            label6.TabIndex = 7;
            label6.Text = "Pedido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 89);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 9;
            label3.Text = "Vendedor";
            // 
            // txtVendedor
            // 
            txtVendedor.Location = new Point(144, 86);
            txtVendedor.Name = "txtVendedor";
            txtVendedor.ReadOnly = true;
            txtVendedor.Size = new Size(200, 23);
            txtVendedor.TabIndex = 10;
            // 
            // btnAbrirNovo
            // 
            btnAbrirNovo.Location = new Point(704, 181);
            btnAbrirNovo.Name = "btnAbrirNovo";
            btnAbrirNovo.Size = new Size(131, 52);
            btnAbrirNovo.TabIndex = 11;
            btnAbrirNovo.Text = "&Abrir Pedido";
            btnAbrirNovo.UseVisualStyleBackColor = true;
            btnAbrirNovo.Click += btnAbrirNovo_Click;
            // 
            // gbxProduto
            // 
            gbxProduto.Controls.Add(btnInserirItem);
            gbxProduto.Controls.Add(txtQuantidade);
            gbxProduto.Controls.Add(txtValorUnit);
            gbxProduto.Controls.Add(label8);
            gbxProduto.Controls.Add(txtDescricao);
            gbxProduto.Controls.Add(label7);
            gbxProduto.Controls.Add(txtCodBarras);
            gbxProduto.Controls.Add(label5);
            gbxProduto.Controls.Add(label4);
            gbxProduto.Enabled = false;
            gbxProduto.Location = new Point(81, 263);
            gbxProduto.Name = "gbxProduto";
            gbxProduto.Size = new Size(754, 124);
            gbxProduto.TabIndex = 11;
            gbxProduto.TabStop = false;
            gbxProduto.Text = "Produto";
            // 
            // btnInserirItem
            // 
            btnInserirItem.Font = new Font("Segoe UI", 10F);
            btnInserirItem.Location = new Point(625, 54);
            btnInserirItem.Name = "btnInserirItem";
            btnInserirItem.Size = new Size(93, 35);
            btnInserirItem.TabIndex = 19;
            btnInserirItem.Text = "&Inserir";
            btnInserirItem.UseVisualStyleBackColor = true;
            btnInserirItem.Click += btnInserirItem_Click;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(480, 62);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(116, 23);
            txtQuantidade.TabIndex = 18;
            txtQuantidade.TextChanged += textBox10_TextChanged;
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(362, 62);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(100, 23);
            txtValorUnit.TabIndex = 18;
            txtValorUnit.TextChanged += textBox9_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(480, 44);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 17;
            label8.Text = "Quantidade";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(152, 62);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(193, 23);
            txtDescricao.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(362, 44);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 17;
            label7.Text = "Valor Unitário";
            // 
            // txtCodBarras
            // 
            txtCodBarras.Location = new Point(37, 62);
            txtCodBarras.Name = "txtCodBarras";
            txtCodBarras.Size = new Size(100, 23);
            txtCodBarras.TabIndex = 18;
            txtCodBarras.TextChanged += txtCodBarras_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(152, 44);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 17;
            label5.Text = "Descrição";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 44);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 17;
            label4.Text = "Código de Barras";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(868, 556);
            button1.Name = "button1";
            button1.Size = new Size(124, 39);
            button1.TabIndex = 12;
            button1.Text = "Finalizar Pedido";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(81, 412);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(754, 183);
            dataGridView1.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 18F);
            textBox4.Location = new Point(868, 506);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(124, 39);
            textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(892, 477);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 15;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(892, 448);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 16;
            // 
            // FrmPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 637);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(gbxProduto);
            Controls.Add(btnAbrirNovo);
            Controls.Add(txtVendedor);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(txtNumeroPedido);
            Controls.Add(label2);
            Controls.Add(groupBox);
            Controls.Add(label1);
            Name = "FrmPedido";
            Text = "FrmPedido";
            Load += FrmPedido_Load;
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            gbxProduto.ResumeLayout(false);
            gbxProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox;
        private Label label2;
        private TextBox txtNumeroPedido;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label6;
        private Label label3;
        private TextBox txtVendedor;
        private Button btnAbrirNovo;
        private GroupBox gbxProduto;
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox txtQuantidade;
        private TextBox txtValorUnit;
        private Label label8;
        private TextBox txtDescricao;
        private Label label7;
        private TextBox txtCodBarras;
        private Label label5;
        private Label label4;
        private Button btnInserirItem;
    }
}