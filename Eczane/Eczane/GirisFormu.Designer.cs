namespace Eczane
{
    partial class GirisFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisFormu));
            this.label1 = new System.Windows.Forms.Label();
            this.grppersonel = new System.Windows.Forms.GroupBox();
            this.btnPersonelGiris = new System.Windows.Forms.Button();
            this.txtPersonelSifre = new System.Windows.Forms.TextBox();
            this.txtPersonelKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpboxYonetici = new System.Windows.Forms.GroupBox();
            this.btnYoneticiGiris = new System.Windows.Forms.Button();
            this.txtYoneticiSifre = new System.Windows.Forms.TextBox();
            this.txtYoneticiKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grppersonel.SuspendLayout();
            this.grpboxYonetici.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(42, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "ECZANE OTOMASYONU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grppersonel
            // 
            this.grppersonel.BackColor = System.Drawing.Color.Gainsboro;
            this.grppersonel.Controls.Add(this.btnPersonelGiris);
            this.grppersonel.Controls.Add(this.txtPersonelSifre);
            this.grppersonel.Controls.Add(this.txtPersonelKullaniciAdi);
            this.grppersonel.Controls.Add(this.label5);
            this.grppersonel.Controls.Add(this.label3);
            this.grppersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grppersonel.ForeColor = System.Drawing.Color.SlateGray;
            this.grppersonel.Location = new System.Drawing.Point(41, 206);
            this.grppersonel.Name = "grppersonel";
            this.grppersonel.Size = new System.Drawing.Size(379, 368);
            this.grppersonel.TabIndex = 1;
            this.grppersonel.TabStop = false;
            this.grppersonel.Text = "PERSONEL GİRİŞİ";
            // 
            // btnPersonelGiris
            // 
            this.btnPersonelGiris.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnPersonelGiris.Location = new System.Drawing.Point(149, 236);
            this.btnPersonelGiris.Name = "btnPersonelGiris";
            this.btnPersonelGiris.Size = new System.Drawing.Size(188, 64);
            this.btnPersonelGiris.TabIndex = 7;
            this.btnPersonelGiris.Text = "Giriş";
            this.btnPersonelGiris.UseVisualStyleBackColor = true;
            this.btnPersonelGiris.Click += new System.EventHandler(this.btnPersonelGiris_Click);
            // 
            // txtPersonelSifre
            // 
            this.txtPersonelSifre.Location = new System.Drawing.Point(149, 168);
            this.txtPersonelSifre.Name = "txtPersonelSifre";
            this.txtPersonelSifre.PasswordChar = '*';
            this.txtPersonelSifre.Size = new System.Drawing.Size(188, 27);
            this.txtPersonelSifre.TabIndex = 7;
            // 
            // txtPersonelKullaniciAdi
            // 
            this.txtPersonelKullaniciAdi.Location = new System.Drawing.Point(149, 106);
            this.txtPersonelKullaniciAdi.Name = "txtPersonelKullaniciAdi";
            this.txtPersonelKullaniciAdi.Size = new System.Drawing.Size(188, 27);
            this.txtPersonelKullaniciAdi.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(20, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(20, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kullanıcı Adı:";
            // 
            // grpboxYonetici
            // 
            this.grpboxYonetici.BackColor = System.Drawing.Color.Gainsboro;
            this.grpboxYonetici.Controls.Add(this.btnYoneticiGiris);
            this.grpboxYonetici.Controls.Add(this.txtYoneticiSifre);
            this.grpboxYonetici.Controls.Add(this.txtYoneticiKullaniciAdi);
            this.grpboxYonetici.Controls.Add(this.label4);
            this.grpboxYonetici.Controls.Add(this.label2);
            this.grpboxYonetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpboxYonetici.ForeColor = System.Drawing.Color.SlateGray;
            this.grpboxYonetici.Location = new System.Drawing.Point(514, 206);
            this.grpboxYonetici.Name = "grpboxYonetici";
            this.grpboxYonetici.Size = new System.Drawing.Size(397, 368);
            this.grpboxYonetici.TabIndex = 2;
            this.grpboxYonetici.TabStop = false;
            this.grpboxYonetici.Text = "YÖNETİCİ GİRİŞİ";
            // 
            // btnYoneticiGiris
            // 
            this.btnYoneticiGiris.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnYoneticiGiris.Location = new System.Drawing.Point(153, 236);
            this.btnYoneticiGiris.Name = "btnYoneticiGiris";
            this.btnYoneticiGiris.Size = new System.Drawing.Size(188, 64);
            this.btnYoneticiGiris.TabIndex = 6;
            this.btnYoneticiGiris.Text = "Giriş";
            this.btnYoneticiGiris.UseVisualStyleBackColor = true;
            this.btnYoneticiGiris.Click += new System.EventHandler(this.btnYoneticiGiris_Click);
            // 
            // txtYoneticiSifre
            // 
            this.txtYoneticiSifre.Location = new System.Drawing.Point(153, 167);
            this.txtYoneticiSifre.Name = "txtYoneticiSifre";
            this.txtYoneticiSifre.PasswordChar = '*';
            this.txtYoneticiSifre.Size = new System.Drawing.Size(188, 27);
            this.txtYoneticiSifre.TabIndex = 5;
            // 
            // txtYoneticiKullaniciAdi
            // 
            this.txtYoneticiKullaniciAdi.Location = new System.Drawing.Point(153, 104);
            this.txtYoneticiKullaniciAdi.Name = "txtYoneticiKullaniciAdi";
            this.txtYoneticiKullaniciAdi.Size = new System.Drawing.Size(188, 27);
            this.txtYoneticiKullaniciAdi.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(17, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // GirisFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1083, 719);
            this.Controls.Add(this.grpboxYonetici);
            this.Controls.Add(this.grppersonel);
            this.Controls.Add(this.label1);
            this.Name = "GirisFormu";
            this.Text = "GİRİŞ PANELİ";
            this.grppersonel.ResumeLayout(false);
            this.grppersonel.PerformLayout();
            this.grpboxYonetici.ResumeLayout(false);
            this.grpboxYonetici.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grppersonel;
        private System.Windows.Forms.GroupBox grpboxYonetici;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPersonelSifre;
        private System.Windows.Forms.TextBox txtPersonelKullaniciAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnYoneticiGiris;
        private System.Windows.Forms.TextBox txtYoneticiSifre;
        private System.Windows.Forms.TextBox txtYoneticiKullaniciAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPersonelGiris;
    }
}