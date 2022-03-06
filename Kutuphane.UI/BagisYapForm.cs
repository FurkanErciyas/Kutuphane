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
    public partial class BagisYapForm : Form
    {
        private readonly KutuphaneYoneticisi kutuphaneYoneticisi;

        public BagisYapForm(KutuphaneYoneticisi kutuphaneYoneticisi)
        {
            InitializeComponent();
            this.kutuphaneYoneticisi = kutuphaneYoneticisi;
            KitapTuruEkle();
        }

        private void KitapTuruEkle()
        {
            cboBagisTur.DataSource = Enum.GetValues(typeof(KitapTurEnum));
        }

        private void btnBagisYap_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtBagisKitapAdi.Text) && !string.IsNullOrEmpty(txtBagisYazarAdi.Text))
            {
                kutuphaneYoneticisi.KitapBagisYap(
                    txtBagisKitapAdi.Text,
                    dtpBagisBasimTarihi.Value,
                    (KitapTurEnum)cboBagisTur.SelectedItem,
                    txtBagisYazarAdi.Text,
                    (int)nudBagisSayfaSayisi.Value,
                    txtBagisAciklama.Text,
                    (int)nudAdet.Value);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Kitap Adı ve Yazar Adı Zorunludur..!");
            }
        }
    }
}
