namespace ListBox
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
            this.btntm = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnkarıs = new System.Windows.Forms.Button();
            this.lblısım = new System.Windows.Forms.Label();
            this.listkisiler = new System.Windows.Forms.ListBox();
            this.txtısım = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btntm
            // 
            this.btntm.Location = new System.Drawing.Point(427, 83);
            this.btntm.Name = "btntm";
            this.btntm.Size = new System.Drawing.Size(75, 23);
            this.btntm.TabIndex = 0;
            this.btntm.Text = "Tamam";
            this.btntm.UseVisualStyleBackColor = true;
            this.btntm.Click += new System.EventHandler(this.btntm_Click);
            this.btntm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btntm_KeyDown);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(427, 112);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 23);
            this.btnsil.TabIndex = 1;
            this.btnsil.Text = "sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            this.btnsil.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnsil_KeyDown);
            // 
            // btnkarıs
            // 
            this.btnkarıs.Location = new System.Drawing.Point(427, 141);
            this.btnkarıs.Name = "btnkarıs";
            this.btnkarıs.Size = new System.Drawing.Size(75, 23);
            this.btnkarıs.TabIndex = 2;
            this.btnkarıs.Text = "Karıştır";
            this.btnkarıs.UseVisualStyleBackColor = true;
            // 
            // lblısım
            // 
            this.lblısım.AutoSize = true;
            this.lblısım.Location = new System.Drawing.Point(104, 83);
            this.lblısım.Name = "lblısım";
            this.lblısım.Size = new System.Drawing.Size(32, 17);
            this.lblısım.TabIndex = 3;
            this.lblısım.Text = "İsim";
            this.lblısım.Click += new System.EventHandler(this.label1_Click);
            // 
            // listkisiler
            // 
            this.listkisiler.FormattingEnabled = true;
            this.listkisiler.ItemHeight = 16;
            this.listkisiler.Location = new System.Drawing.Point(156, 112);
            this.listkisiler.Name = "listkisiler";
            this.listkisiler.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listkisiler.Size = new System.Drawing.Size(242, 212);
            this.listkisiler.TabIndex = 4;
            this.listkisiler.SelectedIndexChanged += new System.EventHandler(this.listkisiler_SelectedIndexChanged);
            // 
            // txtısım
            // 
            this.txtısım.Location = new System.Drawing.Point(156, 80);
            this.txtısım.Name = "txtısım";
            this.txtısım.Size = new System.Drawing.Size(100, 22);
            this.txtısım.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.txtısım);
            this.Controls.Add(this.listkisiler);
            this.Controls.Add(this.lblısım);
            this.Controls.Add(this.btnkarıs);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btntm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntm;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnkarıs;
        private System.Windows.Forms.Label lblısım;
        private System.Windows.Forms.ListBox listkisiler;
        private System.Windows.Forms.TextBox txtısım;
    }
}

