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
    public partial class LoginForm : Form
    {
        KullaniciYoneticisi kullaniciYoneticisi;
        public LoginForm()
        {
            InitializeComponent();
            txtKullaniciAdi.Text = "admin";
            txtParola.Text = "admin";
        }
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string json = JsonConvert.SerializeObject(kullaniciYoneticisi);
            File.WriteAllText(KullaniciYoneticisi.path, json);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                string json = File.ReadAllText(KullaniciYoneticisi.path);
                kullaniciYoneticisi = JsonConvert.DeserializeObject<KullaniciYoneticisi>(json);
            }
            catch (Exception)
            {
                kullaniciYoneticisi = new KullaniciYoneticisi();
            }
        }

        private void lnkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(kullaniciYoneticisi);
            this.Hide();
            registerForm.ShowDialog();
            this.Show();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtKullaniciAdi.Text) && !string.IsNullOrEmpty(txtParola.Text))
            {
                Kullanici girisYapanKullanici = kullaniciYoneticisi.GirisYap(txtKullaniciAdi.Text, txtParola.Text);
                if(girisYapanKullanici != null)
                {
                    KutuphaneForm kutuphaneForm = new KutuphaneForm(girisYapanKullanici);
                    this.Hide();
                    kutuphaneForm.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı veya Hatalı Parola... ");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Kullanıcı Adı ve Parolanızı Giriniz..!");
            }
        }
    }
}

               