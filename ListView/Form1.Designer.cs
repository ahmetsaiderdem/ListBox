namespace ListView
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtisim = new System.Windows.Forms.TextBox();
            this.Soyisim = new System.Windows.Forms.Label();
            this.txtsoyisim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.Label();
            this.txtmasktel = new System.Windows.Forms.MaskedTextBox();
            this.dtpdogumtarihi = new System.Windows.Forms.DateTimePicker();
            this.btnekle = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 117);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(549, 294);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İsim";
            this.columnHeader1.Width = 125;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyisim";
            this.columnHeader2.Width = 126;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Telefon";
            this.columnHeader3.Width = 143;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "DoğumTarihi";
            this.columnHeader4.Width = 227;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "İsim";
            // 
            // txtisim
            // 
            this.txtisim.Location = new System.Drawing.Point(63, 14);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(100, 22);
            this.txtisim.TabIndex = 0;
            this.txtisim.TextChanged += new System.EventHandler(this.txtisim_TextChanged);
            // 
            // Soyisim
            // 
            this.Soyisim.AutoSize = true;
            this.Soyisim.Location = new System.Drawing.Point(183, 17);
            this.Soyisim.Name = "Soyisim";
            this.Soyisim.Size = new System.Drawing.Size(56, 17);
            this.Soyisim.TabIndex = 1;
            this.Soyisim.Text = "Soyisim";
            // 
            // txtsoyisim
            // 
            this.txtsoyisim.Location = new System.Drawing.Point(243, 14);
            this.txtsoyisim.Name = "txtsoyisim";
            this.txtsoyisim.Size = new System.Drawing.Size(100, 22);
            this.txtsoyisim.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Doğum Tarihi";
            // 
            // txttel
            // 
            this.txttel.AutoSize = true;
            this.txttel.Location = new System.Drawing.Point(12, 66);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(56, 17);
            this.txttel.TabIndex = 1;
            this.txttel.Text = "Telefon";
            this.txttel.Click += new System.EventHandler(this.txttel_Click);
            // 
            // txtmasktel
            // 
            this.txtmasktel.Location = new System.Drawing.Point(222, 68);
            this.txtmasktel.Mask = "000-0000";
            this.txtmasktel.Name = "txtmasktel";
            this.txtmasktel.Size = new System.Drawing.Size(100, 22);
            this.txtmasktel.TabIndex = 3;
            this.txtmasktel.ValidatingType = typeof(int);
            // 
            // dtpdogumtarihi
            // 
            this.dtpdogumtarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdogumtarihi.Location = new System.Drawing.Point(448, 17);
            this.dtpdogumtarihi.Name = "dtpdogumtarihi";
            this.dtpdogumtarihi.Size = new System.Drawing.Size(113, 22);
            this.dtpdogumtarihi.TabIndex = 2;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(328, 68);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 4;
            this.btnekle.Text = "ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "+90",
            "+850",
            "+01",
            "+85",
            "+98",
            "+546"});
            this.comboBox1.Location = new System.Drawing.Point(74, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(63, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "505",
            "506",
            "507",
            "509",
            "530",
            "531",
            "532",
            "533",
            "534",
            "535",
            "536",
            "537",
            "538",
            "539",
            "540",
            "541",
            "542",
            "543",
            "544",
            "545",
            "546"});
            this.comboBox2.Location = new System.Drawing.Point(144, 66);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(72, 24);
            this.comboBox2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 423);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.dtpdogumtarihi);
            this.Controls.Add(this.txtmasktel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsoyisim);
            this.Controls.Add(this.Soyisim);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtisim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.Label Soyisim;
        private System.Windows.Forms.TextBox txtsoyisim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txttel;
        private System.Windows.Forms.MaskedTextBox txtmasktel;
        private System.Windows.Forms.DateTimePicker dtpdogumtarihi;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

