namespace ComercialSys
{
    partial class FrmClienteNovo
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
            tabControl1 = new TabControl();
            tbpDadosPessoais = new TabPage();
            txtClienteId = new TextBox();
            btnEditar = new Button();
            btnInserir = new Button();
            mxtCpf = new MaskedTextBox();
            mxtTelefone = new MaskedTextBox();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            chkAtivo = new CheckBox();
            dtpDataNasc = new DateTimePicker();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            tbpEnderecos = new TabPage();
            btnAdicionaEndereco = new Button();
            btnSalvar = new Button();
            cmbTipoEndereco = new ComboBox();
            label10 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtNumero = new TextBox();
            txtUf = new TextBox();
            txtCidade = new TextBox();
            txtBairro = new TextBox();
            txtComplemento = new TextBox();
            txtLogradouro = new TextBox();
            mxtCep = new MaskedTextBox();
            groupBox1 = new GroupBox();
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
            tabControl1.SuspendLayout();
            tbpDadosPessoais.SuspendLayout();
            tbpEnderecos.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEnderecos).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbpDadosPessoais);
            tabControl1.Controls.Add(tbpEnderecos);
            tabControl1.Location = new Point(44, 68);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(498, 324);
            tabControl1.TabIndex = 0;
            // 
            // tbpDadosPessoais
            // 
            tbpDadosPessoais.BackColor = Color.WhiteSmoke;
            tbpDadosPessoais.Controls.Add(txtClienteId);
            tbpDadosPessoais.Controls.Add(btnEditar);
            tbpDadosPessoais.Controls.Add(btnInserir);
            tbpDadosPessoais.Controls.Add(mxtCpf);
            tbpDadosPessoais.Controls.Add(mxtTelefone);
            tbpDadosPessoais.Controls.Add(label4);
            tbpDadosPessoais.Controls.Add(label5);
            tbpDadosPessoais.Controls.Add(label3);
            tbpDadosPessoais.Controls.Add(label2);
            tbpDadosPessoais.Controls.Add(label1);
            tbpDadosPessoais.Controls.Add(chkAtivo);
            tbpDadosPessoais.Controls.Add(dtpDataNasc);
            tbpDadosPessoais.Controls.Add(txtNome);
            tbpDadosPessoais.Controls.Add(txtEmail);
            tbpDadosPessoais.Location = new Point(4, 24);
            tbpDadosPessoais.Name = "tbpDadosPessoais";
            tbpDadosPessoais.Padding = new Padding(3);
            tbpDadosPessoais.Size = new Size(490, 296);
            tbpDadosPessoais.TabIndex = 0;
            tbpDadosPessoais.Text = "Dados Pessoais";
            // 
            // txtClienteId
            // 
            txtClienteId.Location = new Point(343, 180);
            txtClienteId.Name = "txtClienteId";
            txtClienteId.Size = new Size(100, 23);
            txtClienteId.TabIndex = 6;
            txtClienteId.Text = "0";
            txtClienteId.Visible = false;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(131, 228);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(85, 23);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(40, 228);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(85, 23);
            btnInserir.TabIndex = 2;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // mxtCpf
            // 
            mxtCpf.Location = new Point(40, 121);
            mxtCpf.Mask = "000.000.000-00";
            mxtCpf.Name = "mxtCpf";
            mxtCpf.Size = new Size(118, 23);
            mxtCpf.TabIndex = 5;
            // 
            // mxtTelefone
            // 
            mxtTelefone.Location = new Point(40, 180);
            mxtTelefone.Mask = "(99) 00000-0000";
            mxtTelefone.Name = "mxtTelefone";
            mxtTelefone.Size = new Size(118, 23);
            mxtTelefone.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 161);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 3;
            label4.Text = "Telefone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(162, 161);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 3;
            label5.Text = "Data Nascimento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(164, 103);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 103);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 3;
            label2.Text = "CPF";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 47);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome";
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.BackColor = Color.Gainsboro;
            chkAtivo.Checked = true;
            chkAtivo.CheckState = CheckState.Checked;
            chkAtivo.Location = new Point(389, 67);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 2;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = false;
            // 
            // dtpDataNasc
            // 
            dtpDataNasc.Format = DateTimePickerFormat.Short;
            dtpDataNasc.Location = new Point(164, 180);
            dtpDataNasc.MaxDate = new DateTime(2024, 5, 27, 0, 0, 0, 0);
            dtpDataNasc.MinDate = new DateTime(1920, 1, 1, 0, 0, 0, 0);
            dtpDataNasc.Name = "dtpDataNasc";
            dtpDataNasc.Size = new Size(168, 23);
            dtpDataNasc.TabIndex = 1;
            dtpDataNasc.Value = new DateTime(2024, 5, 27, 0, 0, 0, 0);
            // 
            // txtNome
            // 
            txtNome.Location = new Point(40, 65);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(334, 23);
            txtNome.TabIndex = 0;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(164, 121);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(279, 23);
            txtEmail.TabIndex = 0;
            // 
            // tbpEnderecos
            // 
            tbpEnderecos.Controls.Add(btnAdicionaEndereco);
            tbpEnderecos.Controls.Add(btnSalvar);
            tbpEnderecos.Controls.Add(cmbTipoEndereco);
            tbpEnderecos.Controls.Add(label10);
            tbpEnderecos.Controls.Add(label15);
            tbpEnderecos.Controls.Add(label14);
            tbpEnderecos.Controls.Add(label13);
            tbpEnderecos.Controls.Add(label12);
            tbpEnderecos.Controls.Add(label11);
            tbpEnderecos.Controls.Add(label9);
            tbpEnderecos.Controls.Add(label8);
            tbpEnderecos.Controls.Add(txtNumero);
            tbpEnderecos.Controls.Add(txtUf);
            tbpEnderecos.Controls.Add(txtCidade);
            tbpEnderecos.Controls.Add(txtBairro);
            tbpEnderecos.Controls.Add(txtComplemento);
            tbpEnderecos.Controls.Add(txtLogradouro);
            tbpEnderecos.Controls.Add(mxtCep);
            tbpEnderecos.Location = new Point(4, 24);
            tbpEnderecos.Name = "tbpEnderecos";
            tbpEnderecos.Padding = new Padding(3);
            tbpEnderecos.Size = new Size(490, 296);
            tbpEnderecos.TabIndex = 1;
            tbpEnderecos.Text = "Endereços";
            tbpEnderecos.UseVisualStyleBackColor = true;
            // 
            // btnAdicionaEndereco
            // 
            btnAdicionaEndereco.Location = new Point(312, 235);
            btnAdicionaEndereco.Name = "btnAdicionaEndereco";
            btnAdicionaEndereco.Size = new Size(125, 23);
            btnAdicionaEndereco.TabIndex = 4;
            btnAdicionaEndereco.Text = "Adicionar &Novo";
            btnAdicionaEndereco.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(47, 235);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(121, 23);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "&Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // cmbTipoEndereco
            // 
            cmbTipoEndereco.FormattingEnabled = true;
            cmbTipoEndereco.Items.AddRange(new object[] { "RES - Residencial", "COM - Comercial", "ENT - Entrega", "COB - Cobrança", "RET - Retirada", "TEMP - Temporário" });
            cmbTipoEndereco.Location = new Point(47, 175);
            cmbTipoEndereco.Name = "cmbTipoEndereco";
            cmbTipoEndereco.Size = new Size(121, 23);
            cmbTipoEndereco.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(416, 92);
            label10.Name = "label10";
            label10.Size = new Size(21, 15);
            label10.TabIndex = 2;
            label10.Text = "UF";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(47, 157);
            label15.Name = "label15";
            label15.Size = new Size(98, 15);
            label15.TabIndex = 2;
            label15.Text = "Tipo de Endereço";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(287, 92);
            label14.Name = "label14";
            label14.Size = new Size(44, 15);
            label14.TabIndex = 2;
            label14.Text = "Cidade";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(154, 92);
            label13.Name = "label13";
            label13.Size = new Size(38, 15);
            label13.TabIndex = 2;
            label13.Text = "Bairro";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(47, 92);
            label12.Name = "label12";
            label12.Size = new Size(84, 15);
            label12.TabIndex = 2;
            label12.Text = "Complemento";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(349, 29);
            label11.Name = "label11";
            label11.Size = new Size(51, 15);
            label11.TabIndex = 2;
            label11.Text = "Numero";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(118, 29);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 2;
            label9.Text = "Logradouro";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(47, 30);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 2;
            label8.Text = "CEP";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(349, 48);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            // 
            // txtUf
            // 
            txtUf.Location = new Point(418, 110);
            txtUf.Name = "txtUf";
            txtUf.Size = new Size(31, 23);
            txtUf.TabIndex = 1;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(287, 110);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(125, 23);
            txtCidade.TabIndex = 1;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(151, 110);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(131, 23);
            txtBairro.TabIndex = 1;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(47, 110);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(98, 23);
            txtComplemento.TabIndex = 1;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(116, 48);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(227, 23);
            txtLogradouro.TabIndex = 1;
            // 
            // mxtCep
            // 
            mxtCep.Location = new Point(47, 48);
            mxtCep.Mask = "00000-999";
            mxtCep.Name = "mxtCep";
            mxtCep.Size = new Size(63, 23);
            mxtCep.TabIndex = 0;
            mxtCep.Leave += mxtCep_Leave;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvEnderecos);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(tabControl1);
            groupBox1.Location = new Point(213, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(585, 591);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Novo Cliente";
            // 
            // dgvEnderecos
            // 
            dgvEnderecos.AllowUserToAddRows = false;
            dgvEnderecos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnderecos.Columns.AddRange(new DataGridViewColumn[] { clnCep, clnLogradouro, clnNumero, clnComplemento, clnBairro, clnCidade, clsUf, clnTipoEndereco });
            dgvEnderecos.Location = new Point(48, 413);
            dgvEnderecos.Name = "dgvEnderecos";
            dgvEnderecos.ReadOnly = true;
            dgvEnderecos.RowHeadersVisible = false;
            dgvEnderecos.Size = new Size(494, 131);
            dgvEnderecos.TabIndex = 3;
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
            label6.Location = new Point(212, 15);
            label6.Name = "label6";
            label6.Size = new Size(139, 40);
            label6.TabIndex = 1;
            label6.Text = "Cadastro";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(245, 52);
            label7.Name = "label7";
            label7.Size = new Size(73, 13);
            label7.TabIndex = 2;
            label7.Text = "ComercialSys";
            // 
            // FrmClienteNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 656);
            Controls.Add(groupBox1);
            Name = "FrmClienteNovo";
            Text = "FrmClienteNovo";
            Load += FrmClienteNovo_Load;
            tabControl1.ResumeLayout(false);
            tbpDadosPessoais.ResumeLayout(false);
            tbpDadosPessoais.PerformLayout();
            tbpEnderecos.ResumeLayout(false);
            tbpEnderecos.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEnderecos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tbpDadosPessoais;
        private TabPage tbpEnderecos;
        private GroupBox groupBox1;
        private DateTimePicker dtpDataNasc;
        private TextBox txtNome;
        private TextBox txtEmail;
        private MaskedTextBox mxtTelefone;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox chkAtivo;
        private Button btnInserir;
        private MaskedTextBox mxtCpf;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label8;
        private TextBox txtLogradouro;
        private MaskedTextBox mxtCep;
        private ComboBox cmbTipoEndereco;
        private TextBox txtNumero;
        private TextBox txtUf;
        private TextBox txtCidade;
        private TextBox txtBairro;
        private TextBox txtComplemento;
        private Button btnAdicionaEndereco;
        private Button btnSalvar;
        private DataGridView dgvEnderecos;
        private Button btnEditar;
        private DataGridViewTextBoxColumn clnCep;
        private DataGridViewTextBoxColumn clnLogradouro;
        private DataGridViewTextBoxColumn clnNumero;
        private DataGridViewTextBoxColumn clnComplemento;
        private DataGridViewTextBoxColumn clnBairro;
        private DataGridViewTextBoxColumn clnCidade;
        private DataGridViewTextBoxColumn clsUf;
        private DataGridViewTextBoxColumn clnTipoEndereco;
        private Label label10;
        public TextBox txtClienteId;
        private Label label11;
        private Label label12;
        private Label label15;
        private Label label14;
        private Label label13;
    }
}