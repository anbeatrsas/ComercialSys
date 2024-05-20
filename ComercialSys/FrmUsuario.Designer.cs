namespace ComercialSys
{
    partial class FrmUsuario
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
            txtId = new TextBox();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtConfSenha = new TextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            cmbNivel = new ComboBox();
            btnConsultar = new Button();
            btnEditar = new Button();
            btnInserir = new Button();
            label6 = new Label();
            dgvUsuarios = new DataGridView();
            clnid = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnNivel = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewCheckBoxColumn();
            txtBusca = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 43);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 8;
            label1.Text = "ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(142, 39);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(57, 23);
            txtId.TabIndex = 8;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(142, 71);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(330, 23);
            txtNome.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(142, 106);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(330, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(142, 141);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 2;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 75);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 0;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 110);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 0;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(97, 145);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 0;
            label4.Text = "Senha";
            // 
            // txtConfSenha
            // 
            txtConfSenha.Location = new Point(142, 177);
            txtConfSenha.Name = "txtConfSenha";
            txtConfSenha.Size = new Size(100, 23);
            txtConfSenha.TabIndex = 3;
            txtConfSenha.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 181);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 0;
            label5.Text = "Confirma Senha";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbNivel);
            groupBox1.Controls.Add(btnConsultar);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnInserir);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(txtConfSenha);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(208, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(558, 296);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados de Usuário";
            // 
            // cmbNivel
            // 
            cmbNivel.FormattingEnabled = true;
            cmbNivel.Items.AddRange(new object[] { "1°- Atendente", "2°- Caixa", "3°- Gerente", "4°- Estoquista", "5°- Empacotador" });
            cmbNivel.Location = new Point(351, 162);
            cmbNivel.Name = "cmbNivel";
            cmbNivel.Size = new Size(121, 23);
            cmbNivel.TabIndex = 4;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(325, 240);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 7;
            btnConsultar.Text = "&Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(235, 240);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(144, 240);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 5;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(313, 167);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 0;
            label6.Text = "Nível";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { clnid, clnNome, clnEmail, clnNivel, clnAtivo });
            dgvUsuarios.Location = new Point(237, 401);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.Size = new Size(500, 150);
            dgvUsuarios.TabIndex = 3;
            // 
            // clnid
            // 
            clnid.Frozen = true;
            clnid.HeaderText = "ID";
            clnid.Name = "clnid";
            clnid.ReadOnly = true;
            clnid.Width = 40;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 180;
            // 
            // clnEmail
            // 
            clnEmail.Frozen = true;
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            clnEmail.Width = 180;
            // 
            // clnNivel
            // 
            clnNivel.Frozen = true;
            clnNivel.HeaderText = "Nível";
            clnNivel.Name = "clnNivel";
            clnNivel.ReadOnly = true;
            clnNivel.Width = 60;
            // 
            // clnAtivo
            // 
            clnAtivo.Frozen = true;
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.Name = "clnAtivo";
            clnAtivo.ReadOnly = true;
            clnAtivo.Width = 40;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(237, 372);
            txtBusca.Name = "txtBusca";
            txtBusca.PlaceholderText = "Digite pelo menos duas letras para pesquisar usuário";
            txtBusca.Size = new Size(500, 23);
            txtBusca.TabIndex = 1;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 587);
            Controls.Add(dgvUsuarios);
            Controls.Add(groupBox1);
            Controls.Add(txtBusca);
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            Load += FrmUsuario_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtConfSenha;
        private Label label5;
        private GroupBox groupBox1;
        private Button btnConsultar;
        private Button btnEditar;
        private Button btnInserir;
        private DataGridView dgvUsuarios;
        private TextBox txtBusca;
        private ComboBox cmbNivel;
        private Label label6;
        private DataGridViewTextBoxColumn clnid;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnNivel;
        private DataGridViewCheckBoxColumn clnAtivo;
    }
}