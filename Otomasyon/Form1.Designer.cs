namespace Otomasyon
{
    partial class Form1
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
            this.btn_giris = new System.Windows.Forms.Button();
            this.btn_kayit = new System.Windows.Forms.Button();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_tcno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(184, 158);
            this.btn_giris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(84, 23);
            this.btn_giris.TabIndex = 0;
            this.btn_giris.Text = "Giriş Yap";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // btn_kayit
            // 
            this.btn_kayit.Location = new System.Drawing.Point(312, 86);
            this.btn_kayit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(94, 23);
            this.btn_kayit.TabIndex = 1;
            this.btn_kayit.Text = "Kayıt Ol";
            this.btn_kayit.UseVisualStyleBackColor = true;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(165, 106);
            this.txt_sifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.Size = new System.Drawing.Size(125, 22);
            this.txt_sifre.TabIndex = 2;
            // 
            // txt_tcno
            // 
            this.txt_tcno.Location = new System.Drawing.Point(165, 61);
            this.txt_tcno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tcno.MaxLength = 11;
            this.txt_tcno.Name = "txt_tcno";
            this.txt_tcno.Size = new System.Drawing.Size(125, 22);
            this.txt_tcno.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "TC Kimlik No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 252);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_tcno);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.btn_kayit);
            this.Controls.Add(this.btn_giris);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Kütüphane Otomasyonu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Button btn_kayit;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_tcno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

