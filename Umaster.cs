using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPP
{
    public partial class Umaster : UserControl
    {

        public Umaster()
        {
            InitializeComponent();
        }

        Upetugas pt = new Upetugas();
        Usiswa swa = new Usiswa();

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(pt);
            pt.Dock = DockStyle.Fill;
        }

        private void Umaster_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(pt);
            pt.Dock = DockStyle.Fill;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(swa);
            swa.Dock = DockStyle.Fill;
        }
    }
}
