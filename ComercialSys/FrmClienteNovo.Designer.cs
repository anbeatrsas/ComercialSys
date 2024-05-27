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
            button2 = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            groupBox1 = new GroupBox();
            dvgEnderecos = new DataGridView();
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
            label10 = new Label();
            tabControl1.SuspendLayout();
            tbpDadosPessoais.SuspendLayout();
            tbpEnderecos.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgEnderecos).BeginInit();
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
            tbpEnderecos.Controls.Add(button2);
            tbpEnderecos.Controls.Add(button1);
            tbpEnderecos.Controls.Add(comboBox1);
            tbpEnderecos.Controls.Add(label10);
            tbpEnderecos.Controls.Add(label9);
            tbpEnderecos.Controls.Add(label8);
            tbpEnderecos.Controls.Add(textBox5);
            tbpEnderecos.Controls.Add(textBox6);
            tbpEnderecos.Controls.Add(textBox4);
            tbpEnderecos.Controls.Add(textBox3);
            tbpEnderecos.Controls.Add(textBox2);
            tbpEnderecos.Controls.Add(textBox1);
            tbpEnderecos.Controls.Add(maskedTextBox1);
            tbpEnderecos.Location = new Point(4, 24);
            tbpEnderecos.Name = "tbpEnderecos";
            tbpEnderecos.Padding = new Padding(3);
            tbpEnderecos.Size = new Size(490, 296);
            tbpEnderecos.TabIndex = 1;
            tbpEnderecos.Text = "Endereços";
            tbpEnderecos.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(312, 235);
            button2.Name = "button2";
            button2.Size = new Size(125, 23);
            button2.TabIndex = 4;
            button2.Text = "Adicionar &Novo";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(47, 235);
            button1.Name = "button1";
            button1.Size = new Size(121, 23);
            button1.TabIndex = 4;
            button1.Text = "&Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "RES - Residencial", "COM - Comercial", "ENT - Entrega", "COB - Cobrança", "RET - Retirada", "TEMP - Temporário" });
            comboBox1.Location = new Point(47, 175);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
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
            // textBox5
            // 
            textBox5.Location = new Point(349, 48);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 1;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(418, 110);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(31, 23);
            textBox6.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(287, 110);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 23);
            textBox4.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(186, 110);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(96, 23);
            textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(47, 110);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(133, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(116, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(227, 23);
            textBox1.TabIndex = 1;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(47, 48);
            maskedTextBox1.Mask = "00000-999";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(63, 23);
            maskedTextBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dvgEnderecos);
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
            // dvgEnderecos
            // 
            dvgEnderecos.AllowUserToAddRows = false;
            dvgEnderecos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgEnderecos.Columns.AddRange(new DataGridViewColumn[] { clnCep, clnLogradouro, clnNumero, clnComplemento, clnBairro, clnCidade, clsUf, clnTipoEndereco });
            dvgEnderecos.Location = new Point(48, 413);
            dvgEnderecos.Name = "dvgEnderecos";
            dvgEnderecos.ReadOnly = true;
            dvgEnderecos.RowHeadersVisible = false;
            dvgEnderecos.Size = new Size(494, 131);
            dvgEnderecos.TabIndex = 3;
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
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(416, 92);
            label10.Name = "label10";
            label10.Size = new Size(21, 15);
            label10.TabIndex = 2;
            label10.Text = "UF";
            // 
            // FrmClienteNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 656);
            Controls.Add(groupBox1);
            Name = "FrmClienteNovo";
            Text = "FrmClienteNovo";
            tabControl1.ResumeLayout(false);
            tbpDadosPessoais.ResumeLayout(false);
            tbpDadosPessoais.PerformLayout();
            tbpEnderecos.ResumeLayout(false);
            tbpEnderecos.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgEnderecos).EndInit();
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
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private ComboBox comboBox1;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button2;
        private Button button1;
        private DataGridView dvgEnderecos;
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
    }
}