using System.Windows.Forms;

namespace StatusReuniao
{
    public partial class StatusReuniao : Form
    {
        public StatusReuniao()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            this.Size = pictureBox1.Size;
            this.TopMost = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                pictureBox1.Image = Properties.Resources.movendo2;
                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = 18000; // 15 segundos
                timer.Tick += (sender, args) =>
                {
                    pictureBox1.Image = Properties.Resources.aberta2;
                    timer.Stop();
                };
                timer.Start();
            }

            if (e.KeyCode == Keys.F)
            {
                pictureBox1.Image = Properties.Resources.movendo2;
                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = 18000; // 15 segundos
                timer.Tick += (sender, args) =>
                {
                    pictureBox1.Image = Properties.Resources.fechada2;
                    timer.Stop();
                };
                timer.Start();
            }

            if (e.KeyCode == Keys.S)
            {
                pictureBox1.Image = Properties.Resources.movendo2;
                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = 18000; // 15 segundos
                timer.Tick += (sender, args) =>
                {
                    pictureBox1.Image = Properties.Resources.sigilosa2;
                    timer.Stop();
                };
                timer.Start();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.ContextMenuStrip = contextMenuStrip1;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        formSobre form2 = new formSobre();

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form2 = new formSobre();
            form2.Show();
        }
    }
}
