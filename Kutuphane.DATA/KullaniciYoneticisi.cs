using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.DATA
{
    public class KullaniciYoneticisi
    {
        public static readonly string path = Environment.CurrentDirectory.Replace("Kutuphane.UI\\bin\\Debug", "") + "kullaniciveri.json";
        public KullaniciYoneticisi()
        {
            Kullanicilar = new List<Kullanici>();
        }
        public List<Kullanici> Kullanicilar { get; set; }
        public void KayitOl(string adSoyad, string kullaniciAdi, string Parola)
        {
            Kullanicilar.Add(new Kullanici()
            {
                AdSoyad = adSoyad,
                KullaniciAdi = kullaniciAdi,
                Parola = Parola
            });
        }
        public Kullanici GirisYap(string kullaniciAdi, string parola)
        {
            return Kullanicilar.FirstOrDefault(x => x.KullaniciAdi == kullaniciAdi && x.Parola == parola);
        }
        public bool KullaniciVarMi(string kullaniciAdi)
        {
            return Kullanicilar.Any(x => x.KullaniciAdi == kullaniciAdi);
        }

    }
}

