namespace Kutuphane.UI
{
    partial class HesabimForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHesabimAdSoyad = new System.Windows.Forms.TextBox();
            this.txtHesabimParola = new System.Windows.Forms.TextBox();
            this.txtHesabimKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtHesabimId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTeslimEt = new System.Windows.Forms.Button();
            this.dtpSonTeslimTarihi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvOduncAlinanKitaplar = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOduncAlinanKitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.txtHesabimAdSoyad);
            this.groupBox1.Controls.Add(this.txtHesabimParola);
            this.groupBox1.Controls.Add(this.txtHesabimKullaniciAdi);
            this.groupBox1.Controls.Add(this.txtHesabimId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Bilgileri";
            // 
            // txtHesabimAdSoyad
            // 
            this.txtHesabimAdSoyad.BackColor = System.Drawing.Color.LightGray;
            this.txtHesabimAdSoyad.Enabled = false;
            this.txtHesabimAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHesabimAdSoyad.Location = new System.Drawing.Point(107, 91);
            this.txtHesabimAdSoyad.Name = "txtHesabimAdSoyad";
            this.txtHesabimAdSoyad.ReadOnly = true;
            this.txtHesabimAdSoyad.Size = new System.Drawing.Size(328, 26);
            this.txtHesabimAdSoyad.TabIndex = 6;
            // 
            // txtHesabimParola
            // 
            this.txtHesabimParola.BackColor = System.Drawing.Color.LightGray;
            this.txtHesabimParola.Enabled = false;
            this.txtHesabimParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHesabimParola.Location = new System.Drawing.Point(107, 123);
            this.txtHesabimParola.Name = "txtHesabimParola";
            this.txtHesabimParola.PasswordChar = '*';
            this.txtHesabimParola.ReadOnly = true;
            this.txtHesabimParola.Size = new System.Drawing.Size(328, 26);
            this.txtHesabimParola.TabIndex = 5;
            // 
            // txtHesabimKullaniciAdi
            // 
            this.txtHesabimKullaniciAdi.BackColor = System.Drawing.Color.LightGray;
            this.txtHesabimKullaniciAdi.Enabled = false;
            this.txtHesabimKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHesabimKullaniciAdi.Location = new System.Drawing.Point(107, 59);
            this.txtHesabimKullaniciAdi.Name = "txtHesabimKullaniciAdi";
            this.txtHesabimKullaniciAdi.ReadOnly = true;
            this.txtHesabimKullaniciAdi.Size = new System.Drawing.Size(328, 26);
            this.txtHesabimKullaniciAdi.TabIndex = 4;
            // 
            // txtHesabimId
            // 
            this.txtHesabimId.BackColor = System.Drawing.Color.LightGray;
            this.txtHesabimId.Enabled = false;
            this.txtHesabimId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHesabimId.Location = new System.Drawing.Point(107, 27);
            this.txtHesabimId.Name = "txtHesabimId";
            this.txtHesabimId.ReadOnly = true;
            this.txtHesabimId.Size = new System.Drawing.Size(328, 26);
            this.txtHesabimId.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kullanıcı Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnTeslimEt);
            this.groupBox2.Controls.Add(this.dtpSonTeslimTarihi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dgvOduncAlinanKitaplar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 307);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ödünç Alınan Kitaplar";
            // 
            // btnTeslimEt
            // 
            this.btnTeslimEt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTeslimEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeslimEt.Location = new System.Drawing.Point(390, 275);
            this.btnTeslimEt.Name = "btnTeslimEt";
            this.btnTeslimEt.Size = new System.Drawing.Size(116, 26);
            this.btnTeslimEt.TabIndex = 2;
            this.btnTeslimEt.Text = "Teslim Et";
            this.btnTeslimEt.UseVisualStyleBackColor = true;
            this.btnTeslimEt.Click += new System.EventHandler(this.btnTeslimEt_Click);
            // 
            // dtpSonTeslimTarihi
            // 
            this.dtpSonTeslimTarihi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpSonTeslimTarihi.Enabled = false;
            this.dtpSonTeslimTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpSonTeslimTarihi.Location = new System.Drawing.Point(141, 275);
            this.dtpSonTeslimTarihi.Name = "dtpSonTeslimTarihi";
            this.dtpSonTeslimTarihi.Size = new System.Drawing.Size(243, 26);
            this.dtpSonTeslimTarihi.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(2, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Son Teslim Tarihi:";
            // 
            // dgvOduncAlinanKitaplar
            // 
            this.dgvOduncAlinanKitaplar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOduncAlinanKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOduncAlinanKitaplar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOduncAlinanKitaplar.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvOduncAlinanKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOduncAlinanKitaplar.Location = new System.Drawing.Point(6, 25);
            this.dgvOduncAlinanKitaplar.MultiSelect = false;
            this.dgvOduncAlinanKitaplar.Name = "dgvOduncAlinanKitaplar";
            this.dgvOduncAlinanKitaplar.ReadOnly = true;
            this.dgvOduncAlinanKitaplar.RowHeadersVisible = false;
            this.dgvOduncAlinanKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOduncAlinanKitaplar.Size = new System.Drawing.Size(500, 243);
            this.dgvOduncAlinanKitaplar.TabIndex = 4;
            this.dgvOduncAlinanKitaplar.SelectionChanged += new System.EventHandler(this.dgvOduncAlinanKitaplar_SelectionChanged);
            // 
            // HesabimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 502);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(552, 541);
            this.Name = "HesabimForm";
            this.Text = "Hesabım";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOduncAlinanKitaplar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvOduncAlinanKitaplar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtHesabimAdSoyad;
        private System.Windows.Forms.TextBox txtHesabimParola;
        private System.Windows.Forms.TextBox txtHesabimKullaniciAdi;
        private System.Windows.Forms.TextBox txtHesabimId;
        private System.Windows.Forms.Button btnTeslimEt;
        private System.Windows.Forms.DateTimePicker dtpSonTeslimTarihi;
        private System.Windows.Forms.Label label5;
    }
}