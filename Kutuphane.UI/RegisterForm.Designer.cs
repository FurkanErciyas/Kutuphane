namespace Kutuphane.UI
{
    partial class RegisterForm
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
            this.txtKayitAdSoyad = new System.Windows.Forms.TextBox();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.chkKullaniciAdi = new System.Windows.Forms.CheckBox();
            this.chkParola = new System.Windows.Forms.CheckBox();
            this.txtKayitParolaTekrar = new System.Windows.Forms.TextBox();
            this.txtKayitParola = new System.Windows.Forms.TextBox();
            this.txtKayitKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(79, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // txtKayitAdSoyad
            // 
            this.txtKayitAdSoyad.Location = new System.Drawing.Point(225, 235);
            this.txtKayitAdSoyad.Name = "txtKayitAdSoyad";
            this.txtKayitAdSoyad.Size = new System.Drawing.Size(201, 29);
            this.txtKayitAdSoyad.TabIndex = 1;
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.Location = new System.Drawing.Point(301, 373);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(125, 35);
            this.btnKayitOl.TabIndex = 8;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = true;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // chkKullaniciAdi
            // 
            this.chkKullaniciAdi.AutoSize = true;
            this.chkKullaniciAdi.BackColor = System.Drawing.Color.White;
            this.chkKullaniciAdi.Enabled = false;
            this.chkKullaniciAdi.Location = new System.Drawing.Point(83, 435);
            this.chkKullaniciAdi.Name = "chkKullaniciAdi";
            this.chkKullaniciAdi.Size = new System.Drawing.Size(132, 28);
            this.chkKullaniciAdi.TabIndex = 9;
            this.chkKullaniciAdi.Text = "Kullanıcı Adı";
            this.chkKullaniciAdi.UseVisualStyleBackColor = false;
            // 
            // chkParola
            // 
            this.chkParola.AutoSize = true;
            this.chkParola.Enabled = false;
            this.chkParola.Location = new System.Drawing.Point(225, 435);
            this.chkParola.Name = "chkParola";
            this.chkParola.Size = new System.Drawing.Size(82, 28);
            this.chkParola.TabIndex = 10;
            this.chkParola.Text = "Parola";
            this.chkParola.UseVisualStyleBackColor = true;
            // 
            // txtKayitParolaTekrar
            // 
            this.txtKayitParolaTekrar.Location = new System.Drawing.Point(225, 338);
            this.txtKayitParolaTekrar.Name = "txtKayitParolaTekrar";
            this.txtKayitParolaTekrar.Size = new System.Drawing.Size(201, 29);
            this.txtKayitParolaTekrar.TabIndex = 7;
            this.txtKayitParolaTekrar.TextChanged += new System.EventHandler(this.txtKayitParola_TextChanged);
            // 
            // txtKayitParola
            // 
            this.txtKayitParola.Location = new System.Drawing.Point(225, 305);
            this.txtKayitParola.Name = "txtKayitParola";
            this.txtKayitParola.Size = new System.Drawing.Size(201, 29);
            this.txtKayitParola.TabIndex = 5;
            this.txtKayitParola.TextChanged += new System.EventHandler(this.txtKayitParola_TextChanged);
            // 
            // txtKayitKullaniciAdi
            // 
            this.txtKayitKullaniciAdi.Location = new System.Drawing.Point(225, 270);
            this.txtKayitKullaniciAdi.Name = "txtKayitKullaniciAdi";
            this.txtKayitKullaniciAdi.Size = new System.Drawing.Size(201, 29);
            this.txtKayitKullaniciAdi.TabIndex = 3;
            this.txtKayitKullaniciAdi.TextChanged += new System.EventHandler(this.txtKayitKullaniciAdi_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parola:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Parola Tekrar:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Kutuphane.UI.Properties.Resources.register;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(492, 475);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(492, 475);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKayitKullaniciAdi);
            this.Controls.Add(this.txtKayitParola);
            this.Controls.Add(this.txtKayitParolaTekrar);
            this.Controls.Add(this.chkParola);
            this.Controls.Add(this.chkKullaniciAdi);
            this.Controls.Add(this.btnKayitOl);
            this.Controls.Add(this.txtKayitAdSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kayıt Ol";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKayitAdSoyad;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.CheckBox chkKullaniciAdi;
        private System.Windows.Forms.CheckBox chkParola;
        private System.Windows.Forms.TextBox txtKayitParolaTekrar;
        private System.Windows.Forms.TextBox txtKayitParola;
        private System.Windows.Forms.TextBox txtKayitKullaniciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}