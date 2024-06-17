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

        }
    }
}
