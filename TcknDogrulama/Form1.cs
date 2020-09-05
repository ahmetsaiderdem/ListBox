using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcknDogrulama
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

        private void btndogru_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.MaskFull)
            {
                string sonHane = maskedTextBox1.Text[10].ToString();
                int sonHaneNum = Convert.ToInt32(sonHane);
                if (sonHaneNum % 2 != 0)
                {
                    MessageBox.Show("TC Kimlik Numarası Hatalıdır!");
                }

                else
                {
                    int Toplam = 0;
                    for (int i = 0; i < maskedTextBox1.Text.Length - 1; i++)
                    {
                        string rkm = maskedTextBox1.Text[i].ToString();
                        Toplam += Convert.ToInt32(rkm);
                    }
                    if (Toplam % 10 == sonHaneNum)
                    {
                        MessageBox.Show("TC Kimlik Numarası Doğrudur");
                    }
                    else
                    {
                        MessageBox.Show("TC Kimlik Numarası Hataldır");
                    }
                }
                MessageBox.Show(sonHaneNum.ToString());
            }
            else
            {
                MessageBox.Show("Lütfen 11 haneli TC Kimlik Numarası Giriniz");
            }

        }
    }
}
