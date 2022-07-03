using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATM_Makinesi
{
    public partial class Hesap : Form
    {
        public Hesap(Musteriler bulunanMusteri)
        {
            InitializeComponent();
            txtİsim.Text = bulunanMusteri.MusteriAd;
            txtHesapNo.Text = Convert.ToString(bulunanMusteri.MusteriNumarası);
            txtSoyisim.Text = bulunanMusteri.MusteriSoyad;
            txtYaş.Text = Convert.ToString(bulunanMusteri.MusteriYas);
            txtİl.Text = bulunanMusteri.Hesapİli;

            txtİsim.Enabled = false;
            txtSoyisim.Enabled = false;
            txtYaş.Enabled = false;
            txtHesapNo.Enabled = false;
            txtİl.Enabled = false;


            int bakiye = bulunanMusteri.HesapBakiye;
        }
        
        private void Hesap_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Musteriler BulunanMusteri = sanalDataBase.KullanıcıTablo.Find
                (i => i.MusteriNumarası == Convert.ToInt32(txtHesapNo.Text));
            
            MessageBox.Show("Hesabınızdaki Toplam Bakiye: "+Convert.ToString(BulunanMusteri.HesapBakiye),
                "Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkış Yapmak İstediğinizden Emin Misiniz?",
            "Bilgilendirme",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result==DialogResult.Yes)
            {
                MessageBox.Show("Uygulama Kapatılıyor","Bilgilendirme",MessageBoxButtons.OK);
                System.Threading.Thread.Sleep(1000);
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Musteriler BulunanMusteri = sanalDataBase.KullanıcıTablo.Find
                (i => i.MusteriNumarası == Convert.ToInt32(txtHesapNo.Text));
            Hesap_İşlemleri hi1 = new Hesap_İşlemleri(BulunanMusteri);
            hi1.Show();
        }
    }
}
