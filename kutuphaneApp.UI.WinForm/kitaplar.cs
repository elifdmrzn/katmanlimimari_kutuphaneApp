using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kutuphaneAPP.BLL;//bll den referans aldığı için ekliyoruz
using kutuphaneApp.Entity;//entity den referans aldığı için ekliyoruz

namespace kutuphaneApp.UI.WinForm
{
    public partial class kitaplar : Form
    {
        public kitaplar()
        {
            InitializeComponent();
        }

      

        private void kaydet_Click(object sender, EventArgs e)
        {
            kitaplarBLL bll = new kitaplarBLL();// listeleme için bll den nesne oluşturduk
            dataGridView1.DataSource = bll.Getir();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            kitaplarr kitap = new kitaplarr();//entity den nesne
            kitap.KitapNo = Convert.ToInt32(txtNo.Text);
            kitap.KitapAd = txtAd.Text;
            kitap.KitapYazari = txtYazar.Text;
            kitap.KitapBaskiYil = Convert.ToInt32(txtYil.Text);
            kitap.KitapSayfaSayi = Convert.ToInt32(txtSayi.Text);
            kitap.KitapYayinEvi = txtYayin.Text;

            kitaplarBLL bll = new kitaplarBLL();//ekleme metodu için bll den nesne oluşturuldu
            bll.Ekle(kitap);
            MessageBox.Show("Başarıyla eklendi.");

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            kitaplarr kitap = new kitaplarr();
            kitap.KitapNo = Convert.ToInt32(txtNo.Text);
            kitap.KitapAd = txtAd.Text;
            kitap.KitapYazari = txtYazar.Text;
            kitap.KitapBaskiYil = Convert.ToInt32(txtYil.Text);
            kitap.KitapSayfaSayi = Convert.ToInt32(txtSayi.Text);
            kitap.KitapYayinEvi = txtYayin.Text;

            kitaplarBLL bll = new kitaplarBLL();//güncelleme metodu için bll den nesne oluşturuldu
            bll.Guncelle(kitap);
            MessageBox.Show("Başarıyla güncellendi.");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            kitaplarr kitap = new kitaplarr();
            kitap.KitapNo = Convert.ToInt32(txtKno.Text);
            kitaplarBLL bll = new kitaplarBLL();
            bll.Sil(kitap);
            MessageBox.Show("Başarıyla silindi.");//silme metodu için bll den nesne oluşturuldu
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void kitaplar_Load(object sender, EventArgs e)
        {
            kitaplarBLL bll = new kitaplarBLL();
            dataGridView1.DataSource = bll.Getir();
        }
    }
}
