
namespace ATM_Makinesi
{
    partial class Hesap_İşlemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hesap_İşlemleri));
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ParaÇek = new System.Windows.Forms.Button();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.ParaYatır = new System.Windows.Forms.Button();
            this.ŞifreDeğiş = new System.Windows.Forms.Button();
            this.ParaGönder = new System.Windows.Forms.Button();
            this.txtGönderilecekHesapNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHesapNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBakiye
            // 
            this.txtBakiye.BackColor = System.Drawing.Color.White;
            this.txtBakiye.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBakiye.ForeColor = System.Drawing.Color.White;
            this.txtBakiye.Location = new System.Drawing.Point(250, 11);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Size = new System.Drawing.Size(125, 37);
            this.txtBakiye.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hesap Bakiyeniz:";
            // 
            // ParaÇek
            // 
            this.ParaÇek.BackColor = System.Drawing.Color.Red;
            this.ParaÇek.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ParaÇek.ForeColor = System.Drawing.Color.White;
            this.ParaÇek.Location = new System.Drawing.Point(423, 113);
            this.ParaÇek.Name = "ParaÇek";
            this.ParaÇek.Size = new System.Drawing.Size(154, 71);
            this.ParaÇek.TabIndex = 3;
            this.ParaÇek.Text = "Para Çek";
            this.ParaÇek.UseVisualStyleBackColor = false;
            this.ParaÇek.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMiktar
            // 
            this.txtMiktar.BackColor = System.Drawing.Color.Red;
            this.txtMiktar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMiktar.ForeColor = System.Drawing.Color.White;
            this.txtMiktar.Location = new System.Drawing.Point(612, 30);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(154, 41);
            this.txtMiktar.TabIndex = 1;
            // 
            // ParaYatır
            // 
            this.ParaYatır.BackColor = System.Drawing.Color.Red;
            this.ParaYatır.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ParaYatır.ForeColor = System.Drawing.Color.White;
            this.ParaYatır.Location = new System.Drawing.Point(612, 113);
            this.ParaYatır.Name = "ParaYatır";
            this.ParaYatır.Size = new System.Drawing.Size(154, 71);
            this.ParaYatır.TabIndex = 4;
            this.ParaYatır.Text = "Para Yatır";
            this.ParaYatır.UseVisualStyleBackColor = false;
            this.ParaYatır.Click += new System.EventHandler(this.ParaYatır_Click);
            // 
            // ŞifreDeğiş
            // 
            this.ŞifreDeğiş.BackColor = System.Drawing.Color.Red;
            this.ŞifreDeğiş.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ŞifreDeğiş.ForeColor = System.Drawing.Color.White;
            this.ŞifreDeğiş.Location = new System.Drawing.Point(13, 162);
            this.ŞifreDeğiş.Name = "ŞifreDeğiş";
            this.ŞifreDeğiş.Size = new System.Drawing.Size(153, 71);
            this.ŞifreDeğiş.TabIndex = 5;
            this.ŞifreDeğiş.Text = "Şifre Değiştir";
            this.ŞifreDeğiş.UseVisualStyleBackColor = false;
            this.ŞifreDeğiş.Click += new System.EventHandler(this.ŞifreDeğiş_Click);
            // 
            // ParaGönder
            // 
            this.ParaGönder.BackColor = System.Drawing.Color.Red;
            this.ParaGönder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ParaGönder.ForeColor = System.Drawing.Color.White;
            this.ParaGönder.Location = new System.Drawing.Point(635, 297);
            this.ParaGönder.Name = "ParaGönder";
            this.ParaGönder.Size = new System.Drawing.Size(153, 71);
            this.ParaGönder.TabIndex = 7;
            this.ParaGönder.Text = "Para Gönder";
            this.ParaGönder.UseVisualStyleBackColor = false;
            this.ParaGönder.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtGönderilecekHesapNo
            // 
            this.txtGönderilecekHesapNo.BackColor = System.Drawing.Color.Red;
            this.txtGönderilecekHesapNo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtGönderilecekHesapNo.ForeColor = System.Drawing.Color.White;
            this.txtGönderilecekHesapNo.Location = new System.Drawing.Point(654, 238);
            this.txtGönderilecekHesapNo.Name = "txtGönderilecekHesapNo";
            this.txtGönderilecekHesapNo.Size = new System.Drawing.Size(134, 38);
            this.txtGönderilecekHesapNo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(423, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 62);
            this.label2.TabIndex = 7;
            this.label2.Text = "Para Gönderilecek \r\nHesap Numarası:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(423, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 62);
            this.label3.TabIndex = 7;
            this.label3.Text = "İşlem Yapılacak \r\nPara Miktarı:";
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.BackColor = System.Drawing.Color.White;
            this.txtHesapNo.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtHesapNo.ForeColor = System.Drawing.Color.White;
            this.txtHesapNo.Location = new System.Drawing.Point(250, 82);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(125, 37);
            this.txtHesapNo.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 35);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hesap Numaranız:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(13, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 71);
            this.button1.TabIndex = 8;
            this.button1.Text = "ÇIKIŞ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Hesap_İşlemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 382);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ParaGönder);
            this.Controls.Add(this.ŞifreDeğiş);
            this.Controls.Add(this.ParaYatır);
            this.Controls.Add(this.txtGönderilecekHesapNo);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.ParaÇek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHesapNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBakiye);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Hesap_İşlemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap_İşlemleri";
            this.Load += new System.EventHandler(this.Hesap_İşlemleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ParaÇek;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Button ParaYatır;
        private System.Windows.Forms.Button ŞifreDeğiş;
        private System.Windows.Forms.Button ParaGönder;
        private System.Windows.Forms.TextBox txtGönderilecekHesapNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHesapNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}