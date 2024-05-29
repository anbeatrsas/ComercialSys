namespace ComercialSys
{
    partial class FrmClienteConsulta
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
            dgvEnderecos = new DataGridView();
            clnCep = new DataGridViewTextBoxColumn();
            clnLogradouro = new DataGridViewTextBoxColumn();
            clnNumero = new DataGridViewTextBoxColumn();
            clnComplemento = new DataGridViewTextBoxColumn();
            clnBairro = new DataGridViewTextBoxColumn();
            clnCidade = new DataGridViewTextBoxColumn();
            clsUf = new DataGridViewTextBoxColumn();
            clnTipoEndereco = new DataGridViewTextBoxColumn();
            label6 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            dgvClientes = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnCpf = new DataGridViewTextBoxColumn();
            clnTelefone = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnDataNasc = new DataGridViewTextBoxColumn();
            clnDataCad = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvEnderecos).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // dgvEnderecos
            // 
            dgvEnderecos.AllowUserToAddRows = false;
            dgvEnderecos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnderecos.Columns.AddRange(new DataGridViewColumn[] { clnCep, clnLogradouro, clnNumero, clnComplemento, clnBairro, clnCidade, clsUf, clnTipoEndereco });
            dgvEnderecos.Location = new Point(53, 376);
            dgvEnderecos.Name = "dgvEnderecos";
            dgvEnderecos.ReadOnly = true;
            dgvEnderecos.RowHeadersVisible = false;
            dgvEnderecos.Size = new Size(839, 159);
            dgvEnderecos.TabIndex = 4;
            // 
            // clnCep
            // 
            clnCep.Frozen = true;
            clnCep.HeaderText = "CEP";
            clnCep.Name = "clnCep";
            clnCep.ReadOnly = true;
            clnCep.Width = 60;
            // 
            // clnLogradouro
            // 
            clnLogradouro.HeaderText = "Logradouro";
            clnLogradouro.Name = "clnLogradouro";
            clnLogradouro.ReadOnly = true;
            clnLogradouro.Width = 200;
            // 
            // clnNumero
            // 
            clnNumero.HeaderText = "Numero";
            clnNumero.Name = "clnNumero";
            clnNumero.ReadOnly = true;
            clnNumero.Width = 60;
            // 
            // clnComplemento
            // 
            clnComplemento.HeaderText = "Complemento";
            clnComplemento.Name = "clnComplemento";
            clnComplemento.ReadOnly = true;
            // 
            // clnBairro
            // 
            clnBairro.HeaderText = "Bairro";
            clnBairro.Name = "clnBairro";
            clnBairro.ReadOnly = true;
            clnBairro.Width = 150;
            // 
            // clnCidade
            // 
            clnCidade.HeaderText = "Cidade";
            clnCidade.Name = "clnCidade";
            clnCidade.ReadOnly = true;
            clnCidade.Width = 150;
            // 
            // clsUf
            // 
            clsUf.HeaderText = "UF";
            clsUf.Name = "clsUf";
            clsUf.ReadOnly = true;
            clsUf.Width = 60;
            // 
            // clnTipoEndereco
            // 
            clnTipoEndereco.HeaderText = "Tipo";
            clnTipoEndereco.Name = "clnTipoEndereco";
            clnTipoEndereco.ReadOnly = true;
            clnTipoEndereco.Width = 60;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(329, 36);
            label6.Name = "label6";
            label6.Size = new Size(282, 40);
            label6.TabIndex = 5;
            label6.Text = "Consulta de Cliente";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(420, 75);
            label7.Name = "label7";
            label7.Size = new Size(73, 13);
            label7.TabIndex = 6;
            label7.Text = "ComercialSys";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvClientes);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dgvEnderecos);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(75, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(939, 581);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Consulta de cliente";
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnCpf, clnTelefone, clnEmail, clnDataNasc, clnDataCad, clnAtivo });
            dgvClientes.Location = new Point(53, 120);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.Size = new Size(839, 232);
            dgvClientes.TabIndex = 7;
            dgvClientes.SelectionChanged += dgvClientes_SelectionChanged;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 40;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            // 
            // clnCpf
            // 
            clnCpf.Frozen = true;
            clnCpf.HeaderText = "CPF";
            clnCpf.Name = "clnCpf";
            clnCpf.ReadOnly = true;
            // 
            // clnTelefone
            // 
            clnTelefone.Frozen = true;
            clnTelefone.HeaderText = "Telefone";
            clnTelefone.Name = "clnTelefone";
            clnTelefone.ReadOnly = true;
            // 
            // clnEmail
            // 
            clnEmail.Frozen = true;
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            // 
            // clnDataNasc
            // 
            clnDataNasc.Frozen = true;
            clnDataNasc.HeaderText = "Data de Nascimento";
            clnDataNasc.Name = "clnDataNasc";
            clnDataNasc.ReadOnly = true;
            clnDataNasc.Width = 200;
            // 
            // clnDataCad
            // 
            clnDataCad.Frozen = true;
            clnDataCad.HeaderText = "Cadastro";
            clnDataCad.Name = "clnDataCad";
            clnDataCad.ReadOnly = true;
            // 
            // clnAtivo
            // 
            clnAtivo.Frozen = true;
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.Name = "clnAtivo";
            clnAtivo.ReadOnly = true;
            // 
            // FrmClienteConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 650);
            Controls.Add(groupBox1);
            Name = "FrmClienteConsulta";
            Text = "FrmClienteConsulta";
            Load += FrmClienteConsulta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEnderecos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEnderecos;
        private DataGridViewTextBoxColumn clnCep;
        private DataGridViewTextBoxColumn clnLogradouro;
        private DataGridViewTextBoxColumn clnNumero;
        private DataGridViewTextBoxColumn clnComplemento;
        private DataGridViewTextBoxColumn clnBairro;
        private DataGridViewTextBoxColumn clnCidade;
        private DataGridViewTextBoxColumn clsUf;
        private DataGridViewTextBoxColumn clnTipoEndereco;
        private Label label6;
        private Label label7;
        private GroupBox groupBox1;
        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnCpf;
        private DataGridViewTextBoxColumn clnTelefone;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnDataNasc;
        private DataGridViewTextBoxColumn clnDataCad;
        private DataGridViewCheckBoxColumn clnAtivo;
    }
}