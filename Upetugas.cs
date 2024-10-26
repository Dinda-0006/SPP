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
    public partial class Upetugas : UserControl
    {
        public Upetugas()
        {
            InitializeComponent();
        }

        Module md = new Module();
        string id, sql;
        bool aksi = true;

        public void awal()
        {
            dataGridView1.DataSource = md.getData("SELECT * FROM petugas WHERE petugas LIKE '%" + textBox1.Text + "%'");
            md.clearForm(groupBox2);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Petugas";
            dataGridView1.Columns[2].HeaderText = "Alamat";
            dataGridView1.Columns[3].HeaderText = "Username";
            dataGridView1.Columns[4].Visible = false;
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
            groupBox3.Enabled = true;
            id = "0";
            aksi = true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox5.UseSystemPasswordChar = false;
            }
            else
            {
                textBox5.UseSystemPasswordChar = true;
            }
        }

        void buka()
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
            groupBox3.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            awal();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Upetugas_Load(object sender, EventArgs e)
        {
            
        }
    }
}
