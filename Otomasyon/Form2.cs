using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=kutuphane;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        SqlCommand cmd;
        bool returnvalue = false;


        private void btn_kayit_Click(object sender, EventArgs e)
        {
            if (txt_ad.Text is null && txt_ad.Text.Equals(" ") && txt_ad.Text.Equals("") || txt_soyad.Text is null && txt_soyad.Text.Equals("") && txt_soyad.Text.Equals("") || txt_eposta.Text is null && txt_eposta.Text.Equals(" ") && txt_eposta.Text.Equals("") || txt_tcno.Text is null && txt_tcno.Text.Equals("") && txt_tcno.Text.Equals("") || txt_sifre.Text is null && txt_sifre.Text.Equals("") && txt_sifre.Text.Equals("") || txt_sifreD.Text is null && txt_sifreD.Text.Equals(" ") && txt_sifreD.Text.Equals(""))
            {
                MessageBox.Show("Lütfen boşluk bırakmayınız...");
            }
            else
            {
                if (emailkontrol(txt_eposta.Text))
                {
                    kimliknoKontrol(txt_tcno.Text);
                    if (!returnvalue)
                        MessageBox.Show("Yanlış ya da eksik kimlik numarası girdiniz.");
                    else{
                        if (txt_sifre.Text.Equals(txt_sifreD.Text))
                        {
                        cmd = new SqlCommand($"insert into uyeler (ad,soyad,email,sifre,tc_no,yetki_id)values('{txt_ad.Text}','{txt_soyad.Text}','{txt_eposta.Text}','{txt_sifre.Text}','{txt_tcno.Text}',{0})",conn);
                        }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir eposta adresi giriniz.");
                }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Lütfen girmiş olduğunuz şifrelerinizin aynı olduğundan emin olun");
                }
                
                conn.Open();
                cmd.ExecuteNonQuery();
                int isexecute= cmd.ExecuteNonQuery();
                if (isexecute>0)
                {
                    this.Dispose();
                }

            }
            conn.Close();
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
        void kimliknoKontrol(String tc_no)
        {
            if (txt_tcno.Text.Length == 11)
            {
                Int64 ATCNO, BTCNO, TcNo;
                long C1, C2, C3, C4, C5, C6, C7, C8, C9, Q1, Q2;

                TcNo = Int64.Parse(tc_no);

                ATCNO = TcNo / 100;
                BTCNO = TcNo / 100;

                C1 = ATCNO % 10; ATCNO = ATCNO / 10;
                C2 = ATCNO % 10; ATCNO = ATCNO / 10;
                C3 = ATCNO % 10; ATCNO = ATCNO / 10;
                C4 = ATCNO % 10; ATCNO = ATCNO / 10;
                C5 = ATCNO % 10; ATCNO = ATCNO / 10;
                C6 = ATCNO % 10; ATCNO = ATCNO / 10;
                C7 = ATCNO % 10; ATCNO = ATCNO / 10;
                C8 = ATCNO % 10; ATCNO = ATCNO / 10;
                C9 = ATCNO % 10; ATCNO = ATCNO / 10;
                Q1 = ((10 - ((((C1 + C3 + C5 + C7 + C9) * 3) + (C2 + C4 + C6 + C8)) % 10)) % 10);
                Q2 = ((10 - (((((C2 + C4 + C6 + C8) + Q1) * 3) + (C1 + C3 + C5 + C7 + C9)) % 10)) % 10);

                returnvalue = ((BTCNO * 100) + (Q1 * 10) + Q2 == TcNo);
            }
        }
    }
}
