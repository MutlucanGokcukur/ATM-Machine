using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int girishhakkı = 3;
        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtSifre_Enter(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.DarkRed;
        }

        private void txtSifre_Leave(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sifree = txtSifre.Text;
                Musteriler BulunanMusteri = sanalDataBase.KullanıcıTablo.Find
                (i => i.Sifre == sifree);
                if (BulunanMusteri != null)
                {
                    Hesap H1 = new Hesap(BulunanMusteri);
                    H1.Show();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Hatalı Şifre Girdiniz\nLütfen Tekrar Deneyiniz...", "HATA", MessageBoxButtons.OKCancel
                    , MessageBoxIcon.Information);
                    girishhakkı--;

                    if (result == DialogResult.Cancel)
                    {
                        Application.Exit();
                    }
                    if (girishhakkı == 0)
                    {
                        MessageBox.Show("Çok fazla hatalı şifre girildi\nSistem Kapatılıyor", "HATA",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Application.Exit();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Şifre Sadece Rakamlardan Oluşmalıdır", "Hata", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
