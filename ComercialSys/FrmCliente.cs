using ComClassSys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercialSys
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            DateTime dataNascimento = txtDataNascimento.Value;

            Cliente cliente = new Cliente(txtNome.Text, txtCpf.Text, txtTelefone.Text, txtEmail.Text, dataNascimento);
            cliente.Inserir();

            FrmCliente_Load(sender, e);

        }
    }
}
