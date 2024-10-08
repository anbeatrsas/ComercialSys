﻿namespace ComercialSys
{
    partial class FrmProduto
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
            label2 = new Label();
            label1 = new Label();
            txtCodBarras = new TextBox();
            txtUnidadeVenda = new TextBox();
            btnAdicionar = new Button();
            btnEditar = new Button();
            btnConsultar = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            npEstoqueMinimo = new NumericUpDown();
            label8 = new Label();
            label9 = new Label();
            dgvProdutos = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnCodBarras = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnValorUnit = new DataGridViewTextBoxColumn();
            clnUnidadeVenda = new DataGridViewTextBoxColumn();
            clnCategoria = new DataGridViewTextBoxColumn();
            clnEstoqueMin = new DataGridViewTextBoxColumn();
            clnClasseDesconto = new DataGridViewTextBoxColumn();
            txtDesconto = new TextBox();
            txtValorUnit = new TextBox();
            cmbCategoria = new ComboBox();
            txtDescricao = new TextBox();
            txtId = new TextBox();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)npEstoqueMinimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(455, 50);
            label2.Name = "label2";
            label2.Size = new Size(143, 40);
            label2.TabIndex = 1;
            label2.Text = "Produtos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(490, 87);
            label1.Name = "label1";
            label1.Size = new Size(73, 13);
            label1.TabIndex = 2;
            label1.Text = "ComercialSys";
            // 
            // txtCodBarras
            // 
            txtCodBarras.Location = new Point(279, 160);
            txtCodBarras.Name = "txtCodBarras";
            txtCodBarras.Size = new Size(100, 23);
            txtCodBarras.TabIndex = 3;
            // 
            // txtUnidadeVenda
            // 
            txtUnidadeVenda.Location = new Point(543, 160);
            txtUnidadeVenda.Name = "txtUnidadeVenda";
            txtUnidadeVenda.PlaceholderText = "Ex: Caixa";
            txtUnidadeVenda.Size = new Size(100, 23);
            txtUnidadeVenda.TabIndex = 3;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(543, 277);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "&Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(624, 277);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(705, 277);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 4;
            btnConsultar.Text = "&Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(280, 144);
            label3.Name = "label3";
            label3.Size = new Size(95, 13);
            label3.TabIndex = 5;
            label3.Text = "Código de Barras";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(542, 202);
            label4.Name = "label4";
            label4.Size = new Size(56, 13);
            label4.TabIndex = 5;
            label4.Text = "Descrição";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(409, 143);
            label5.Name = "label5";
            label5.Size = new Size(78, 13);
            label5.TabIndex = 5;
            label5.Text = "Valor Unitário";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(542, 144);
            label6.Name = "label6";
            label6.Size = new Size(102, 13);
            label6.TabIndex = 5;
            label6.Text = "Unidade de Venda";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(284, 200);
            label7.Name = "label7";
            label7.Size = new Size(57, 13);
            label7.TabIndex = 5;
            label7.Text = "Categoria";
            // 
            // npEstoqueMinimo
            // 
            npEstoqueMinimo.Location = new Point(685, 161);
            npEstoqueMinimo.Name = "npEstoqueMinimo";
            npEstoqueMinimo.Size = new Size(100, 23);
            npEstoqueMinimo.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(683, 144);
            label8.Name = "label8";
            label8.Size = new Size(91, 13);
            label8.TabIndex = 5;
            label8.Text = "Estoque Mínimo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(284, 260);
            label9.Name = "label9";
            label9.Size = new Size(56, 13);
            label9.TabIndex = 5;
            label9.Text = "Desconto";
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { clnId, clnCodBarras, clnDescricao, clnValorUnit, clnUnidadeVenda, clnCategoria, clnEstoqueMin, clnClasseDesconto });
            dgvProdutos.Location = new Point(51, 347);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.Size = new Size(978, 150);
            dgvProdutos.TabIndex = 10;
            dgvProdutos.CellContentClick += dgvProdutos_CellContentClick;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 40;
            // 
            // clnCodBarras
            // 
            clnCodBarras.HeaderText = "Código de Barras";
            clnCodBarras.Name = "clnCodBarras";
            clnCodBarras.ReadOnly = true;
            clnCodBarras.Width = 150;
            // 
            // clnDescricao
            // 
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 200;
            // 
            // clnValorUnit
            // 
            clnValorUnit.HeaderText = "Valor Unitário";
            clnValorUnit.Name = "clnValorUnit";
            clnValorUnit.ReadOnly = true;
            clnValorUnit.Width = 120;
            // 
            // clnUnidadeVenda
            // 
            clnUnidadeVenda.HeaderText = "Unidade de Venda";
            clnUnidadeVenda.Name = "clnUnidadeVenda";
            clnUnidadeVenda.ReadOnly = true;
            clnUnidadeVenda.Width = 150;
            // 
            // clnCategoria
            // 
            clnCategoria.HeaderText = "Categoria";
            clnCategoria.Name = "clnCategoria";
            clnCategoria.ReadOnly = true;
            // 
            // clnEstoqueMin
            // 
            clnEstoqueMin.HeaderText = "Estoque Mínimo";
            clnEstoqueMin.Name = "clnEstoqueMin";
            clnEstoqueMin.ReadOnly = true;
            clnEstoqueMin.Width = 120;
            // 
            // clnClasseDesconto
            // 
            clnClasseDesconto.HeaderText = "Desconto";
            clnClasseDesconto.Name = "clnClasseDesconto";
            clnClasseDesconto.ReadOnly = true;
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(284, 278);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(100, 23);
            txtDesconto.TabIndex = 11;
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(409, 161);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(100, 23);
            txtValorUnit.TabIndex = 12;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(284, 218);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(225, 23);
            cmbCategoria.TabIndex = 15;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(542, 218);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(243, 23);
            txtDescricao.TabIndex = 16;
            txtDescricao.TextChanged += txtDescricao_TextChanged;
            // 
            // txtId
            // 
            txtId.Location = new Point(411, 278);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(411, 260);
            label10.Name = "label10";
            label10.Size = new Size(18, 13);
            label10.TabIndex = 5;
            label10.Text = "ID";
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 572);
            Controls.Add(txtId);
            Controls.Add(txtDescricao);
            Controls.Add(cmbCategoria);
            Controls.Add(txtValorUnit);
            Controls.Add(txtDesconto);
            Controls.Add(dgvProdutos);
            Controls.Add(npEstoqueMinimo);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnConsultar);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            Controls.Add(txtUnidadeVenda);
            Controls.Add(txtCodBarras);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmProduto";
            Text = "FrmProduto";
            Load += FrmProduto_Load;
            ((System.ComponentModel.ISupportInitialize)npEstoqueMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txtCodBarras;
        private TextBox txtUnidadeVenda;
        private Button btnAdicionar;
        private Button btnEditar;
        private Button btnConsultar;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private NumericUpDown npEstoqueMinimo;
        private Label label8;
        private Label label9;
        private DataGridView dgvProdutos;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnCodBarras;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnValorUnit;
        private DataGridViewTextBoxColumn clnUnidadeVenda;
        private DataGridViewTextBoxColumn clnCategoria;
        private DataGridViewTextBoxColumn clnEstoqueMin;
        private DataGridViewTextBoxColumn clnClasseDesconto;
        private TextBox txtDesconto;
        private TextBox txtValorUnit;
        private ComboBox cmbCategoria;
        private TextBox txtDescricao;
        private TextBox txtId;
        private Label label10;
    }
}