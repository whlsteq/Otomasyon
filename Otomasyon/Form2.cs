using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomasyon
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            if (txt_ad.Text is null && txt_ad.Text.Equals(" ") && txt_ad.Text.Equals("") || txt_soyad.Text is null && txt_soyad.Text.Equals("") && txt_soyad.Text.Equals("") || txt_eposta.Text is null && txt_eposta.Text.Equals(" ") && txt_eposta.Text.Equals("") || txt_tcno.Text is null && txt_tcno.Text.Equals("") && txt_tcno.Text.Equals("") || txt_sifre.Text is null && txt_sifre.Text.Equals("") && txt_sifre.Text.Equals("") || txt_sifreD.Text is null && txt_sifreD.Text.Equals(" ") && txt_sifreD.Text.Equals(""))
            {
                MessageBox.Show("Lütfen boşluk bırakmayınız...");
            }
            else
            {
                Uyeler uyeler = new Uyeler();
                uyeler._Ad = txt_ad.Text;
                uyeler._Soyad = txt_soyad.Text;
                int tcno;
                if (!(int.TryParse(txt_tcno.Text, out tcno)))
                {
                    MessageBox.Show("Lütfen kimlik numaranızı giriniz.");
                }
                else { uyeler._Tcno = tcno; }
                if (txt_sifre.Text.Equals(txt_sifreD.Text))
                {
                    txt_sifre.Text = uyeler._sifre;
                }
                else
                {
                    MessageBox.Show("Lütfen girmiş olduğunuz şifrelerinizin aynı olduğundan emin olun");
                }
                if (emailkontrol(txt_eposta.Text))
                {
                    uyeler._Eposta = txt_eposta.Text;
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir eposta adresi giriniz.");
                }


            }

        }
        bool emailkontrol(string eMail)
        {
            bool Result = false;

            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress(eMail);

                Result = (eMail.LastIndexOf(".") > eMail.LastIndexOf("@"));
            }
            catch
            {
                Result = false;
            };

            return Result;

        }
    }
}
