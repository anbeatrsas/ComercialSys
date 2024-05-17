namespace ComercialSys
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.MdiParent = this;
            frmCliente.StartPosition = FormStartPosition.CenterScreen; // mostrar a janela no meio da tela

            frmCliente.Show();

        }

        private void usu�rioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmUsuario frmUsuario = new FrmUsuario(); 
            frmUsuario.MdiParent = this; // quem � o pai da frmUsu�rio? MdiParent = this, no caso o pai � a janela atual por isso usamos this
            frmUsuario.Show();

            frmUsuario.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
