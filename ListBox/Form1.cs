using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btntm_Click(object sender, EventArgs e)
        {
            if (txtısım.Text!=string.Empty)
            {
                string isim = string.Format("{0}-{1}",listkisiler.Items.Count + 1,txtısım.Text);
                listkisiler.Items.Add(isim);
                listkisiler.ClearSelected();
                listkisiler.Focus();
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            string[] silinecekler = new string[listkisiler.SelectedItems.Count];
            for (int i = 0; i < listkisiler.SelectedItems.Count; i++)
            {
                silinecekler[i] = (string)
                listkisiler.SelectedItems[i];         
            }
            foreach (string item in silinecekler)
            {
                listkisiler.Items.Remove(item);
            }
        }

        private void btnsil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                string[] silinecekler = new string[listkisiler.SelectedItems.Count];
                for (int i = 0; i < listkisiler.SelectedItems.Count; i++)
                {
                    silinecekler[i] = (string)
                    listkisiler.SelectedItems[i];
                }
                foreach (string item in silinecekler)
                {
                    listkisiler.Items.Remove(item);
                }
            }

        }

        private void btntm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                if (txtısım.Text != string.Empty)
                {
                    string isim = string.Format("{0}-{1}", listkisiler.Items.Count + 1, txtısım.Text);
                    listkisiler.Items.Add(isim);
                    listkisiler.ClearSelected();
                    listkisiler.Focus();
                }
            }
        }

        private void listkisiler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
