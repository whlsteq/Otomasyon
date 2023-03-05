using Otomasyon;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool returnvalue = false;


        private void btn_giris_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=kutuphane;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd=new SqlCommand();
            if (!(txt_sifre.Text is null && txt_sifre.Text.Equals("") || txt_tcno.Text is null && txt_tcno.Text.Equals("") && txt_tcno.Text.Equals(" ")))
            {
                kimliknoKontrol(txt_tcno.Text);
                if(!returnvalue)
                {
                    MessageBox.Show("L�tfen kimlik numaran�z� giriniz.");
                }
                else
                {
                        Uyeler uyeler = new Uyeler();
                    cmd.CommandText = ("Select * from uyeler,yetki where uyeler.yetki_id=yetki.id");
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dr;
                    conn.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        uyeler._sifre = (string)dr["sifre"];
                        uyeler._Tcno = (long)dr["tc_no"];
                        uyeler._yetki = (bool)dr["yetki"];

                    }
                    conn.Close();
                    if (txt_sifre.Text == uyeler._sifre || txt_tcno.Text == uyeler._Tcno.ToString())
                    {
                        MessageBox.Show("Login");
                        if (uyeler._yetki == false)
                        {
                            userPanel userPanel = new userPanel();
                            userPanel.Show();

                        }
                        else
                        {
                            adminPanel adminPanel = new adminPanel();
                            adminPanel.Show();

                        }
                    }
                    else
                    {
                        MessageBox.Show("TC kimlik numaras� ya da �ifre yanl��....");
                    }
                }
            }
            else
            {
                MessageBox.Show("L�tfen bo�luk ya da bo� b�rakmay�n�z.");
            }
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
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
