namespace ComercialSys
{
    partial class FrmCliente
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
            label2 = new Label();
            btnInserir = new Button();
            btnConsultar = new Button();
            btnEditar = new Button();
            groupBox1 = new GroupBox();
            label7 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtDataNascimento = new DateTimePicker();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            txtCpf = new TextBox();
            txtNome = new TextBox();
            txtId = new TextBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(342, 54);
            label1.Name = "label1";
            label1.Size = new Size(73, 13);
            label1.TabIndex = 0;
            label1.Text = "ComercialSys";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(319, 17);
            label2.Name = "label2";
            label2.Size = new Size(125, 40);
            label2.TabIndex = 0;
            label2.Text = "Clientes";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(382, 233);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 25);
            btnInserir.TabIndex = 1;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(183, 306);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 1;
            btnConsultar.Text = "&Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(295, 306);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnConsultar);
            groupBox1.Controls.Add(btnInserir);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDataNascimento);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtTelefone);
            groupBox1.Controls.Add(txtCpf);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(txtId);
            groupBox1.Location = new Point(105, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(572, 366);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Clientes";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(173, 166);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 4;
            label7.Text = "Telefone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(126, 237);
            label8.Name = "label8";
            label8.Size = new Size(98, 15);
            label8.TabIndex = 4;
            label8.Text = "Data Nascimento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(188, 205);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 4;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(196, 127);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 4;
            label5.Text = "CPF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(184, 88);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 4;
            label4.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(206, 49);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 4;
            label3.Text = "ID";
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.Format = DateTimePickerFormat.Short;
            txtDataNascimento.Location = new Point(235, 233);
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.Size = new Size(102, 23);
            txtDataNascimento.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(235, 195);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(222, 23);
            txtEmail.TabIndex = 0;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(235, 157);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(222, 23);
            txtTelefone.TabIndex = 0;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(235, 119);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(222, 23);
            txtCpf.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(235, 81);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(222, 23);
            txtNome.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.Location = new Point(235, 43);
            txtId.Name = "txtId";
            txtId.Size = new Size(56, 23);
            txtId.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(105, 519);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(572, 150);
            dataGridView1.TabIndex = 1;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1259, 710);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCliente";
            Text = "FrmCliente";
            Load += FrmCliente_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnInserir;
        private Button btnConsultar;
        private Button btnEditar;
        private GroupBox groupBox1;
        private TextBox txtId;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private TextBox txtCpf;
        private TextBox txtNome;
        private DataGridView dataGridView1;
        private Label label4;
        private Label label3;
        private DateTimePicker txtDataNascimento;
        private Label label6;
        private Label label5;
        private Label label7;
        private Label label8;
    }
}