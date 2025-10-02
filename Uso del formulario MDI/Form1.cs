namespace Uso_del_formulario_MDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void abrirFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioHijo FH = new FormularioHijo();
            FH.MdiParent = this;
            FH.Show();
        }
    }
}
