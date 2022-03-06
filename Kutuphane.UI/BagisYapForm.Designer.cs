namespace Kutuphane.UI
{
    partial class BagisYapForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBagisKitapAdi = new System.Windows.Forms.TextBox();
            this.cboBagisTur = new System.Windows.Forms.ComboBox();
            this.txtBagisYazarAdi = new System.Windows.Forms.TextBox();
            this.nudBagisSayfaSayisi = new System.Windows.Forms.NumericUpDown();
            this.txtBagisAciklama = new System.Windows.Forms.TextBox();
            this.btnBagisYap = new System.Windows.Forms.Button();
            this.dtpBagisBasimTarihi = new System.Windows.Forms.DateTimePicker();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBagisSayfaSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kutuphane.UI.Properties.Resources.kitap_bagis;
            this.pictureBox1.Location = new System.Drawing.Point(83, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Basım Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tür:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Yazar Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sayfa Sayısı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 442);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Adet:";
            // 
            // txtBagisKitapAdi
            // 
            this.txtBagisKitapAdi.Location = new System.Drawing.Point(147, 258);
            this.txtBagisKitapAdi.Multiline = true;
            this.txtBagisKitapAdi.Name = "txtBagisKitapAdi";
            this.txtBagisKitapAdi.Size = new System.Drawing.Size(241, 32);
            this.txtBagisKitapAdi.TabIndex = 7;
            // 
            // cboBagisTur
            // 
            this.cboBagisTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBagisTur.FormattingEnabled = true;
            this.cboBagisTur.Location = new System.Drawing.Point(147, 331);
            this.cboBagisTur.Name = "cboBagisTur";
            this.cboBagisTur.Size = new System.Drawing.Size(241, 32);
            this.cboBagisTur.TabIndex = 9;
            // 
            // txtBagisYazarAdi
            // 
            this.txtBagisYazarAdi.Location = new System.Drawing.Point(147, 369);
            this.txtBagisYazarAdi.Multiline = true;
            this.txtBagisYazarAdi.Name = "txtBagisYazarAdi";
            this.txtBagisYazarAdi.Size = new System.Drawing.Size(241, 32);
            this.txtBagisYazarAdi.TabIndex = 10;
            // 
            // nudBagisSayfaSayisi
            // 
            this.nudBagisSayfaSayisi.Location = new System.Drawing.Point(147, 407);
            this.nudBagisSayfaSayisi.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudBagisSayfaSayisi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBagisSayfaSayisi.Name = "nudBagisSayfaSayisi";
            this.nudBagisSayfaSayisi.Size = new System.Drawing.Size(241, 29);
            this.nudBagisSayfaSayisi.TabIndex = 11;
            this.nudBagisSayfaSayisi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtBagisAciklama
            // 
            this.txtBagisAciklama.Location = new System.Drawing.Point(147, 475);
            this.txtBagisAciklama.Multiline = true;
            this.txtBagisAciklama.Name = "txtBagisAciklama";
            this.txtBagisAciklama.Size = new System.Drawing.Size(241, 130);
            this.txtBagisAciklama.TabIndex = 12;
            // 
            // btnBagisYap
            // 
            this.btnBagisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBagisYap.Location = new System.Drawing.Point(259, 611);
            this.btnBagisYap.Name = "btnBagisYap";
            this.btnBagisYap.Size = new System.Drawing.Size(129, 35);
            this.btnBagisYap.TabIndex = 13;
            this.btnBagisYap.Text = "Bağış Yap";
            this.btnBagisYap.UseVisualStyleBackColor = true;
            this.btnBagisYap.Click += new System.EventHandler(this.btnBagisYap_Click);
            // 
            // dtpBagisBasimTarihi
            // 
            this.dtpBagisBasimTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpBagisBasimTarihi.Location = new System.Drawing.Point(147, 296);
            this.dtpBagisBasimTarihi.Name = "dtpBagisBasimTarihi";
            this.dtpBagisBasimTarihi.Size = new System.Drawing.Size(241, 26);
            this.dtpBagisBasimTarihi.TabIndex = 14;
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(147, 440);
            this.nudAdet.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(241, 29);
            this.nudAdet.TabIndex = 15;
            this.nudAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 475);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Açıklama:";
            // 
            // BagisYapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(411, 667);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.dtpBagisBasimTarihi);
            this.Controls.Add(this.btnBagisYap);
            this.Controls.Add(this.txtBagisAciklama);
            this.Controls.Add(this.nudBagisSayfaSayisi);
            this.Controls.Add(this.txtBagisYazarAdi);
            this.Controls.Add(this.cboBagisTur);
            this.Controls.Add(this.txtBagisKitapAdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(427, 706);
            this.MinimumSize = new System.Drawing.Size(427, 706);
            this.Name = "BagisYapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bağış Yap";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBagisSayfaSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBagisKitapAdi;
        private System.Windows.Forms.ComboBox cboBagisTur;
        private System.Windows.Forms.TextBox txtBagisYazarAdi;
        private System.Windows.Forms.NumericUpDown nudBagisSayfaSayisi;
        private System.Windows.Forms.TextBox txtBagisAciklama;
        private System.Windows.Forms.Button btnBagisYap;
        private System.Windows.Forms.DateTimePicker dtpBagisBasimTarihi;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.Label label7;
    }
}