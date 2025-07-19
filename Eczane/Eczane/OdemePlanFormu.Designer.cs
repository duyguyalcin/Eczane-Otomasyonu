namespace Eczane
{
    partial class OdemePlanFormu
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
            this.btnOdemePlanıGeri = new System.Windows.Forms.Button();
            this.groupOdemeSekli = new System.Windows.Forms.GroupBox();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.chbQR = new System.Windows.Forms.CheckBox();
            this.btnYeniOdeme = new System.Windows.Forms.Button();
            this.chbKart = new System.Windows.Forms.CheckBox();
            this.chbHavaleEfet = new System.Windows.Forms.CheckBox();
            this.chbNakit = new System.Windows.Forms.CheckBox();
            this.groupOdemeSekli.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOdemePlanıGeri
            // 
            this.btnOdemePlanıGeri.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnOdemePlanıGeri.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnOdemePlanıGeri.Location = new System.Drawing.Point(12, 12);
            this.btnOdemePlanıGeri.Name = "btnOdemePlanıGeri";
            this.btnOdemePlanıGeri.Size = new System.Drawing.Size(138, 58);
            this.btnOdemePlanıGeri.TabIndex = 1;
            this.btnOdemePlanıGeri.Text = "Geri";
            this.btnOdemePlanıGeri.UseVisualStyleBackColor = false;
            this.btnOdemePlanıGeri.Click += new System.EventHandler(this.btnOdemePlanıGeri_Click);
            // 
            // groupOdemeSekli
            // 
            this.groupOdemeSekli.BackColor = System.Drawing.Color.SlateGray;
            this.groupOdemeSekli.Controls.Add(this.btnOnayla);
            this.groupOdemeSekli.Controls.Add(this.chbQR);
            this.groupOdemeSekli.Controls.Add(this.btnYeniOdeme);
            this.groupOdemeSekli.Controls.Add(this.chbKart);
            this.groupOdemeSekli.Controls.Add(this.chbHavaleEfet);
            this.groupOdemeSekli.Controls.Add(this.chbNakit);
            this.groupOdemeSekli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupOdemeSekli.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupOdemeSekli.Location = new System.Drawing.Point(215, 158);
            this.groupOdemeSekli.Name = "groupOdemeSekli";
            this.groupOdemeSekli.Size = new System.Drawing.Size(409, 367);
            this.groupOdemeSekli.TabIndex = 4;
            this.groupOdemeSekli.TabStop = false;
            this.groupOdemeSekli.Text = "ÖDEME ŞEKİLLERİ";
            // 
            // btnOnayla
            // 
            this.btnOnayla.ForeColor = System.Drawing.Color.SlateGray;
            this.btnOnayla.Location = new System.Drawing.Point(75, 255);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(95, 37);
            this.btnOnayla.TabIndex = 7;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // chbQR
            // 
            this.chbQR.AutoSize = true;
            this.chbQR.Location = new System.Drawing.Point(75, 205);
            this.chbQR.Name = "chbQR";
            this.chbQR.Size = new System.Drawing.Size(56, 24);
            this.chbQR.TabIndex = 6;
            this.chbQR.Text = "QR";
            this.chbQR.UseVisualStyleBackColor = true;
            // 
            // btnYeniOdeme
            // 
            this.btnYeniOdeme.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnYeniOdeme.ForeColor = System.Drawing.Color.SlateGray;
            this.btnYeniOdeme.Location = new System.Drawing.Point(176, 256);
            this.btnYeniOdeme.Name = "btnYeniOdeme";
            this.btnYeniOdeme.Size = new System.Drawing.Size(154, 37);
            this.btnYeniOdeme.TabIndex = 5;
            this.btnYeniOdeme.Text = "Yeni Ödeme Planı";
            this.btnYeniOdeme.UseVisualStyleBackColor = false;
            this.btnYeniOdeme.Click += new System.EventHandler(this.btnYeniOdeme_Click);
            // 
            // chbKart
            // 
            this.chbKart.AutoSize = true;
            this.chbKart.Location = new System.Drawing.Point(75, 163);
            this.chbKart.Name = "chbKart";
            this.chbKart.Size = new System.Drawing.Size(162, 24);
            this.chbKart.TabIndex = 5;
            this.chbKart.Text = "Banka/Kredi Kartı";
            this.chbKart.UseVisualStyleBackColor = true;
            // 
            // chbHavaleEfet
            // 
            this.chbHavaleEfet.AutoSize = true;
            this.chbHavaleEfet.Location = new System.Drawing.Point(75, 113);
            this.chbHavaleEfet.Name = "chbHavaleEfet";
            this.chbHavaleEfet.Size = new System.Drawing.Size(119, 24);
            this.chbHavaleEfet.TabIndex = 4;
            this.chbHavaleEfet.Text = "Havale/EFT";
            this.chbHavaleEfet.UseVisualStyleBackColor = true;
            // 
            // chbNakit
            // 
            this.chbNakit.AutoSize = true;
            this.chbNakit.Location = new System.Drawing.Point(75, 68);
            this.chbNakit.Name = "chbNakit";
            this.chbNakit.Size = new System.Drawing.Size(69, 24);
            this.chbNakit.TabIndex = 3;
            this.chbNakit.Text = "Nakit";
            this.chbNakit.UseVisualStyleBackColor = true;
            // 
            // OdemePlanFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 664);
            this.Controls.Add(this.groupOdemeSekli);
            this.Controls.Add(this.btnOdemePlanıGeri);
            this.Name = "OdemePlanFormu";
            this.Text = "ÖDEME PLANI PANELİ";
            this.Load += new System.EventHandler(this.OdemePlanFormu_Load);
            this.groupOdemeSekli.ResumeLayout(false);
            this.groupOdemeSekli.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOdemePlanıGeri;
        private System.Windows.Forms.GroupBox groupOdemeSekli;
        private System.Windows.Forms.CheckBox chbKart;
        private System.Windows.Forms.CheckBox chbHavaleEfet;
        private System.Windows.Forms.CheckBox chbNakit;
        private System.Windows.Forms.CheckBox chbQR;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnYeniOdeme;
    }
}