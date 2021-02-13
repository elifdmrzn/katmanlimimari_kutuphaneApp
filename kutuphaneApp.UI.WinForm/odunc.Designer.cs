namespace kutuphaneApp.UI.WinForm
{
    partial class odunc
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.alma = new System.Windows.Forms.DateTimePicker();
            this.verme = new System.Windows.Forms.DateTimePicker();
            this.txtUyeNo = new System.Windows.Forms.TextBox();
            this.txtOdunc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnkyt = new System.Windows.Forms.Button();
            this.btngncl = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txton = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnkaldir = new System.Windows.Forms.Button();
            this.btnliste = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(381, 274);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.alma);
            this.groupBox1.Controls.Add(this.verme);
            this.groupBox1.Controls.Add(this.txtUyeNo);
            this.groupBox1.Controls.Add(this.txtOdunc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(456, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 161);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ödünç Ver";
            // 
            // alma
            // 
            this.alma.Location = new System.Drawing.Point(130, 123);
            this.alma.Name = "alma";
            this.alma.Size = new System.Drawing.Size(134, 20);
            this.alma.TabIndex = 7;
            // 
            // verme
            // 
            this.verme.Location = new System.Drawing.Point(130, 87);
            this.verme.Name = "verme";
            this.verme.Size = new System.Drawing.Size(134, 20);
            this.verme.TabIndex = 6;
            // 
            // txtUyeNo
            // 
            this.txtUyeNo.Location = new System.Drawing.Point(141, 61);
            this.txtUyeNo.Name = "txtUyeNo";
            this.txtUyeNo.Size = new System.Drawing.Size(100, 20);
            this.txtUyeNo.TabIndex = 5;
            // 
            // txtOdunc
            // 
            this.txtOdunc.Location = new System.Drawing.Point(141, 26);
            this.txtOdunc.Name = "txtOdunc";
            this.txtOdunc.Size = new System.Drawing.Size(100, 20);
            this.txtOdunc.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Getirilecek Tarih";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Verilen Tarih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Üye No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ödünç No";
            // 
            // btnkyt
            // 
            this.btnkyt.Location = new System.Drawing.Point(492, 207);
            this.btnkyt.Name = "btnkyt";
            this.btnkyt.Size = new System.Drawing.Size(81, 38);
            this.btnkyt.TabIndex = 2;
            this.btnkyt.Text = "kaydet";
            this.btnkyt.UseVisualStyleBackColor = true;
            this.btnkyt.Click += new System.EventHandler(this.button1_Click);
            // 
            // btngncl
            // 
            this.btngncl.Location = new System.Drawing.Point(611, 207);
            this.btngncl.Name = "btngncl";
            this.btngncl.Size = new System.Drawing.Size(86, 39);
            this.btngncl.TabIndex = 3;
            this.btngncl.Text = "güncelle";
            this.btngncl.UseVisualStyleBackColor = true;
            this.btngncl.Click += new System.EventHandler(this.btngncl_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txton);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(456, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 98);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kontrol";
            // 
            // txton
            // 
            this.txton.Location = new System.Drawing.Point(92, 46);
            this.txton.Name = "txton";
            this.txton.Size = new System.Drawing.Size(100, 20);
            this.txton.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Getirilen kitabın ödünç numarası";
            // 
            // btnkaldir
            // 
            this.btnkaldir.Location = new System.Drawing.Point(556, 382);
            this.btnkaldir.Name = "btnkaldir";
            this.btnkaldir.Size = new System.Drawing.Size(92, 33);
            this.btnkaldir.TabIndex = 2;
            this.btnkaldir.Text = "listeden kaldır";
            this.btnkaldir.UseVisualStyleBackColor = true;
            this.btnkaldir.Click += new System.EventHandler(this.btnkaldir_Click);
            // 
            // btnliste
            // 
            this.btnliste.Location = new System.Drawing.Point(147, 324);
            this.btnliste.Name = "btnliste";
            this.btnliste.Size = new System.Drawing.Size(85, 38);
            this.btnliste.TabIndex = 8;
            this.btnliste.Text = "listele";
            this.btnliste.UseVisualStyleBackColor = true;
            this.btnliste.Click += new System.EventHandler(this.btnliste_Click);
            // 
            // odunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(775, 436);
            this.Controls.Add(this.btnliste);
            this.Controls.Add(this.btnkaldir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btngncl);
            this.Controls.Add(this.btnkyt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "odunc";
            this.Text = "odunc";
            this.Load += new System.EventHandler(this.odunc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker alma;
        private System.Windows.Forms.DateTimePicker verme;
        private System.Windows.Forms.TextBox txtUyeNo;
        private System.Windows.Forms.TextBox txtOdunc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnkyt;
        private System.Windows.Forms.Button btngncl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnkaldir;
        private System.Windows.Forms.Button btnliste;
    }
}