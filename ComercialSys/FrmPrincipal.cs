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
            frmUsuario.StartPosition = FormStartPosition.CenterScreen;
            frmUsuario.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmCategoria frmCategoria = new FrmCategoria();
            frmCategoria.MdiParent = this;
            
            frmCategoria.StartPosition = FormStartPosition.CenterScreen;
            frmCategoria.Show();

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
