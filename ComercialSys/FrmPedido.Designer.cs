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
            txtDescontoItem = new TextBox();
            txtQuantidade = new TextBox();
            label9 = new Label();
            txtValorUnit = new TextBox();
            label8 = new Label();
            txtDescricao = new TextBox();
            label7 = new Label();
            txtCodBarras = new TextBox();
            label5 = new Label();
            label4 = new Label();
            btn = new Button();
            dgvItens = new DataGridView();
            clnSeq = new DataGridViewTextBoxColumn();
            clnCodBar = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnUnidadeVenda = new DataGridViewTextBoxColumn();
            clnValorUnit = new DataGridViewTextBoxColumn();
            clnQuantidade = new DataGridViewTextBoxColumn();
            clnDesconto = new DataGridViewTextBoxColumn();
            clnValorItem = new DataGridViewTextBoxColumn();
            txtTotal = new TextBox();
            txtOutros = new TextBox();
            txtDesconto = new TextBox();
            txtSubtotal = new TextBox();
            lblDescMax = new Label();
            label10 = new Label();
            groupBox.SuspendLayout();
            gbxProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItens).BeginInit();
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
            label2.Location = new Point(826, 51);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Número";
            // 
            // txtNumeroPedido
            // 
            txtNumeroPedido.Font = new Font("Segoe UI", 15F);
            txtNumeroPedido.ForeColor = Color.Red;
            txtNumeroPedido.Location = new Point(883, 51);
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
            gbxProduto.Controls.Add(txtDescontoItem);
            gbxProduto.Controls.Add(txtQuantidade);
            gbxProduto.Controls.Add(label9);
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
            btnInserirItem.Location = new Point(623, 54);
            btnInserirItem.Name = "btnInserirItem";
            btnInserirItem.Size = new Size(93, 35);
            btnInserirItem.TabIndex = 19;
            btnInserirItem.Text = "&Inserir";
            btnInserirItem.UseVisualStyleBackColor = true;
            btnInserirItem.Click += btnInserirItem_Click;
            // 
            // txtDescontoItem
            // 
            txtDescontoItem.Location = new Point(514, 62);
            txtDescontoItem.Name = "txtDescontoItem";
            txtDescontoItem.Size = new Size(82, 23);
            txtDescontoItem.TabIndex = 18;
            txtDescontoItem.Text = "0";
            txtDescontoItem.TextAlign = HorizontalAlignment.Right;
            txtDescontoItem.TextChanged += textBox10_TextChanged;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(426, 62);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(82, 23);
            txtQuantidade.TabIndex = 18;
            txtQuantidade.Text = "1";
            txtQuantidade.TextAlign = HorizontalAlignment.Right;
            txtQuantidade.TextChanged += txtQuantidade_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(514, 44);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 17;
            label9.Text = "Desconto";
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(342, 62);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(78, 23);
            txtValorUnit.TabIndex = 18;
            txtValorUnit.TextAlign = HorizontalAlignment.Right;
            txtValorUnit.TextChanged += textBox9_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(426, 44);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 17;
            label8.Text = "Quantidade";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(143, 62);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(193, 23);
            txtDescricao.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(342, 44);
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
            label5.Location = new Point(143, 44);
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
            // btn
            // 
            btn.Font = new Font("Segoe UI", 10F);
            btn.Location = new Point(859, 582);
            btn.Name = "btn";
            btn.Size = new Size(124, 39);
            btn.TabIndex = 12;
            btn.Text = "Finalizar Pedido";
            btn.UseVisualStyleBackColor = true;
            // 
            // dgvItens
            // 
            dgvItens.AllowUserToAddRows = false;
            dgvItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItens.Columns.AddRange(new DataGridViewColumn[] { clnSeq, clnCodBar, clnDescricao, clnUnidadeVenda, clnValorUnit, clnQuantidade, clnDesconto, clnValorItem });
            dgvItens.Location = new Point(81, 412);
            dgvItens.Name = "dgvItens";
            dgvItens.ReadOnly = true;
            dgvItens.RowHeadersVisible = false;
            dgvItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItens.Size = new Size(754, 209);
            dgvItens.TabIndex = 13;
            // 
            // clnSeq
            // 
            clnSeq.Frozen = true;
            clnSeq.HeaderText = "Seq";
            clnSeq.Name = "clnSeq";
            clnSeq.ReadOnly = true;
            clnSeq.Width = 40;
            // 
            // clnCodBar
            // 
            clnCodBar.Frozen = true;
            clnCodBar.HeaderText = "CodBar";
            clnCodBar.Name = "clnCodBar";
            clnCodBar.ReadOnly = true;
            // 
            // clnDescricao
            // 
            clnDescricao.Frozen = true;
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 230;
            // 
            // clnUnidadeVenda
            // 
            clnUnidadeVenda.Frozen = true;
            clnUnidadeVenda.HeaderText = "Unidade";
            clnUnidadeVenda.Name = "clnUnidadeVenda";
            clnUnidadeVenda.ReadOnly = true;
            clnUnidadeVenda.Width = 60;
            // 
            // clnValorUnit
            // 
            clnValorUnit.Frozen = true;
            clnValorUnit.HeaderText = "Valor Unit";
            clnValorUnit.Name = "clnValorUnit";
            clnValorUnit.ReadOnly = true;
            clnValorUnit.Width = 90;
            // 
            // clnQuantidade
            // 
            clnQuantidade.Frozen = true;
            clnQuantidade.HeaderText = "Quantidade";
            clnQuantidade.Name = "clnQuantidade";
            clnQuantidade.ReadOnly = true;
            clnQuantidade.Width = 80;
            // 
            // clnDesconto
            // 
            clnDesconto.Frozen = true;
            clnDesconto.HeaderText = "Desconto";
            clnDesconto.Name = "clnDesconto";
            clnDesconto.ReadOnly = true;
            clnDesconto.Width = 70;
            // 
            // clnValorItem
            // 
            clnValorItem.Frozen = true;
            clnValorItem.HeaderText = "Valor Item";
            clnValorItem.Name = "clnValorItem";
            clnValorItem.ReadOnly = true;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 18F);
            txtTotal.Location = new Point(859, 537);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(124, 39);
            txtTotal.TabIndex = 14;
            // 
            // txtOutros
            // 
            txtOutros.Location = new Point(883, 507);
            txtOutros.Name = "txtOutros";
            txtOutros.Size = new Size(100, 23);
            txtOutros.TabIndex = 15;
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(883, 478);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(100, 23);
            txtDesconto.TabIndex = 16;
            txtDesconto.TextChanged += textBox6_TextChanged;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Font = new Font("Segoe UI", 18F);
            txtSubtotal.Location = new Point(859, 432);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(124, 39);
            txtSubtotal.TabIndex = 14;
            // 
            // lblDescMax
            // 
            lblDescMax.AutoSize = true;
            lblDescMax.Location = new Point(912, 372);
            lblDescMax.Name = "lblDescMax";
            lblDescMax.Size = new Size(47, 15);
            lblDescMax.TabIndex = 17;
            lblDescMax.Text = "R$ 0, 00";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(855, 411);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 17;
            label10.Text = "SubTotal";
            // 
            // FrmPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 657);
            Controls.Add(txtDesconto);
            Controls.Add(txtOutros);
            Controls.Add(txtSubtotal);
            Controls.Add(lblDescMax);
            Controls.Add(txtTotal);
            Controls.Add(label10);
            Controls.Add(dgvItens);
            Controls.Add(btn);
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
            ((System.ComponentModel.ISupportInitialize)dgvItens).EndInit();
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
        private Button btn;
        private DataGridView dgvItens;
        private TextBox txtTotal;
        private TextBox txtOutros;
        private TextBox txtDesconto;
        private TextBox txtQuantidade;
        private TextBox txtValorUnit;
        private Label label8;
        private TextBox txtDescricao;
        private Label label7;
        private TextBox txtCodBarras;
        private Label label5;
        private Label label4;
        private Button btnInserirItem;
        private TextBox txtSubtotal;
        private DataGridViewTextBoxColumn clnSeq;
        private DataGridViewTextBoxColumn clnCodBar;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnUnidadeVenda;
        private DataGridViewTextBoxColumn clnValorUnit;
        private DataGridViewTextBoxColumn clnQuantidade;
        private DataGridViewTextBoxColumn clnDesconto;
        private DataGridViewTextBoxColumn clnValorItem;
        private TextBox txtDescontoItem;
        private Label label9;
        private Label lblDescMax;
        private Label label10;
    }
}