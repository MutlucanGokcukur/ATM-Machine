
namespace ATM_Makinesi
{
    partial class ŞifreDeğişme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ŞifreDeğişme));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHesapNumarası = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eski Şifrenizi Giriniz:";
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.Red;
            this.txtSifre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSifre.ForeColor = System.Drawing.Color.White;
            this.txtSifre.Location = new System.Drawing.Point(283, 78);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(125, 34);
            this.txtSifre.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hesap Numaranız:";
            // 
            // txtHesapNumarası
            // 
            this.txtHesapNumarası.BackColor = System.Drawing.Color.Red;
            this.txtHesapNumarası.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtHesapNumarası.ForeColor = System.Drawing.Color.White;
            this.txtHesapNumarası.Location = new System.Drawing.Point(283, 9);
            this.txtHesapNumarası.Name = "txtHesapNumarası";
            this.txtHesapNumarası.Size = new System.Drawing.Size(125, 34);
            this.txtHesapNumarası.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 71);
            this.button1.TabIndex = 1;
            this.button1.Text = "Eski Şifreyi Doğrula";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yeni Şifrenizi Giriniz:";
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.BackColor = System.Drawing.Color.Red;
            this.txtYeniSifre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtYeniSifre.ForeColor = System.Drawing.Color.White;
            this.txtYeniSifre.Location = new System.Drawing.Point(283, 245);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.PasswordChar = '*';
            this.txtYeniSifre.Size = new System.Drawing.Size(125, 34);
            this.txtYeniSifre.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 71);
            this.button2.TabIndex = 3;
            this.button2.Text = "Şifre Değiştir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(255, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 71);
            this.button3.TabIndex = 4;
            this.button3.Text = "ÇIKIŞ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ŞifreDeğişme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(419, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtHesapNumarası);
            this.Controls.Add(this.txtYeniSifre);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ŞifreDeğişme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ŞifreDeğişme";
            this.Load += new System.EventHandler(this.ŞifreDeğişme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHesapNumarası;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}