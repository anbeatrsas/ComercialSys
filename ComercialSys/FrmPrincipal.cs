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

            //FrmLogin login = new();
            //login.MdiParent = this;

            //login.StartPosition = FormStartPosition.CenterScreen;
            // this.Hide(); // so visualizar a tela de login
            //login.ShowDialog();

            //tslUsuario.Text = Program.Usuario.Nome + " - " + Program.Usuario.Nivel.Nome;



        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProduto frmProduto = new();

            frmProduto.StartPosition = FormStartPosition.CenterScreen; 
            frmProduto.Show();

        }
    }
}
