namespace Eczane
{
    partial class IlacEkleFormu
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
            this.btnIlacEkleGeri = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbIlacTuru = new System.Windows.Forms.ComboBox();
            this.txtIlacFiyati = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnIlacKaydet = new System.Windows.Forms.Button();
            this.txtIlacAdeti = new System.Windows.Forms.TextBox();
            this.dtpIlacGelisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpIlacSkt = new System.Windows.Forms.DateTimePicker();
            this.txtGtin = new System.Windows.Forms.TextBox();
            this.txtUreticiFirma = new System.Windows.Forms.TextBox();
            this.txtIlacAdi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IlclarView = new System.Windows.Forms.DataGridView();
            this.btnIlacEkleGuncelle = new System.Windows.Forms.Button();
            this.btnIlacSil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IlclarView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SlateGray;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(531, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1369, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "İLAÇ EKLEME ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnIlacEkleGeri
            // 
            this.btnIlacEkleGeri.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnIlacEkleGeri.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnIlacEkleGeri.Location = new System.Drawing.Point(13, 13);
            this.btnIlacEkleGeri.Name = "btnIlacEkleGeri";
            this.btnIlacEkleGeri.Size = new System.Drawing.Size(138, 58);
            this.btnIlacEkleGeri.TabIndex = 1;
            this.btnIlacEkleGeri.Text = "Geri";
            this.btnIlacEkleGeri.UseVisualStyleBackColor = false;
            this.btnIlacEkleGeri.Click += new System.EventHandler(this.btnIlacEkleGeri_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SlateGray;
            this.groupBox1.Controls.Add(this.cmbIlacTuru);
            this.groupBox1.Controls.Add(this.txtIlacFiyati);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnIlacKaydet);
            this.groupBox1.Controls.Add(this.txtIlacAdeti);
            this.groupBox1.Controls.Add(this.dtpIlacGelisTarihi);
            this.groupBox1.Controls.Add(this.dtpIlacSkt);
            this.groupBox1.Controls.Add(this.txtGtin);
            this.groupBox1.Controls.Add(this.txtUreticiFirma);
            this.groupBox1.Controls.Add(this.txtIlacAdi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(54, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 643);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İlaç Ekle";
            // 
            // cmbIlacTuru
            // 
            this.cmbIlacTuru.FormattingEnabled = true;
            this.cmbIlacTuru.Location = new System.Drawing.Point(197, 322);
            this.cmbIlacTuru.Name = "cmbIlacTuru";
            this.cmbIlacTuru.Size = new System.Drawing.Size(245, 28);
            this.cmbIlacTuru.TabIndex = 17;
            // 
            // txtIlacFiyati
            // 
            this.txtIlacFiyati.Location = new System.Drawing.Point(197, 484);
            this.txtIlacFiyati.Name = "txtIlacFiyati";
            this.txtIlacFiyati.Size = new System.Drawing.Size(244, 27);
            this.txtIlacFiyati.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(27, 487);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "Fiyatı:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnIlacKaydet
            // 
            this.btnIlacKaydet.BackColor = System.Drawing.Color.LightGray;
            this.btnIlacKaydet.ForeColor = System.Drawing.Color.SlateGray;
            this.btnIlacKaydet.Location = new System.Drawing.Point(197, 573);
            this.btnIlacKaydet.Name = "btnIlacKaydet";
            this.btnIlacKaydet.Size = new System.Drawing.Size(244, 64);
            this.btnIlacKaydet.TabIndex = 14;
            this.btnIlacKaydet.Text = "Kaydet";
            this.btnIlacKaydet.UseVisualStyleBackColor = false;
            this.btnIlacKaydet.Click += new System.EventHandler(this.btnIlacKaydet_Click);
            // 
            // txtIlacAdeti
            // 
            this.txtIlacAdeti.Location = new System.Drawing.Point(197, 433);
            this.txtIlacAdeti.Name = "txtIlacAdeti";
            this.txtIlacAdeti.Size = new System.Drawing.Size(244, 27);
            this.txtIlacAdeti.TabIndex = 13;
            // 
            // dtpIlacGelisTarihi
            // 
            this.dtpIlacGelisTarihi.Location = new System.Drawing.Point(198, 378);
            this.dtpIlacGelisTarihi.Name = "dtpIlacGelisTarihi";
            this.dtpIlacGelisTarihi.Size = new System.Drawing.Size(243, 27);
            this.dtpIlacGelisTarihi.TabIndex = 11;
            // 
            // dtpIlacSkt
            // 
            this.dtpIlacSkt.Location = new System.Drawing.Point(199, 265);
            this.dtpIlacSkt.Name = "dtpIlacSkt";
            this.dtpIlacSkt.Size = new System.Drawing.Size(243, 27);
            this.dtpIlacSkt.TabIndex = 10;
            // 
            // txtGtin
            // 
            this.txtGtin.Location = new System.Drawing.Point(198, 149);
            this.txtGtin.Name = "txtGtin";
            this.txtGtin.Size = new System.Drawing.Size(244, 27);
            this.txtGtin.TabIndex = 9;
            // 
            // txtUreticiFirma
            // 
            this.txtUreticiFirma.Location = new System.Drawing.Point(198, 206);
            this.txtUreticiFirma.Name = "txtUreticiFirma";
            this.txtUreticiFirma.Size = new System.Drawing.Size(244, 27);
            this.txtUreticiFirma.TabIndex = 8;
            // 
            // txtIlacAdi
            // 
            this.txtIlacAdi.Location = new System.Drawing.Point(198, 95);
            this.txtIlacAdi.Name = "txtIlacAdi";
            this.txtIlacAdi.Size = new System.Drawing.Size(244, 27);
            this.txtIlacAdi.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(27, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 24);
            this.label8.TabIndex = 6;
            this.label8.Text = "Üretici Firma:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(27, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "İlaç SKT:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(27, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "İlaç Türü:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(27, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "İlaç Geliş Tarihi:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(27, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "İlaç Adeti:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(27, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "GTIN:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(27, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "İlaç Adı:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IlclarView
            // 
            this.IlclarView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IlclarView.Location = new System.Drawing.Point(531, 143);
            this.IlclarView.Name = "IlclarView";
            this.IlclarView.RowHeadersWidth = 51;
            this.IlclarView.RowTemplate.Height = 24;
            this.IlclarView.Size = new System.Drawing.Size(1369, 560);
            this.IlclarView.TabIndex = 3;
            this.IlclarView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IlclarView_CellContentClick);
            // 
            // btnIlacEkleGuncelle
            // 
            this.btnIlacEkleGuncelle.BackColor = System.Drawing.Color.SlateGray;
            this.btnIlacEkleGuncelle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnIlacEkleGuncelle.Location = new System.Drawing.Point(531, 709);
            this.btnIlacEkleGuncelle.Name = "btnIlacEkleGuncelle";
            this.btnIlacEkleGuncelle.Size = new System.Drawing.Size(354, 34);
            this.btnIlacEkleGuncelle.TabIndex = 4;
            this.btnIlacEkleGuncelle.Text = "Güncelle";
            this.btnIlacEkleGuncelle.UseVisualStyleBackColor = false;
            this.btnIlacEkleGuncelle.Click += new System.EventHandler(this.btnIlacEkleGuncelle_Click);
            // 
            // btnIlacSil
            // 
            this.btnIlacSil.BackColor = System.Drawing.Color.SlateGray;
            this.btnIlacSil.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnIlacSil.Location = new System.Drawing.Point(1775, 709);
            this.btnIlacSil.Name = "btnIlacSil";
            this.btnIlacSil.Size = new System.Drawing.Size(125, 34);
            this.btnIlacSil.TabIndex = 6;
            this.btnIlacSil.Text = "Sil";
            this.btnIlacSil.UseVisualStyleBackColor = false;
            this.btnIlacSil.Click += new System.EventHandler(this.btnIlacSil_Click);
            // 
            // IlacEkleFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 845);
            this.Controls.Add(this.btnIlacSil);
            this.Controls.Add(this.btnIlacEkleGuncelle);
            this.Controls.Add(this.IlclarView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIlacEkleGeri);
            this.Controls.Add(this.label1);
            this.Name = "IlacEkleFormu";
            this.Text = "İLAÇ EKLEME FORMU";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.IlacEkleFormu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IlclarView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIlacEkleGeri;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView IlclarView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpIlacSkt;
        private System.Windows.Forms.TextBox txtGtin;
        private System.Windows.Forms.TextBox txtUreticiFirma;
        private System.Windows.Forms.TextBox txtIlacAdi;
        private System.Windows.Forms.Button btnIlacKaydet;
        private System.Windows.Forms.TextBox txtIlacAdeti;
        private System.Windows.Forms.DateTimePicker dtpIlacGelisTarihi;
        private System.Windows.Forms.Button btnIlacEkleGuncelle;
        private System.Windows.Forms.Button btnIlacSil;
        private System.Windows.Forms.TextBox txtIlacFiyati;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbIlacTuru;
    }
}