namespace Hilos
{
    public partial class frmHilo : Form
    {
        Thread proceso1, proceso2;
        byte r, g;
        bool b1, b2;
        public frmHilo()
        {
            InitializeComponent();
        }

        private void hilosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHiloOr frm2 = new frmHiloOr();
            frm2.Show();
        }

        private void hilosSemaforoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHilosSemaforo frmHS = new frmHilosSemaforo();
            frmHS.Show();
        }

        private void hilosSemaforoTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHiloScT frmHScT = new frmHiloScT();
            frmHScT.Show();
        }
    }
}
