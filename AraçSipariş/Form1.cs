using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AraçSipariş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = colorDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                btnRenk.BackColor = colorDialog1.Color;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbModel.Items.Clear();
            switch (cmbMarka.Text)
            {
                
                case "VOLKSWAGEN":
                    
                    cmbModel.Items.Add("JETTA");
                    cmbModel.Items.Add("PASSAT");
                    cmbModel.Items.Add("CC");
                    break;                   
                case "AUDI":
                    cmbModel.Items.Add("A7");
                    cmbModel.Items.Add("Q7");
                    cmbModel.Items.Add("V8");
                    break;
                case "RENAULT":
                    cmbModel.Items.Add("CLIO");
                    cmbModel.Items.Add("LAGUNA");
                    cmbModel.Items.Add("SYMBOL");
                    break;
                case "HYUNDAI":
                    cmbModel.Items.Add("ACCENT");
                    cmbModel.Items.Add("İ 30");
                    cmbModel.Items.Add("İX 35");
                    break;
                case "HONDA":
                    cmbModel.Items.Add("CIVIC");
                    cmbModel.Items.Add("CITY");
                    cmbModel.Items.Add("CR-V");
                    break;
                case "BMW":
                    cmbModel.Items.Add("M60 CUPE");
                    cmbModel.Items.Add("X6");
                    cmbModel.Items.Add("5.25");
                    break;
                case "MERCEDES":
                    cmbModel.Items.Add("200 AMG");
                    cmbModel.Items.Add("E 250");
                    cmbModel.Items.Add("CLA 200");
                    break;

                default:
                    break;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.UseItemStyleForSubItems = false;
            lvi.Text = cmbMarka.Text;
            lvi.SubItems.Add(cmbModel.Text);
            lvi.SubItems.Add(cmbYakıtTipi.Text);
            lvi.SubItems.Add(cmbKasaTipi.Text);
            lvi.SubItems.Add(cmbVitesTipi.Text);
            lvi.SubItems.Add(cmbMotorTipi.Text.ToString());
            lvi.SubItems.Add(string.Empty);
            lvi.SubItems[6].BackColor = btnRenk.BackColor;
            lvi.SubItems.Add(dtpYil.Value.ToShortDateString());
            listView1.Items.Add(lvi);
            

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).SelectedIndex = -1;
                }
                else if(ctrl is Button)
                {
                    ((Button)ctrl).BackColor = Color.Empty;
                }
                else if (ctrl is DateTimePicker)
                {
                    ((DateTimePicker)ctrl).Value = DateTime.Now;
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count >0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }

            
        }
        ListViewItem secili;
        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count ==0)
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz kaydı seçiniz ");
                return;
            }

            secili = listView1.SelectedItems[0];
            cmbMarka.Text = secili.Text;
            cmbModel.Text = secili.SubItems[1].Text;
            cmbYakıtTipi.Text = secili.SubItems[2].Text;
            cmbKasaTipi.Text = secili.SubItems[3].Text;
            cmbVitesTipi.Text = secili.SubItems[4].Text;
            cmbMotorTipi.Text = secili.SubItems[5].Text;
            btnRenk.BackColor = secili.SubItems[6].BackColor;
            dtpYil.Value =Convert.ToDateTime(string.Format("01.01.{0}",secili.SubItems[7].Text));

            //burada bir hata var 
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            secili.SubItems[0].Text = cmbMarka.Text;
            secili.SubItems[1].Text = cmbModel.Text;
            secili.SubItems[2].Text = cmbYakıtTipi.Text;
            secili.SubItems[3].Text = cmbKasaTipi.Text;
            secili.SubItems[4].Text = cmbVitesTipi.Text;
            secili.SubItems[5].Text = cmbMotorTipi.Text;
            secili.SubItems[6].BackColor = btnRenk.BackColor;
            secili.SubItems[7].Text = dtpYil.Text;

        }
    }
}
