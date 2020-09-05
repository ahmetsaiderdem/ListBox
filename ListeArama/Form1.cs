using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListeArama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void btnekle_Click(object sender, EventArgs e)
        {          
            if (txtIsim.Text != string.Empty)
            {
                listBox1.Items.Add(txtIsim.Text.ToUpper().Trim());
                txtIsim.Clear();
                txtIsim.Focus();              
            }
        }

        private void btnkisisayisi_Click(object sender, EventArgs e)
        {
            int adet = listBox1.Items.Count;
            MessageBox.Show(adet.ToString());

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtisimAra.Text != string.Empty)
            {
                string isim = txtisimAra.Text.ToUpper().Trim();
                if (listBox1.Items.Contains(isim))
                {
                    MessageBox.Show("Aranan İsim Liste de Var");
                }
                else
                {
                    MessageBox.Show("Aranan İsim Liste de Yok");
                }
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtisimAra_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtisimAra.Text.ToUpper().Trim();
            ArrayList isimler = new ArrayList();

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                isimler.Add(listBox1.Items[i].ToString());
            }
            foreach (string item in isimler)
            {
                if (!item.Contains(aranan))
                {
                    listBox1.Items.Remove(item);
                }
            }
            
        }
    }
}
