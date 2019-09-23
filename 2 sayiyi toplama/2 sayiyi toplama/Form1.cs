using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_sayiyi_toplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void LogYaz(string mesaj)
        {
            
        }

        void EkranHazirla()
        {
            txtboxBirinciSayi.Text = "0";
            txtboxİkinciSayi.Text = "0";
            txtboxBirinciSayi.Focus();
        }

        int Topla(int sayi1, int sayi2)
        {
            return (sayi1 + sayi2);
        }

        Boolean Dogrula()
        {
           
            try
            {
                Convert.ToInt32(txtboxBirinciSayi.Text);
                Convert.ToInt32(txtboxİkinciSayi.Text);
            }
            catch (Exception)
            {
                return false;
                
            }
            return true;
        }

        private void btnToplama_Click(object sender, EventArgs e)
        {
            int birincisayi, ikincisayi, toplam;

            if (Dogrula())
            {
                birincisayi = Convert.ToInt32(txtboxBirinciSayi.Text);
                ikincisayi = Convert.ToInt32(txtboxİkinciSayi.Text);
                toplam = Topla(birincisayi, ikincisayi);
                MessageBox.Show("Toplam = " + toplam);
                EkranHazirla();
            } 
            else
            {
                MessageBox.Show("Hatalı Giriş!");
            }

         
        }


        private void Form1_Shown(object sender, EventArgs e)
        {
            EkranHazirla();
        }
      

        private void txtboxBirinciSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
               char.IsLetter(e.KeyChar) ||
               char.IsSymbol(e.KeyChar) ||
               char.IsWhiteSpace(e.KeyChar) ||
               char.IsPunctuation(e.KeyChar)
               )
                e.Handled = true;
        }

        private void txtboxİkinciSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
               char.IsLetter(e.KeyChar) ||
               char.IsSymbol(e.KeyChar) ||
               char.IsWhiteSpace(e.KeyChar) ||
               char.IsPunctuation(e.KeyChar)
               )
                e.Handled = true;
        }
    }
}
