namespace Eczane
{
    partial class HastaKayitFormu
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
            this.HastaListelemeView = new System.Windows.Forms.DataGridView();
            this.hastaKayit = new System.Windows.Forms.GroupBox();
            this.dtpHastaKayitTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtYakiniTelNo = new System.Windows.Forms.TextBox();
            this.txtYakiniTc = new System.Windows.Forms.TextBox();
            this.txtYakinAdSoyad = new System.Windows.Forms.TextBox();
            this.txtHastaAdres = new System.Windows.Forms.TextBox();
            this.txtHastaTeshis = new System.Windows.Forms.TextBox();
            this.txtHastaTelefon = new System.Windows.Forms.TextBox();
            this.txtHastaTc = new System.Windows.Forms.TextBox();
            this.txtHastaSoyadi = new System.Windows.Forms.TextBox();
            this.txtHastaAdi = new System.Windows.Forms.TextBox();
            this.btnHastaKaydet = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHastaKayıtGeri = new System.Windows.Forms.Button();
            this.btnHastaKayitGuncelle = new System.Windows.Forms.Button();
            this.btnHastaKayitSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HastaListelemeView)).BeginInit();
            this.hastaKayit.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SlateGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(562, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1346, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Listeleme";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HastaListelemeView
            // 
            this.HastaListelemeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HastaListelemeView.Location = new System.Drawing.Point(562, 179);
            this.HastaListelemeView.Name = "HastaListelemeView";
            this.HastaListelemeView.RowHeadersWidth = 51;
            this.HastaListelemeView.RowTemplate.Height = 24;
            this.HastaListelemeView.Size = new System.Drawing.Size(1346, 493);
            this.HastaListelemeView.TabIndex = 1;
            this.HastaListelemeView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HastaListelemeView_CellContentClick);
            // 
            // hastaKayit
            // 
            this.hastaKayit.BackColor = System.Drawing.Color.SlateGray;
            this.hastaKayit.Controls.Add(this.dtpHastaKayitTarihi);
            this.hastaKayit.Controls.Add(this.txtYakiniTelNo);
            this.hastaKayit.Controls.Add(this.txtYakiniTc);
            this.hastaKayit.Controls.Add(this.txtYakinAdSoyad);
            this.hastaKayit.Controls.Add(this.txtHastaAdres);
            this.hastaKayit.Controls.Add(this.txtHastaTeshis);
            this.hastaKayit.Controls.Add(this.txtHastaTelefon);
            this.hastaKayit.Controls.Add(this.txtHastaTc);
            this.hastaKayit.Controls.Add(this.txtHastaSoyadi);
            this.hastaKayit.Controls.Add(this.txtHastaAdi);
            this.hastaKayit.Controls.Add(this.btnHastaKaydet);
            this.hastaKayit.Controls.Add(this.label12);
            this.hastaKayit.Controls.Add(this.label11);
            this.hastaKayit.Controls.Add(this.label9);
            this.hastaKayit.Controls.Add(this.label8);
            this.hastaKayit.Controls.Add(this.label7);
            this.hastaKayit.Controls.Add(this.label6);
            this.hastaKayit.Controls.Add(this.label5);
            this.hastaKayit.Controls.Add(this.label4);
            this.hastaKayit.Controls.Add(this.label3);
            this.hastaKayit.Controls.Add(this.label2);
            this.hastaKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaKayit.ForeColor = System.Drawing.Color.Gainsboro;
            this.hastaKayit.Location = new System.Drawing.Point(27, 115);
            this.hastaKayit.Name = "hastaKayit";
            this.hastaKayit.Size = new System.Drawing.Size(497, 699);
            this.hastaKayit.TabIndex = 2;
            this.hastaKayit.TabStop = false;
            this.hastaKayit.Text = "Hasta Kayıt";
            // 
            // dtpHastaKayitTarihi
            // 
            this.dtpHastaKayitTarihi.Location = new System.Drawing.Point(210, 539);
            this.dtpHastaKayitTarihi.Name = "dtpHastaKayitTarihi";
            this.dtpHastaKayitTarihi.Size = new System.Drawing.Size(264, 27);
            this.dtpHastaKayitTarihi.TabIndex = 21;
            // 
            // txtYakiniTelNo
            // 
            this.txtYakiniTelNo.Location = new System.Drawing.Point(209, 492);
            this.txtYakiniTelNo.Name = "txtYakiniTelNo";
            this.txtYakiniTelNo.Size = new System.Drawing.Size(265, 27);
            this.txtYakiniTelNo.TabIndex = 19;
            // 
            // txtYakiniTc
            // 
            this.txtYakiniTc.Location = new System.Drawing.Point(209, 438);
            this.txtYakiniTc.Name = "txtYakiniTc";
            this.txtYakiniTc.Size = new System.Drawing.Size(265, 27);
            this.txtYakiniTc.TabIndex = 18;
            // 
            // txtYakinAdSoyad
            // 
            this.txtYakinAdSoyad.Location = new System.Drawing.Point(210, 381);
            this.txtYakinAdSoyad.Name = "txtYakinAdSoyad";
            this.txtYakinAdSoyad.Size = new System.Drawing.Size(265, 27);
            this.txtYakinAdSoyad.TabIndex = 17;
            // 
            // txtHastaAdres
            // 
            this.txtHastaAdres.Location = new System.Drawing.Point(209, 332);
            this.txtHastaAdres.Name = "txtHastaAdres";
            this.txtHastaAdres.Size = new System.Drawing.Size(265, 27);
            this.txtHastaAdres.TabIndex = 16;
            // 
            // txtHastaTeshis
            // 
            this.txtHastaTeshis.Location = new System.Drawing.Point(210, 277);
            this.txtHastaTeshis.Name = "txtHastaTeshis";
            this.txtHastaTeshis.Size = new System.Drawing.Size(265, 27);
            this.txtHastaTeshis.TabIndex = 15;
            // 
            // txtHastaTelefon
            // 
            this.txtHastaTelefon.Location = new System.Drawing.Point(209, 224);
            this.txtHastaTelefon.Name = "txtHastaTelefon";
            this.txtHastaTelefon.Size = new System.Drawing.Size(265, 27);
            this.txtHastaTelefon.TabIndex = 14;
            // 
            // txtHastaTc
            // 
            this.txtHastaTc.Location = new System.Drawing.Point(209, 175);
            this.txtHastaTc.Name = "txtHastaTc";
            this.txtHastaTc.Size = new System.Drawing.Size(265, 27);
            this.txtHastaTc.TabIndex = 13;
            // 
            // txtHastaSoyadi
            // 
            this.txtHastaSoyadi.Location = new System.Drawing.Point(209, 126);
            this.txtHastaSoyadi.Name = "txtHastaSoyadi";
            this.txtHastaSoyadi.Size = new System.Drawing.Size(265, 27);
            this.txtHastaSoyadi.TabIndex = 12;
            // 
            // txtHastaAdi
            // 
            this.txtHastaAdi.Location = new System.Drawing.Point(209, 80);
            this.txtHastaAdi.Name = "txtHastaAdi";
            this.txtHastaAdi.Size = new System.Drawing.Size(265, 27);
            this.txtHastaAdi.TabIndex = 11;
            // 
            // btnHastaKaydet
            // 
            this.btnHastaKaydet.ForeColor = System.Drawing.Color.SlateGray;
            this.btnHastaKaydet.Location = new System.Drawing.Point(209, 593);
            this.btnHastaKaydet.Name = "btnHastaKaydet";
            this.btnHastaKaydet.Size = new System.Drawing.Size(265, 60);
            this.btnHastaKaydet.TabIndex = 3;
            this.btnHastaKaydet.Text = "Kaydet";
            this.btnHastaKaydet.UseVisualStyleBackColor = true;
            this.btnHastaKaydet.Click += new System.EventHandler(this.btnHastaKaydet_Click);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(38, 430);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(182, 34);
            this.label12.TabIndex = 10;
            this.label12.Text = "Yakını Tc:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(38, 485);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 34);
            this.label11.TabIndex = 9;
            this.label11.Text = "Yakını Telefon No:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(39, 537);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 34);
            this.label9.TabIndex = 7;
            this.label9.Text = "Kayıt Tarihi:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(38, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 34);
            this.label8.TabIndex = 6;
            this.label8.Text = "Soyadı:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(38, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 34);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tc:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(38, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 34);
            this.label6.TabIndex = 4;
            this.label6.Text = "Telefon No:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(39, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 34);
            this.label5.TabIndex = 3;
            this.label5.Text = "Yakını Adı Soyadı:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(39, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 34);
            this.label4.TabIndex = 2;
            this.label4.Text = "Teshis:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(38, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 34);
            this.label3.TabIndex = 1;
            this.label3.Text = "Adresi:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(38, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adı:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnHastaKayıtGeri
            // 
            this.btnHastaKayıtGeri.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnHastaKayıtGeri.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHastaKayıtGeri.Location = new System.Drawing.Point(13, 13);
            this.btnHastaKayıtGeri.Name = "btnHastaKayıtGeri";
            this.btnHastaKayıtGeri.Size = new System.Drawing.Size(138, 58);
            this.btnHastaKayıtGeri.TabIndex = 3;
            this.btnHastaKayıtGeri.Text = "Geri";
            this.btnHastaKayıtGeri.UseVisualStyleBackColor = false;
            this.btnHastaKayıtGeri.Click += new System.EventHandler(this.btnHastaKayıtGeri_Click);
            // 
            // btnHastaKayitGuncelle
            // 
            this.btnHastaKayitGuncelle.BackColor = System.Drawing.Color.SlateGray;
            this.btnHastaKayitGuncelle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHastaKayitGuncelle.Location = new System.Drawing.Point(562, 678);
            this.btnHastaKayitGuncelle.Name = "btnHastaKayitGuncelle";
            this.btnHastaKayitGuncelle.Size = new System.Drawing.Size(332, 37);
            this.btnHastaKayitGuncelle.TabIndex = 4;
            this.btnHastaKayitGuncelle.Text = "Güncelle";
            this.btnHastaKayitGuncelle.UseVisualStyleBackColor = false;
            this.btnHastaKayitGuncelle.Click += new System.EventHandler(this.btnHastaKayitGuncelle_Click);
            // 
            // btnHastaKayitSil
            // 
            this.btnHastaKayitSil.BackColor = System.Drawing.Color.SlateGray;
            this.btnHastaKayitSil.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHastaKayitSil.Location = new System.Drawing.Point(1750, 678);
            this.btnHastaKayitSil.Name = "btnHastaKayitSil";
            this.btnHastaKayitSil.Size = new System.Drawing.Size(158, 37);
            this.btnHastaKayitSil.TabIndex = 5;
            this.btnHastaKayitSil.Text = "Sil";
            this.btnHastaKayitSil.UseVisualStyleBackColor = false;
            this.btnHastaKayitSil.Click += new System.EventHandler(this.btnHastaKayitSil_Click);
            // 
            // HastaKayitFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btnHastaKayitSil);
            this.Controls.Add(this.btnHastaKayitGuncelle);
            this.Controls.Add(this.btnHastaKayıtGeri);
            this.Controls.Add(this.hastaKayit);
            this.Controls.Add(this.HastaListelemeView);
            this.Controls.Add(this.label1);
            this.Name = "HastaKayitFormu";
            this.Text = "HASTA KAYIT ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HastaKayitFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HastaListelemeView)).EndInit();
            this.hastaKayit.ResumeLayout(false);
            this.hastaKayit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView HastaListelemeView;
        private System.Windows.Forms.GroupBox hastaKayit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHastaKaydet;
        private System.Windows.Forms.TextBox txtYakiniTc;
        private System.Windows.Forms.TextBox txtYakinAdSoyad;
        private System.Windows.Forms.TextBox txtHastaAdres;
        private System.Windows.Forms.TextBox txtHastaTeshis;
        private System.Windows.Forms.TextBox txtHastaTelefon;
        private System.Windows.Forms.TextBox txtHastaTc;
        private System.Windows.Forms.TextBox txtHastaSoyadi;
        private System.Windows.Forms.TextBox txtHastaAdi;
        private System.Windows.Forms.TextBox txtYakiniTelNo;
        private System.Windows.Forms.DateTimePicker dtpHastaKayitTarihi;
        private System.Windows.Forms.Button btnHastaKayıtGeri;
        private System.Windows.Forms.Button btnHastaKayitGuncelle;
        private System.Windows.Forms.Button btnHastaKayitSil;
    }
}