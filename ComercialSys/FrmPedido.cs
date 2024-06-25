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

        Produto produto = new();

        private void txtNumeroPedido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodBarras_TextChanged(object sender, EventArgs e)
        {

            if (txtCodBarras.Text.Length > 4)
            {

                produto = Produto.ObterPorId(int.Parse(txtCodBarras.Text));
                if (produto.Id > 0)
                {
                    txtDescricao.Text = produto.Descricao;
                    txtValorUnit.Text = produto.Valor_unit.ToString();
                    lblDescMax.Text = $"R$ {produto.Classe_desconto * produto.Valor_unit}";

                }


            }

        }

        private void btnInserirItem_Click(object sender, EventArgs e)
        {
            ItemPedido itemPedido = new(int.Parse(txtNumeroPedido.Text),
                Produto.ObterPorId(int.Parse(txtCodBarras.Text)),
                double.Parse(txtValorUnit.Text),
                double.Parse(txtQuantidade.Text),
                double.Parse(txtDescontoItem.Text)
                );
            itemPedido.Inserir();
            // Limpa controles
            txtCodBarras.Clear();
            txtDescontoItem.Text = "0";
            txtDescricao.Clear();
            txtQuantidade.Text = "1";
            txtValorUnit.Clear();
            txtCodBarras.Focus();


            CarregaGrid();



        }

        private void CarregaGrid()
        {

            dgvItens.Rows.Clear();
            var itens = ItemPedido.ObterListaPorPedido(int.Parse(txtNumeroPedido.Text));
            int count = 0;
            double subTotal = 0;

            foreach (var item in itens)
            {

                dgvItens.Rows.Add();
                dgvItens.Rows[count].Cells[0].Value = $"#{count + 1}"; // linha seq
                dgvItens.Rows[count].Cells[1].Value = item.Produto.Cod_barras;
                dgvItens.Rows[count].Cells[2].Value = item.Produto.Descricao;
                dgvItens.Rows[count].Cells[3].Value = item.Produto.Unidade_venda;
                dgvItens.Rows[count].Cells[4].Value = item.ValorUnit;
                dgvItens.Rows[count].Cells[5].Value = item.Quantidade;
                dgvItens.Rows[count].Cells[6].Value = item.Desconto;
                dgvItens.Rows[count].Cells[7].Value = item.ValorUnit * item.Quantidade - item.Desconto;
                dgvItens.Rows[count].Cells[8].Value = item.Id;
                subTotal += item.ValorUnit * item.Quantidade - item.Desconto;


                count++;

            }

            txtSubtotal.Text = subTotal.ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantidade.Text.Length > 0)
            {
                lblDescMax.Text = $"R$ {produto.Classe_desconto * produto.Valor_unit * decimal.Parse(txtQuantidade.Text)}";
            }
        }

        private void btnExcluirItem_Click(object sender, EventArgs e)
        {

            if (dgvItens.Rows.Count > 0)
            {

                int linha = dgvItens.CurrentRow.Index; // linha atual é armazenada em linha
                string seq = dgvItens.Rows[linha].Cells[0].Value.ToString();
                var confirma = MessageBox.Show($"Deseja confirmar a exclusão do Item {seq}?", "Excluir Item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirma == DialogResult.Yes)
                {
                    ItemPedido.Remover(Convert.ToInt32(dgvItens.Rows[linha].Cells[8].Value));
                    CarregaGrid();
                }


            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
