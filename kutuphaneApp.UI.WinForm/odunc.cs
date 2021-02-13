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
using kutuphaneApp.Entity;//entityden referans aldığı için ekliyoruz

namespace kutuphaneApp.UI.WinForm
{
    public partial class odunc : Form
    {
        public odunc()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Odunc o = new Odunc();
            o.OduncNo= Convert.ToInt32(txtOdunc.Text);
            o.UyeNo= Convert.ToInt32(txtUyeNo.Text);
            o.OduncAlmaTarihi = Convert.ToDateTime(verme.Text);
            o.GeriGetirmeTarihi = Convert.ToDateTime(alma.Text);

            oduncBLL bll = new oduncBLL();//ekleme metodu için bll den nesne oluşturuldu
            bll.Ekle(o);
            MessageBox.Show("Başarıyla kaydedildi.");
        }

        private void btnliste_Click(object sender, EventArgs e)
        {
            oduncBLL bll = new oduncBLL();// listeleme için bll den nesne oluşturduk
            dataGridView1.DataSource = bll.Getir();

        }

        private void btngncl_Click(object sender, EventArgs e)
        {
            Odunc o = new Odunc();
            o.OduncNo = Convert.ToInt32(txtOdunc.Text);
            o.UyeNo = Convert.ToInt32(txtUyeNo.Text);
            o.OduncAlmaTarihi = Convert.ToDateTime(verme.Text);
            o.GeriGetirmeTarihi = Convert.ToDateTime(alma.Text);

            oduncBLL bll = new oduncBLL();//güncelle metodu için bll den nesne oluşturuldu
            bll.Guncelle(o);
            MessageBox.Show("Başarıyla güncellendi.");
        }

        private void btnkaldir_Click(object sender, EventArgs e)
        {
            Odunc o = new Odunc();
            o.OduncNo = Convert.ToInt32(txton.Text);
            oduncBLL bll = new oduncBLL();//silme metodu için bll den nesne oluşturuldu
            bll.Sil(o);
            MessageBox.Show("Başarıyla silindi.");

        }

        private void odunc_Load(object sender, EventArgs e)
        {
            oduncBLL bll = new oduncBLL();
            dataGridView1.DataSource = bll.Getir();
        }
    }
}
