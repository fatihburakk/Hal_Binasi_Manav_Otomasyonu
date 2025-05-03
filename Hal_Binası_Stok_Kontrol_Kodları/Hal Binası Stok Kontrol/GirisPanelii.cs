using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hal_Binası_Stok_Kontrol
{
    public partial class GirisPanelii : Form
    {
        public GirisPanelii()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-ELP0PA5\\SQLEXPRESS;Initial Catalog=HalBinası;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand();
            
            cmd.Connection = baglanti;
            cmd.CommandText = "SELECT * FROM Giris_Tablosu where Kullanici_Adi='" + textBox1.Text + "' AND Sifre='" + textBox2.Text + "'";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.Hide();
                Progress frm = new Progress();
                frm.Show();
                this.Hide();
               

            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }
            baglanti.Close();
        }
       
      

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Kaydol FRM = new Kaydol();
            FRM.Show();
        }
    }
}
