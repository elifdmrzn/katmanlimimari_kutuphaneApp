namespace kutuphaneApp.UI.WinForm
{
    partial class kitaplar
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
            this.btnSil = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKno = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYayin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kaydet = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(725, 140);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(87, 37);
            this.btnSil.TabIndex = 26;
            this.btnSil.Text = "sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtKno);
            this.groupBox2.Location = new System.Drawing.Point(663, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 87);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Sil";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Kitap No";
            // 
            // txtKno
            // 
            this.txtKno.Location = new System.Drawing.Point(78, 41);
            this.txtKno.Name = "txtKno";
            this.txtKno.Size = new System.Drawing.Size(100, 20);
            this.txtKno.TabIndex = 0;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(524, 235);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(89, 37);
            this.btnGuncelle.TabIndex = 24;
            this.btnGuncelle.Text = "güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtNo);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.txtYazar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtYil);
            this.groupBox1.Controls.Add(this.txtSayi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtYayin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(417, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 188);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Ekle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Kitap Adı";
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(107, 19);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(100, 20);
            this.txtNo.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.SystemColors.Window;
            this.txtAd.Location = new System.Drawing.Point(107, 45);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 4;
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(107, 71);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(100, 20);
            this.txtYazar.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Yayınevi";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sayfa Sayısı";
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(107, 97);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(100, 20);
            this.txtYil.TabIndex = 5;
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(107, 123);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(100, 20);
            this.txtSayi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Baskı Yılı";
            // 
            // txtYayin
            // 
            this.txtYayin.Location = new System.Drawing.Point(107, 149);
            this.txtYayin.Name = "txtYayin";
            this.txtYayin.Size = new System.Drawing.Size(100, 20);
            this.txtYayin.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kitap Yazarı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kitap No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 10;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(427, 235);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(88, 37);
            this.btnKaydet.TabIndex = 25;
            this.btnKaydet.Text = "kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(336, 220);
            this.dataGridView1.TabIndex = 20;
            // 
            // kaydet
            // 
            this.kaydet.Location = new System.Drawing.Point(121, 266);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(78, 37);
            this.kaydet.TabIndex = 21;
            this.kaydet.Text = "listele";
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // kitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(875, 408);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.kaydet);
            this.Name = "kitaplar";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.kitaplar_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKno;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYayin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button kaydet;
    }
}