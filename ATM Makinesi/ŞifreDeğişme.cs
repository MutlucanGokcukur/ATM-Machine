using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATM_Makinesi
{
    public partial class ŞifreDeğişme : Form
    {
        public ŞifreDeğişme(Musteriler bulunankullanıcı)
        {
            InitializeComponent();
            txtHesapNumarası.Text =Convert.ToString(bulunankullanıcı.MusteriNumarası);
            txtHesapNumarası.Enabled = false;
            txtYeniSifre.Enabled = false;
        }

        private void ŞifreDeğişme_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Musteriler BulunanMusteri = sanalDataBase.KullanıcıTablo.Find
            (i => i.MusteriNumarası == Convert.ToInt32(txtHesapNumarası.Text));

            if (txtSifre.Text==BulunanMusteri.Sifre)
            {
                txtYeniSifre.Enabled = true;
            }
            else
            {
                DialogResult result= MessageBox.Show("Şifrenizi Hatalı Girdiniz\nLütfen Tekrar Giriş Yapınız","Hata",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);

                if (result==DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Musteriler BulunanMusteri = sanalDataBase.KullanıcıTablo.Find
            (i => i.MusteriNumarası == Convert.ToInt32(txtHesapNumarası.Text));
            if (BulunanMusteri.Sifre == txtYeniSifre.Text)
            {
                MessageBox.Show("Eski Şifre İle Yeni Şifre Aynı Olmamalıdır.", "Bilgilendirme",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                BulunanMusteri.Sifre = txtYeniSifre.Text;
                MessageBox.Show("Uygulama Kapatılıyor...", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Threading.Thread.Sleep(1000);
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
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
