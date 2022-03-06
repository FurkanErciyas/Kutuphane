using Kutuphane.DATA;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane.UI
{
    public partial class KutuphaneForm : Form
    {
        private readonly Kullanici girisYapan;
        KutuphaneYoneticisi kutuphaneYoneticisi;
        public KutuphaneForm(Kullanici girisYapan)
        {
            InitializeComponent();
            this.girisYapan = girisYapan;
        }

        private void tsmiHesabim_Click(object sender, EventArgs e)
        {
            HesabimForm hesabimForm = new HesabimForm(girisYapan, kutuphaneYoneticisi);
            this.Hide();
            hesabimForm.ShowDialog();
            this.Show();
        }

        private void tsmiBagisYap_Click(object sender, EventArgs e)
        {
            BagisYapForm bagisYapForm = new BagisYapForm(kutuphaneYoneticisi);
            this.Hide();
            bagisYapForm.ShowDialog();
            Listele();
            this.Show();
        }

        private void tsmiCikisYap_Click(object sender, EventArgs e)
        {
            VerileriKaydet();
            Close();
        }


        private void tsmiKitapOduncAl_Click(object sender, EventArgs e)
        {

            if(((Kitap)dgvKitaplar.SelectedRows[0].DataBoundItem).OduncAlinmaTarihi != null)
            {
                MessageBox.Show(this, "Kitap Kullanımda..!", "Bilgilendirme");
                return;
            }
            Guid kitapId = ((Kitap)dgvKitaplar.SelectedRows[0].DataBoundItem).Id;
            kutuphaneYoneticisi.KitapOduncAl(girisYapan, kitapId);
            Listele();
        }

        private void tsmiKitapImhaEt_Click(object sender, EventArgs e)
        {
            Guid imhaEdilecekKitapId = ((Kitap)dgvKitaplar.SelectedRows[0].DataBoundItem).Id;
            string kitapAd = ((Kitap)dgvKitaplar.SelectedRows[0].DataBoundItem).Ad;
            DialogResult dr = MessageBox.Show(this, $"{kitapAd} silinecek. Onaylıyor musunuz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                kutuphaneYoneticisi.KitapImhaEt(imhaEdilecekKitapId);
                Listele();
            }
        }

        private void KutuphaneForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            VerileriKaydet();
        }

        private void KutuphaneForm_Load(object sender, EventArgs e)
        {
            try
            {
                VerileriOku();
            }
            catch (Exception)
            {
                kutuphaneYoneticisi = new KutuphaneYoneticisi();
            }
            TurleriYukle();
            Listele();
        }

        private void Listele()
        {
            dgvKitaplar.DataSource = null;
            if (!string.IsNullOrEmpty(txtArama.Text) && cboTurler.SelectedIndex != 0)
            {
                dgvKitaplar.DataSource = kutuphaneYoneticisi.Kitaplar
                    .Where(x => x.Ad.ToLower().Contains(txtArama.Text.ToLower()) && x.KitapTuru == (KitapTurEnum)cboTurler.SelectedItem).ToList();
            }
            else if (!string.IsNullOrEmpty(txtArama.Text) && cboTurler.SelectedIndex == 0)
            {
                dgvKitaplar.DataSource = kutuphaneYoneticisi.Kitaplar.Where(x => x.Ad.ToLower().Contains(txtArama.Text.ToLower())).ToList();
            }
            else if (cboTurler.SelectedIndex != 0)
            {
                dgvKitaplar.DataSource = kutuphaneYoneticisi.Kitaplar.Where(x => x.KitapTuru == (KitapTurEnum)cboTurler.SelectedItem).ToList();
            }
            else
            {
                dgvKitaplar.DataSource = kutuphaneYoneticisi.Kitaplar.ToList();
            }
            dgvKitaplar.Columns[0].Visible = false;
            dgvKitaplar.Columns[1].HeaderText = "Kitap Adı";
            dgvKitaplar.Columns[2].HeaderText = "Basım Tarihi";
            dgvKitaplar.Columns[3].HeaderText = "Kitap Türü";
            dgvKitaplar.Columns[4].HeaderText = "Yazar Ad";
            dgvKitaplar.Columns[5].HeaderText = "Sayfa Sayısı";
            dgvKitaplar.Columns[6].HeaderText = "Açıklama";
            dgvKitaplar.Columns[7].Visible = true;
        }

        private void TurleriYukle()
        {
            cboTurler.Items.Add("Hepsi");
            cboTurler.Items.AddRange(Enum.GetValues(typeof(KitapTurEnum)).Cast<object>().ToArray());
            cboTurler.SelectedIndex = 0;
        }

        private void VerileriKaydet()
        {
            string json = JsonConvert.SerializeObject(kutuphaneYoneticisi);
            File.WriteAllText(KutuphaneYoneticisi.path, json);
        }

        private void VerileriOku()
        {
            string json = File.ReadAllText(KutuphaneYoneticisi.path);
            kutuphaneYoneticisi = JsonConvert.DeserializeObject<KutuphaneYoneticisi>(json);
        }

        private void cboTurler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listele();
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            Listele();
        }

        private void dgvKitaplar_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                int position = dgvKitaplar.HitTest(e.X, e.Y).RowIndex;
                if(position >= 0)
                {
                    if(girisYapan.KullaniciAdi != "admin")
                    {
                        contextMenuStrip1.Items[1].Visible = false;
                    }
                    contextMenuStrip1.Show(dgvKitaplar, new Point(e.X, e.Y));
                    dgvKitaplar.Rows[position].Selected = true;
                }
            }
        }
    }
}
