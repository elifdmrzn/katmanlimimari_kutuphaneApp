using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneApp.UI.WinForm
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void btnUye_Click(object sender, EventArgs e)
        {
            uyeler uye = new uyeler(); //uyelerden nesne oluşturduk
            uye.Show();//uyeler sayfasını göster
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kitaplar kit = new kitaplar();//kitaplardan nesne oluşturduk
            kit.Show();//kitaplar sayfasını göster
        }

        private void button3_Click(object sender, EventArgs e)
        {
            odunc o = new odunc();//oduncden nesne oluşturduk
            o.Show();//odunc sayfasını göster
        }
    }
}
