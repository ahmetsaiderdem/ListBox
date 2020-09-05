using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txttel_Click(object sender, EventArgs e)
        {

        }

        private void txtisim_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = txtisim.Text;
            lvi.SubItems.Add(txtsoyisim.Text);
            string telefon = string.Format("{0} {1} {2}", comboBox1.Text, comboBox2.Text, txtmasktel.Text);
            lvi.SubItems.Add(telefon);
            lvi.SubItems.Add(dtpdogumtarihi.Value.ToShortDateString());
            listView1.Items.Add(lvi);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }
    }
}
