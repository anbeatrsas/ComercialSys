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
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            Produto produto = new Produto(txtCodBarras.Text, txtDescricao.Text, decimal.Parse(txtValorUnit.Text), txtUnidadeVenda.Text, int.Parse(txtCategoriaId.Text),
            (npEstoqueMinimo.Value), decimal.Parse(txtDesconto.Text));
            produto.Inserir();



        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {

            var lista = Produto.ObterLista();
            dgvProdutos.Rows.Clear();
            int count = 0;

            foreach (var produto in lista)
            {

                dgvProdutos.Rows.Add();
                dgvProdutos.Rows[count].Cells[0].Value = produto.Id;
                dgvProdutos.Rows[count].Cells[1].Value = produto.Cod_barras;
                dgvProdutos.Rows[count].Cells[2].Value = produto.Descricao;
                dgvProdutos.Rows[count].Cells[3].Value = produto.Valor_unit;
                dgvProdutos.Rows[count].Cells[4].Value = produto.;

                count++;

            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
