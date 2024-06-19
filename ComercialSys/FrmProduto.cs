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

            Produto produto = new Produto(txtCodBarras.Text, txtDescricao.Text, decimal.Parse(txtValorUnit.Text), txtUnidadeVenda.Text, Categoria.ObterPorId(Convert.ToInt32(cmbCategoria.SelectedValue)),
            (npEstoqueMinimo.Value), decimal.Parse(txtDesconto.Text));
            produto.Inserir();

            FrmProduto_Load(sender, e);

        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {

            var categorias = Categoria.ObterLista();
            cmbCategoria.DataSource = categorias;
            cmbCategoria.ValueMember = "id";
            cmbCategoria.DisplayMember = "nome";

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
                dgvProdutos.Rows[count].Cells[4].Value = produto.Unidade_venda;
                dgvProdutos.Rows[count].Cells[5].Value = produto.Categoria.Nome;
                dgvProdutos.Rows[count].Cells[6].Value = produto.Estoque_minimo;
                dgvProdutos.Rows[count].Cells[7].Value = produto.Classe_desconto;

                count++;

            }


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            Produto produto = new(
            Convert.ToInt32(txtId.Text),
            txtCodBarras.Text,
            txtDescricao.Text,
            decimal.Parse(txtValorUnit.Text),
            txtUnidadeVenda.Text,
            Categoria.ObterPorId(Convert.ToInt32(cmbCategoria.SelectedValue)),
            npEstoqueMinimo.Value,
            decimal.Parse(txtDesconto.Text)

            );

            if (produto.Editar(produto.Id))
            {

                FrmProduto_Load(sender, e);
                MessageBox.Show("O produto foi editado com sucesso!");

            }
            else
            {
                MessageBox.Show("Falha ao editar produto");
            }


        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            if (btnConsultar.Text == "&Consultar")
            {

                txtCodBarras.Clear();
                txtValorUnit.Clear();
                txtUnidadeVenda.Clear();
                npEstoqueMinimo.Value = 0;
                txtDescricao.Clear();
                txtDesconto.Clear();

                txtId.ReadOnly = false;
                txtId.Focus();
                btnConsultar.Text = "Obter por ID";


            }
            else
            {
                if (txtId.Text.Length > 0)
                {

                    Produto produto = Produto.ObterPorId(int.Parse(txtId.Text));
                    txtCodBarras.Text = produto.Cod_barras;
                    txtDesconto.Text = Convert.ToString(produto.Classe_desconto);
                    txtValorUnit.Text = Convert.ToString(produto.Valor_unit);
                    txtUnidadeVenda.Text = produto.Unidade_venda;

                    cmbCategoria.SelectedIndex = cmbCategoria.FindString(produto.Categoria.Nome);
                    txtDescricao.Text = produto.Descricao;
                    npEstoqueMinimo.Value = produto.Estoque_minimo;

                    txtId.ReadOnly = true;
                    btnConsultar.Text = "&Consultar";
                    btnEditar.Enabled = true;


                }
            }

        }
    }
}
