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
    public partial class FrmPedido : Form
    {
        public FrmPedido()
        {
            InitializeComponent();
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {

            txtVendedor.Text = Program.Usuario.Id + " - " + Program.Usuario.Nome;

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox3.Clear();
            if (textBox2.Text.Length > 0)
            {
                var cliente = Cliente.ObterPorId(int.Parse(textBox2.Text));
                if (cliente.Id > 0)
                {
                    textBox3.Text = cliente.Nome;
                }
            }
        }

        private void btnAbrirNovo_Click(object sender, EventArgs e)
        {

            Pedido pedido = new();
            pedido.Cliente = Cliente.ObterPorId(int.Parse(textBox2.Text));
            pedido.Usuario = Program.Usuario;
            pedido.Status = "A";
            pedido.Desconto = 0;
            pedido.Inserir();
            txtNumeroPedido.Text = pedido.Id.ToString();
            gbxProduto.Enabled = true;

            btnAbrirNovo.Enabled = false;


        }

        private void txtNumeroPedido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodBarras_TextChanged(object sender, EventArgs e)
        {

            if (txtCodBarras.Text.Length > 4)
            {

                var produto = Produto.ObterPorId(int.Parse(txtCodBarras.Text));
                if (produto.Id > 0)
                {
                    txtDescricao.Text = produto.Descricao;
                    txtValorUnit.Text = produto.Valor_unit.ToString();


                }


            }

        }

        private void btnInserirItem_Click(object sender, EventArgs e)
        {
            ItemPedido itemPedido = new(int.Parse(txtNumeroPedido.Text), 
                Produto.ObterPorId(int.Parse(txtCodBarras.Text)), 
                double.Parse(txtValorUnit.Text), 
                double.Parse(txtQuantidade.Text), 
                0
                );
            itemPedido.Inserir();
        }
    }
}
