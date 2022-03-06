using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.DATA
{
    public class KutuphaneYoneticisi
    {
        public static readonly string path = Environment.CurrentDirectory.Replace("Kutuphane.UI\\bin\\Debug", "") + "kutuphaneveri.json";
        public KutuphaneYoneticisi()
        {
            Kitaplar = new List<Kitap>();
        }
        public List<Kitap> Kitaplar { get; set; }
        public void KitapBagisYap(string ad, DateTime basimTarihi, KitapTurEnum kitapTur, string yazarAd, int sayfaSayisi, string aciklama, int adet)
        {
            for (int i = 1; i <= adet; i++)
            {
                Kitaplar.Add(new Kitap()
                {
                    Ad = ad,
                    BasimTarihi = basimTarihi,
                    KitapTuru = kitapTur,
                    YazarAd = yazarAd,
                    SayfaSayisi = sayfaSayisi,
                    Aciklama = aciklama
                });
            }
        }

        public void KitapImhaEt(Guid kitapId)
        {
            Kitap imhaEdilecekKitap = Kitaplar.FirstOrDefault(x => x.Id == kitapId);
            Kitaplar.Remove(imhaEdilecekKitap);
        }
        public void KitapOduncAl(Kullanici kullanici, Guid kitapId)
        {
            Kitap kitap = Kitaplar.FirstOrDefault(x => x.Id == kitapId);
            kitap.OduncAlinmaTarihi = DateTime.Now;
            kullanici.OduncAlinanKitaplar.Add(kitap);
        }
        public void KitapTeslimEt(Kullanici kullanici, Guid kitapId)
        {
            Kitap kitap = Kitaplar.FirstOrDefault(x => x.Id == kitapId);
            kitap.OduncAlinmaTarihi = null;
            kullanici.OduncAlinanKitaplar.Remove(kitap);
        }
    }
}
