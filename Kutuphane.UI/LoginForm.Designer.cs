namespace Kutuphane.UI
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.lnkKayitOl = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parola:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(165, 256);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(177, 29);
            this.txtKullaniciAdi.TabIndex = 3;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(165, 291);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(177, 29);
            this.txtParola.TabIndex = 4;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(232, 326);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(110, 35);
            this.btnGirisYap.TabIndex = 5;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // lnkKayitOl
            // 
            this.lnkKayitOl.AutoSize = true;
            this.lnkKayitOl.Location = new System.Drawing.Point(35, 337);
            this.lnkKayitOl.Name = "lnkKayitOl";
            this.lnkKayitOl.Size = new System.Drawing.Size(73, 24);
            this.lnkKayitOl.TabIndex = 6;
            this.lnkKayitOl.TabStop = true;
            this.lnkKayitOl.Text = "Kayıt Ol";
            this.lnkKayitOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkKayitOl_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kutuphane.UI.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(95, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(384, 380);
            this.Controls.Add(this.lnkKayitOl);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Yap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.LinkLabel lnkKayitOl;
    }
}