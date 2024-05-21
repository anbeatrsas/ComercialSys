﻿using ComClassSys;
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

            string nivel = String.Empty;
            nivel = cmbNivel.SelectedIndex == 0 ? "A" : "G"; // se o index selecionado for igual a 0 entao == "a" 

            Usuario usuario = new Usuario(txtNome.Text, txtEmail.Text, txtSenha.Text, nivel);
            usuario.Inserir();

            FrmUsuario_Load(sender, e);

            // criando uma nova instancia de usuario com seus parâmetros e clicamos em inserir


        }


        private void FrmUsuario_Load(object sender, EventArgs e)
        {

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
                dgvUsuarios.Rows[count].Cells[3].Value = usuario.Nivel;
                dgvUsuarios.Rows[count].Cells[4].Value = usuario.Ativo;

                count++;

            }

        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {

            if (btnConsultar.Text == "&Consultar")
            {
                txtId.ReadOnly = false;
                txtId.Focus(); // cursor piscando dentro da caixa de id
                btnConsultar.Text = "Obter por ID";
            }
            else
            {

                if(txtId.Text.Length > 0)
                {

                    Usuario usuario = Usuario.ObterPorId(int.Parse(txtId.Text));
                    txtNome.Text = usuario.Nome;
                    txtEmail.Text = usuario.Email;
                    txtId.ReadOnly = true;
                    btnConsultar.Text = "&Consultar";


                }

            }

            

        }
    }
}
