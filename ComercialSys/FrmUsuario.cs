using ComClassSys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercialSys
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {


            Usuario usuario = new Usuario(txtNome.Text, txtEmail.Text, txtSenha.Text, Nivel.ObterPorId(Convert.ToInt32(cmbNivel.SelectedValue)));
            usuario.Inserir();

            FrmUsuario_Load(sender, e);



        }


        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            //cmbNivel.Items.Clear();
            var niveis = Nivel.ObterLista();
            cmbNivel.DataSource = niveis;
            cmbNivel.DisplayMember = "nome"; // display = exibir o nome do nivel
            cmbNivel.ValueMember = "id"; // quer que o valor que retone é o id


            var lista = Usuario.ObterLista();
            //quando usamos var o nome que nos declaramos ao objeto ele vai se comportar de acordo com oq vem depois do sinal de "="
            dgvUsuarios.Rows.Clear();
            int count = 0;

            foreach (var usuario in lista)
            {
                dgvUsuarios.Rows.Add(); // adicionando uma nova linha no datagrid
                dgvUsuarios.Rows[count].Cells[0].Value = usuario.Id;
                dgvUsuarios.Rows[count].Cells[1].Value = usuario.Nome;
                dgvUsuarios.Rows[count].Cells[2].Value = usuario.Email;
                dgvUsuarios.Rows[count].Cells[3].Value = usuario.Nivel.Nome; // queremos mostrar o nome do nivel
                dgvUsuarios.Rows[count].Cells[4].Value = usuario.Ativo;

                count++;

            }

        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {

            if (btnConsultar.Text == "&Consultar")
            {
                txtNome.Clear(); // limpa nome
                txtEmail.Clear(); // limpa email
                txtSenha.Clear(); // limpa campo senha
                txtConfSenha.Clear(); // limpa confSenha

                txtId.ReadOnly = false;
                txtId.Focus(); // cursor piscando dentro da caixa de id
                btnConsultar.Text = "Obter por ID";
                txtSenha.PlaceholderText = string.Empty;



            }
            else
            {

                if (txtId.Text.Length > 0)
                {

                    Usuario usuario = Usuario.ObterPorId(int.Parse(txtId.Text));
                    txtNome.Text = usuario.Nome;
                    txtEmail.Text = usuario.Email;
                    txtId.ReadOnly = true;
                    btnConsultar.Text = "&Consultar";
                    txtSenha.PlaceholderText = "[senha não alterada]"; // se o usuario nao digitar nenhuma senha isso sera mostrado
                    cmbNivel.SelectedValue = usuario.Nivel.Id; // faca com que o valor selecionado retorne como o id do nível de usuario

                    btnEditar.Enabled = true;
                }

            }



        }

        private void cmbNivel_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            //método construtor editar 

            Usuario usuario = new(
                int.Parse(txtId.Text),
                txtNome.Text,
                txtEmail.Text,
                txtSenha.Text,
                Nivel.ObterPorId(Convert.ToInt32(cmbNivel.SelectedValue)),
                true
                );

            if (usuario.Editar(usuario.Id))
            {

                FrmUsuario_Load(sender, e); // gravando a dateGridView com os novos dados
                MessageBox.Show($"O usuario {usuario.Nome} foi alterado com sucesso!");

            }
            else
            {
                MessageBox.Show($"Falha ao alterar o Usuário \"{usuario.Nome}\" !");

            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (txtBusca.Text.Length > 0)
            {


                var lista = Usuario.ObterLista(txtBusca.Text);
                //quando usamos var o nome que nos declaramos ao objeto ele vai se comportar de acordo com oq vem depois do sinal de "="
                dgvUsuarios.Rows.Clear();
                int count = 0;

                foreach (var usuario in lista)
                {
                    dgvUsuarios.Rows.Add(); // adicionando uma nova linha no datagrid
                    dgvUsuarios.Rows[count].Cells[0].Value = usuario.Id;
                    dgvUsuarios.Rows[count].Cells[1].Value = usuario.Nome;
                    dgvUsuarios.Rows[count].Cells[2].Value = usuario.Email;
                    dgvUsuarios.Rows[count].Cells[3].Value = usuario.Nivel.Nome; // queremos mostrar o nome do nivel
                    dgvUsuarios.Rows[count].Cells[4].Value = usuario.Ativo;

                    count++;

                }
            }

            else
            {
                FrmUsuario_Load(sender, e);
            }


            
        }
    }
}
