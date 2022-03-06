using Kutuphane.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane.UI
{
    public partial class HesabimForm : Form
    {
        private readonly Kullanici kullanici;
        private readonly KutuphaneYoneticisi kutuphaneYoneticisi;

        public HesabimForm(Kullanici kullanici, KutuphaneYoneticisi kutuphaneYoneticisi)
        {
            InitializeComponent();
            this.kullanici = kullanici;
            this.kutuphaneYoneticisi = kutuphaneYoneticisi;
            KullaniciBilgileriGoster();
            Listele();
        }

        private void Listele()
        {
            dgvOduncAlinanKitaplar.DataSource = null;
            dgvOduncAlinanKitaplar.DataSource = kullanici.OduncAlinanKitaplar != null ? kullanici.OduncAlinanKitaplar : null;
            dgvOduncAlinanKitaplar.Columns[0].Visible = false;
            dgvOduncAlinanKitaplar.Columns[1].HeaderText = "Kitap Adı";
            dgvOduncAlinanKitaplar.Columns[2].Visible = false;
            dgvOduncAlinanKitaplar.Columns[3].HeaderText = "Kitap Türü";
            dgvOduncAlinanKitaplar.Columns[4].Visible = false;
            dgvOduncAlinanKitaplar.Columns[5].Visible = false;
            dgvOduncAlinanKitaplar.Columns[6].Visible = false;
            dgvOduncAlinanKitaplar.Columns[7].HeaderText = "Ödünç Alınma Tarihi";
        }

        private void KullaniciBilgileriGoster()
        {
            txtHesabimId.Text = $"{kullanici.Id}";
            txtHesabimKullaniciAdi.Text = $"{kullanici.KullaniciAdi}";
            txtHesabimAdSoyad.Text = $"{kullanici.AdSoyad}";
            txtHesabimParola.Text = $"{kullanici.Parola}";
        }

        private void btnTeslimEt_Click(object sender, EventArgs e)
        {
            if (dgvOduncAlinanKitaplar.SelectedRows.Count > 0)
            {
                Guid kitapId = ((Kitap)dgvOduncAlinanKitaplar.SelectedRows[0].DataBoundItem).Id;
                kutuphaneYoneticisi.KitapTeslimEt(kullanici, kitapId);
                Listele();
            }
        }

        private void dgvOduncAlinanKitaplar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOduncAlinanKitaplar.SelectedRows.Count > 0)
            {
                Kitap kitap = ((Kitap)dgvOduncAlinanKitaplar.SelectedRows[0].DataBoundItem);
                dtpSonTeslimTarihi.Value = ((DateTime)kitap.OduncAlinmaTarihi).AddDays(14);
            }
        }
    }
}

                
