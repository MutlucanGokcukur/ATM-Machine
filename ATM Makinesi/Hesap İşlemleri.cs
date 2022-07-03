using System;
using System.Windows.Forms;

namespace ATM_Makinesi
{
    public partial class Hesap_İşlemleri : Form
    {
        public Hesap_İşlemleri(Musteriler bulunankullanıcı)
        {
            InitializeComponent();
            txtBakiye.Text = Convert.ToString(bulunankullanıcı.HesapBakiye);
            txtHesapNo.Text = Convert.ToString(bulunankullanıcı.MusteriNumarası);

            txtBakiye.Enabled = false;
            txtHesapNo.Enabled = false;
        }

        private void Hesap_İşlemleri_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Musteriler BulunanMusteri = sanalDataBase.KullanıcıTablo.Find
            (i => i.MusteriNumarası == Convert.ToInt32(txtHesapNo.Text));

            if (BulunanMusteri.HesapBakiye - Convert.ToInt32(txtMiktar.Text) >= 0)
            {
                BulunanMusteri.HesapBakiye = BulunanMusteri.HesapBakiye - Convert.ToInt32(txtMiktar.Text);
                txtBakiye.Text = Convert.ToString(BulunanMusteri.HesapBakiye);
            }
            else
            {
                MessageBox.Show("Böyle Bir İşlemi Gerçekleştirmek İçin Yeterli Miktarda Paranız Bulunmamaktadır\n" +
                    "İşleminiz Gerçekleşmemiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Musteriler BulunanMusteri = sanalDataBase.KullanıcıTablo.Find
            (i => i.MusteriNumarası == Convert.ToInt32(txtHesapNo.Text));

            Musteriler GönderilecekKisi = sanalDataBase.KullanıcıTablo.Find
            (i => i.MusteriNumarası == Convert.ToInt32(txtGönderilecekHesapNo.Text));

            if (GönderilecekKisi!=null)
            {
                if (BulunanMusteri.HesapBakiye - Convert.ToInt32(txtMiktar.Text) > 0)
                {
                    BulunanMusteri.HesapBakiye = BulunanMusteri.HesapBakiye - Convert.ToInt32(txtMiktar.Text);
                    GönderilecekKisi.HesapBakiye = GönderilecekKisi.HesapBakiye + Convert.ToInt32(txtMiktar.Text);
                    txtBakiye.Text = Convert.ToString(BulunanMusteri.HesapBakiye);
                    MessageBox.Show("Gönderdiğiniz Kişi Ad Soyad: " + GönderilecekKisi.MusteriAd + " " + GönderilecekKisi.MusteriSoyad +
                    "\nGönderilen Kişinin Hesap Numarası: " + GönderilecekKisi.MusteriNumarası +
                    "\nGönderilen Miktar: " + Convert.ToInt32(txtMiktar.Text), "Bilgilendirme",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Bakiyeniz Böyle Bir İşlem İçin Yeterli Değildir","Hata",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Göndermek İstediğiniz Kişinin Hesap Numarası Bulunamadı"
                , "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ParaYatır_Click(object sender, EventArgs e)
        {
            Musteriler BulunanMusteri = sanalDataBase.KullanıcıTablo.Find
            (i => i.MusteriNumarası == Convert.ToInt32(txtHesapNo.Text));

            BulunanMusteri.HesapBakiye = Convert.ToInt32(txtMiktar.Text) + Convert.ToInt32(BulunanMusteri.HesapBakiye);
            txtBakiye.Text = Convert.ToString(BulunanMusteri.HesapBakiye);
        }

        private void ŞifreDeğiş_Click(object sender, EventArgs e)
        {
            Musteriler BulunanMusteri = sanalDataBase.KullanıcıTablo.Find
            (i => i.MusteriNumarası == Convert.ToInt32(txtHesapNo.Text));
            ŞifreDeğişme Ş1 = new ŞifreDeğişme(BulunanMusteri);
            Ş1.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkış Yapmak İstediğinizden Emin Misiniz?",
            "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Uygulama Kapatılıyor", "Bilgilendirme", MessageBoxButtons.OK);
                System.Threading.Thread.Sleep(1000);
                Application.Exit();
            }
        }
    }
}
