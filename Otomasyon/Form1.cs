using Otomasyon;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (!(txt_sifre.Text is null && txt_sifre.Text.Equals("") || txt_tcno.Text is null && txt_tcno.Text.Equals("") && txt_tcno.Text.Equals(" ")))
            {
                Uyeler uyeler = new Uyeler();
                String sifre = txt_sifre.Text;
                int tcno;
                if (!(int.TryParse(txt_tcno.Text, out tcno)))
                {
                    MessageBox.Show("L�tfen kimlik numaran�z� giriniz.");
                }
                else
                {

                    if (txt_sifre.Text == uyeler._sifre || tcno == uyeler._Tcno)
                    {
                        MessageBox.Show("Login");
                        if (uyeler._yetki == 0)
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
    }
}
