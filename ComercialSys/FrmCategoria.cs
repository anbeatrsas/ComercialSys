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
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }


        private void btnInserir_Click(object sender, EventArgs e)
        {

            Categoria categoria = new Categoria(txtNome.Text, txtSigla.Text);
            categoria.Inserir();

            FrmCategoria_Load_1(sender, e);

        }



        private void FrmCategoria_Load_1(object sender, EventArgs e)
        {

            var lista = Categoria.ObterLista();
            dgvCategoria.Rows.Clear();
            int count = 0;

            foreach (var categoria in lista)
            {

                dgvCategoria.Rows.Add();
                dgvCategoria.Rows[count].Cells[0].Value = categoria.Id;
                dgvCategoria.Rows[count].Cells[1].Value = categoria.Nome;
                dgvCategoria.Rows[count].Cells[2].Value = categoria.Sigla;

                count++;


            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            if (btnConsultar.Text == "&Consultar")
            {

                txtNome.Clear();
                txtSigla.Clear();

                txtId.ReadOnly = false;
                txtId.Focus();
                btnConsultar.Text = "Obter por ID";


            }

            else
            {

                if (txtId.Text.Length > 0)
                {

                    Categoria categoria = Categoria.ObterPorId(int.Parse(txtId.Text));
                    txtNome.Text = categoria.Nome;
                    txtSigla.Text = categoria.Sigla;
                    txtId.ReadOnly = true;
                    btnConsultar.Text = "&Consultar";

                    btnEditar.Enabled = true;


                }

            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            Categoria categoria = new(

                int.Parse(txtId.Text),
                txtNome.Text,
                txtSigla.Text

                ) ;

            if (categoria.Editar(categoria.Id))
            {

                FrmCategoria_Load_1(sender, e);
                MessageBox.Show($"A categoria {categoria.Nome} foi alterado com sucesso!");

            }
            else
            {

                MessageBox.Show($"Falha ao alterar a categoria \"{categoria.Nome}\" !");

            }

        }
    }
}
