using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_Makinesi
{
    public class sanalDataBase
    {
        public static List<Musteriler> KullanıcıTablo = new List<Musteriler>();

        static sanalDataBase()
        {
            KullanıcıTablo.Add(new Musteriler()
            {
                MusteriAd="Mutlucan",
                MusteriSoyad="Gökçukur",
                MusteriNumarası=1,
                MusteriYas=20,
                Sifre="1234",
                HesapBakiye=9000,
                Hesapİli="İstanbul",
            }
            );
            KullanıcıTablo.Add(new Musteriler()
            {
                MusteriAd = "Mahmut",
                MusteriSoyad = "Satici",
                MusteriNumarası = 2,
                MusteriYas = 19,
                Sifre = "5678",
                HesapBakiye = 1000,
                Hesapİli = "Kocaeli",
            }
            );
            KullanıcıTablo.Add(new Musteriler()
            {
                MusteriAd = "Muhammet Arda",
                MusteriSoyad = "Ünsalan",
                MusteriNumarası = 3,
                MusteriYas = 20,
                Sifre = "0000",
                HesapBakiye = 10000,
                Hesapİli = "Sakarya",
            }
            );
            KullanıcıTablo.Add(new Musteriler()
            {
                MusteriAd = "Yusuf Üzeyir",
                MusteriSoyad = "Kaya",
                MusteriNumarası = 4,
                MusteriYas = 20,
                Sifre = "2002",
                HesapBakiye = 5000,
                Hesapİli = "İstanbul",
            }
            );
        }
    }
}
