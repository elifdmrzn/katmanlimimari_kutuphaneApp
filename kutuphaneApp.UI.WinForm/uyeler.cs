using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kutuphaneAPP.BLL;// bll den referans aldığından ekliyoruz
using kutuphaneApp.Entity;//entity den referans aldığından ekliyoruz


namespace kutuphaneApp.UI.WinForm
{
    public partial class uyeler : Form
    {
        public uyeler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UyelerBLL bll = new UyelerBLL();//bll den yeni nesne
            dataGridView1.DataSource = bll.Getir();
        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Uyeler uyeler = new Uyeler();//entityden yeni nesne
            uyeler.UyeNo = Convert.ToInt32( txtNo.Text);
            uyeler.UyeAd = txtAd.Text;
            uyeler.UyeSoyad = txtSoyad.Text;
            uyeler.UyeTel = Convert.ToInt32(txtTel.Text);
            uyeler.UyeEmail = TxtEmail.Text;
            uyeler.UyeAdres = txtAdres.Text;
            uyeler.KitapNo = Convert.ToInt32 (txtKNO.Text);

            UyelerBLL bll = new UyelerBLL();//bll den ekle metodu için yeni nesne
            bll.Ekle(uyeler);

            MessageBox.Show("Başarıyla eklnedi.");//mesaj
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Uyeler uyeler = new Uyeler();//entityden yeni nesne
            uyeler.UyeNo = Convert.ToInt32(textBox1.Text);
            UyelerBLL bll = new UyelerBLL();//bll den sil netodu için yeni nesne
            bll.Sil(uyeler);

            MessageBox.Show("Başarıyla silindi.");//mesaj

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Uyeler uyeler = new Uyeler();//entity den yeni nesne

            uyeler.UyeNo = Convert.ToInt32(txtNo.Text);
            uyeler.UyeAd = txtAd.Text;
            uyeler.UyeSoyad= txtSoyad.Text;
            uyeler.UyeTel= Convert.ToInt32(txtTel.Text);
            uyeler.UyeEmail = TxtEmail.Text;
            uyeler.UyeAdres = txtAdres.Text;
            uyeler.KitapNo= Convert.ToInt32(txtKNO.Text);


            UyelerBLL bll = new UyelerBLL();//bll den güncelleme metodu için yeni nesne


            bll.Guncelle(uyeler);//güncelleme 
            MessageBox.Show("Başarıyla güncellendi.");//mesaj
        }

         private void uyeler_Load(object sender, EventArgs e)
        {
            UyelerBLL bll = new UyelerBLL();
            dataGridView1.DataSource = bll.Getir();

        }
    }
}
