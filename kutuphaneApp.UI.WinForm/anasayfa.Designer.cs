namespace kutuphaneApp.UI.WinForm
{
    partial class anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anasayfa));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnUye = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(527, 144);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(238, 202);
            this.button3.TabIndex = 7;
            this.button3.Text = "ÖDÜNÇ TAKİP SİSTEMİ";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(291, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 202);
            this.button2.TabIndex = 6;
            this.button2.Text = "KİTAP İŞLEMLERİ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUye
            // 
            this.btnUye.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUye.BackgroundImage")));
            this.btnUye.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUye.Location = new System.Drawing.Point(45, 144);
            this.btnUye.Name = "btnUye";
            this.btnUye.Size = new System.Drawing.Size(223, 202);
            this.btnUye.TabIndex = 5;
            this.btnUye.Text = "ÜYE TAKİBİ";
            this.btnUye.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnUye.UseVisualStyleBackColor = true;
            this.btnUye.Click += new System.EventHandler(this.btnUye_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(15, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(801, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "ZEYTİNBURNU HALK KÜTÜPHANESİ PROGRAMI";
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(833, 428);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnUye);
            this.Controls.Add(this.label1);
            this.Name = "anasayfa";
            this.Text = "anasayfa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnUye;
        private System.Windows.Forms.Label label1;
    }
}