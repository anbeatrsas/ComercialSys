namespace ComercialSys
{
    partial class FrmCategoria
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
            groupBox1 = new GroupBox();
            btnDeletar = new Button();
            label1 = new Label();
            btnConsultar = new Button();
            label2 = new Label();
            btnEditar = new Button();
            label3 = new Label();
            btnInserir = new Button();
            txtId = new TextBox();
            txtSigla = new TextBox();
            txtNome = new TextBox();
            dgvCategoria = new DataGridView();
            clnid = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnSigla = new DataGridViewTextBoxColumn();
            txtBusca = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDeletar);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnConsultar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnInserir);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(txtSigla);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Location = new Point(173, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(430, 295);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Categoria";
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(278, 223);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(75, 23);
            btnDeletar.TabIndex = 5;
            btnDeletar.Text = "&Delete";
            btnDeletar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 79);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 5;
            label1.Text = "ID";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(175, 223);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(85, 23);
            btnConsultar.TabIndex = 5;
            btnConsultar.Text = "&Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 118);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(81, 223);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 156);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 3;
            label3.Text = "Sigla";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(249, 153);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(88, 23);
            btnInserir.TabIndex = 5;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(127, 76);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(61, 23);
            txtId.TabIndex = 0;
            // 
            // txtSigla
            // 
            txtSigla.Location = new Point(127, 153);
            txtSigla.Name = "txtSigla";
            txtSigla.Size = new Size(100, 23);
            txtSigla.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(127, 115);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(210, 23);
            txtNome.TabIndex = 4;
            // 
            // dgvCategoria
            // 
            dgvCategoria.AllowUserToAddRows = false;
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.Columns.AddRange(new DataGridViewColumn[] { clnid, clnNome, clnSigla });
            dgvCategoria.Location = new Point(173, 374);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.RowHeadersVisible = false;
            dgvCategoria.Size = new Size(430, 150);
            dgvCategoria.TabIndex = 1;
            // 
            // clnid
            // 
            clnid.Frozen = true;
            clnid.HeaderText = "ID";
            clnid.Name = "clnid";
            clnid.ReadOnly = true;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 250;
            // 
            // clnSigla
            // 
            clnSigla.Frozen = true;
            clnSigla.HeaderText = "Sigla";
            clnSigla.Name = "clnSigla";
            clnSigla.ReadOnly = true;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(186, 345);
            txtBusca.Name = "txtBusca";
            txtBusca.PlaceholderText = "Digite pelo menos duas letras para buscar categoria ";
            txtBusca.Size = new Size(398, 23);
            txtBusca.TabIndex = 4;
            txtBusca.TextChanged += txtBusca_TextChanged;
            // 
            // FrmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 561);
            Controls.Add(dgvCategoria);
            Controls.Add(groupBox1);
            Controls.Add(txtBusca);
            Name = "FrmCategoria";
            Text = "FrmCategoria";
            Load += FrmCategoria_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtSigla;
        private Button btnInserir;
        private Button btnEditar;
        private Button btnConsultar;
        private Button btnDeletar;
        private DataGridView dgvCategoria;
        private DataGridViewTextBoxColumn clnid;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnSigla;
        private TextBox txtBusca;
    }
}