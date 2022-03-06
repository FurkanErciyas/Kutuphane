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
    public partial class RegisterForm : Form
    {
        private readonly KullaniciYoneticisi kullaniciYoneticisi;
        public RegisterForm(KullaniciYoneticisi kullaniciYoneticisi)
        {
            InitializeComponent();
            this.kullaniciYoneticisi = kullaniciYoneticisi;
        }

        private void txtKayitKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            if (!kullaniciYoneticisi.KullaniciVarMi(txtKayitKullaniciAdi.Text) && !string.IsNullOrEmpty(txtKayitKullaniciAdi.Text)) 
            {
                chkKullaniciAdi.Checked = true;
                chkKullaniciAdi.BackColor = Color.LimeGreen;
            }
            else 
            {
                chkKullaniciAdi.Checked = false;
                chkKullaniciAdi.BackColor = Color.Red;
            }
        }


        private void txtKayitParola_TextChanged(object sender, EventArgs e)
        {
            if(txtKayitParola.Text != txtKayitParolaTekrar.Text || string.IsNullOrEmpty(txtKayitParola.Text) || string.IsNullOrEmpty(txtKayitParolaTekrar.Text))
            {
                chkParola.Checked = false;
                chkParola.BackColor = Color.Red;
            }
            else
            {
                chkParola.Checked= true;
                chkParola.BackColor = Color.LimeGreen;
            }
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKayitAdSoyad.Text) || !chkKullaniciAdi.Checked || !chkParola.Checked )
            {
                MessageBox.Show("Eksik ya da Yanlış Bilgi Girdiniz..!");
            }
            else
            {
                kullaniciYoneticisi.KayitOl(txtKayitAdSoyad.Text, txtKayitKullaniciAdi.Text, txtKayitParola.Text);
                this.Close();
            }
        }
    }
}
