namespace Otomasyon
{
    partial class Form2
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
            this.btn_kayit = new System.Windows.Forms.Button();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_eposta = new System.Windows.Forms.TextBox();
            this.txt_tcno = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_sifreD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_kayit
            // 
            this.btn_kayit.Location = new System.Drawing.Point(218, 165);
            this.btn_kayit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(94, 23);
            this.btn_kayit.TabIndex = 0;
            this.btn_kayit.Text = "Kayıt ol";
            this.btn_kayit.UseVisualStyleBackColor = true;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(87, 26);
            this.txt_ad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(125, 22);
            this.txt_ad.TabIndex = 1;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(340, 26);
            this.txt_soyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(125, 22);
            this.txt_soyad.TabIndex = 2;
            // 
            // txt_eposta
            // 
            this.txt_eposta.Location = new System.Drawing.Point(87, 65);
            this.txt_eposta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_eposta.Name = "txt_eposta";
            this.txt_eposta.Size = new System.Drawing.Size(125, 22);
            this.txt_eposta.TabIndex = 3;
            // 
            // txt_tcno
            // 
            this.txt_tcno.Location = new System.Drawing.Point(340, 65);
            this.txt_tcno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tcno.MaxLength = 11;
            this.txt_tcno.Name = "txt_tcno";
            this.txt_tcno.Size = new System.Drawing.Size(125, 22);
            this.txt_tcno.TabIndex = 4;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(87, 108);
            this.txt_sifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_sifre.MaxLength = 16;
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.Size = new System.Drawing.Size(125, 22);
            this.txt_sifre.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "E-posta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "TC kimlik No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Şifre";
            // 
            // txt_sifreD
            // 
            this.txt_sifreD.Location = new System.Drawing.Point(340, 108);
            this.txt_sifreD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_sifreD.MaxLength = 16;
            this.txt_sifreD.Name = "txt_sifreD";
            this.txt_sifreD.PasswordChar = '*';
            this.txt_sifreD.Size = new System.Drawing.Size(125, 22);
            this.txt_sifreD.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Şifre doğrulama";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 245);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_sifreD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_tcno);
            this.Controls.Add(this.txt_eposta);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.btn_kayit);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Kayıt ol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kayit;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_eposta;
        private System.Windows.Forms.TextBox txt_tcno;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_sifreD;
        private System.Windows.Forms.Label label6;
    }
}