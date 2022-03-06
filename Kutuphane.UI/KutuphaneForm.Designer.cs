namespace Kutuphane.UI
{
    partial class KutuphaneForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.tsmiHesabim = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBagisYap = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCikisYap = new System.Windows.Forms.ToolStripMenuItem();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.cboTurler = new System.Windows.Forms.ComboBox();
            this.dgvKitaplar = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiKitapOduncAl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKitapImhaEt = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.White;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHesabim,
            this.tsmiBagisYap,
            this.tsmiCikisYap});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(759, 29);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // tsmiHesabim
            // 
            this.tsmiHesabim.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsmiHesabim.Name = "tsmiHesabim";
            this.tsmiHesabim.Size = new System.Drawing.Size(83, 25);
            this.tsmiHesabim.Text = "Hesabım";
            this.tsmiHesabim.Click += new System.EventHandler(this.tsmiHesabim_Click);
            // 
            // tsmiBagisYap
            // 
            this.tsmiBagisYap.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsmiBagisYap.Name = "tsmiBagisYap";
            this.tsmiBagisYap.Size = new System.Drawing.Size(88, 25);
            this.tsmiBagisYap.Text = "Bağış Yap";
            this.tsmiBagisYap.Click += new System.EventHandler(this.tsmiBagisYap_Click);
            // 
            // tsmiCikisYap
            // 
            this.tsmiCikisYap.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsmiCikisYap.Name = "tsmiCikisYap";
            this.tsmiCikisYap.Size = new System.Drawing.Size(84, 25);
            this.tsmiCikisYap.Text = "Çıkış Yap";
            this.tsmiCikisYap.Click += new System.EventHandler(this.tsmiCikisYap_Click);
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(88, 39);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(181, 29);
            this.txtArama.TabIndex = 3;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // cboTurler
            // 
            this.cboTurler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTurler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTurler.FormattingEnabled = true;
            this.cboTurler.Location = new System.Drawing.Point(592, 36);
            this.cboTurler.Name = "cboTurler";
            this.cboTurler.Size = new System.Drawing.Size(155, 32);
            this.cboTurler.TabIndex = 4;
            this.cboTurler.SelectedIndexChanged += new System.EventHandler(this.cboTurler_SelectedIndexChanged);
            // 
            // dgvKitaplar
            // 
            this.dgvKitaplar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKitaplar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitaplar.Location = new System.Drawing.Point(16, 74);
            this.dgvKitaplar.MultiSelect = false;
            this.dgvKitaplar.Name = "dgvKitaplar";
            this.dgvKitaplar.ReadOnly = true;
            this.dgvKitaplar.RowHeadersVisible = false;
            this.dgvKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKitaplar.Size = new System.Drawing.Size(731, 351);
            this.dgvKitaplar.TabIndex = 5;
            this.dgvKitaplar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvKitaplar_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Arama:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(521, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Türler:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiKitapOduncAl,
            this.tsmiKitapImhaEt});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 48);
            // 
            // tsmiKitapOduncAl
            // 
            this.tsmiKitapOduncAl.Name = "tsmiKitapOduncAl";
            this.tsmiKitapOduncAl.Size = new System.Drawing.Size(180, 22);
            this.tsmiKitapOduncAl.Text = "Kitap Ödünç Al";
            this.tsmiKitapOduncAl.Click += new System.EventHandler(this.tsmiKitapOduncAl_Click);
            // 
            // tsmiKitapImhaEt
            // 
            this.tsmiKitapImhaEt.Name = "tsmiKitapImhaEt";
            this.tsmiKitapImhaEt.Size = new System.Drawing.Size(180, 22);
            this.tsmiKitapImhaEt.Text = "Kitap İmha Et";
            this.tsmiKitapImhaEt.Click += new System.EventHandler(this.tsmiKitapImhaEt_Click);
            // 
            // KutuphaneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(759, 437);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvKitaplar);
            this.Controls.Add(this.cboTurler);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MinimumSize = new System.Drawing.Size(775, 476);
            this.Name = "KutuphaneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KutuphaneForm_FormClosing);
            this.Load += new System.EventHandler(this.KutuphaneForm_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tsmiHesabim;
        private System.Windows.Forms.ToolStripMenuItem tsmiBagisYap;
        private System.Windows.Forms.ToolStripMenuItem tsmiCikisYap;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.ComboBox cboTurler;
        private System.Windows.Forms.DataGridView dgvKitaplar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiKitapOduncAl;
        private System.Windows.Forms.ToolStripMenuItem tsmiKitapImhaEt;
    }
}