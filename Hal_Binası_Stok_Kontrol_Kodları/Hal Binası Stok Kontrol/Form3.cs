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
using System.Net;
using System.Net.Mail;
using System.Windows.Controls;

namespace Hal_Binası_Stok_Kontrol
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-ELP0PA5\\SQLEXPRESS;Initial Catalog=HalBinası;Integrated Security=True");
        string to;
        string a;
       
     

        public static string C = "";
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            C = textBox1.Text;
            string from, pass, messagebody;
            Random rand = new Random();
            string randomcode;
            randomcode = (rand.Next(999999)).ToString();
            a = randomcode;
            MailMessage message = new MailMessage();
            to = (textBox1.Text).ToString();
            from = "mkayikci96@gmail.com";
            pass = "xfjd ukdy aocr zzrs";
            messagebody = $"Onay Kodunuz: {randomcode}";
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messagebody;
            message.Subject = "Şifre Yenileme Kodu";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Mail Adresinize Kod Gönderildi", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox2.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("E-posta Gönderilirken Hata Oluştu: " + ex.Message);
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GirisPanelii g = new GirisPanelii();
            g.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (a == textBox2.Text)
            {

                Form4 frm = new Form4();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış, Lütfen Doğrulama Kodunu Tekrar Giriniz..!");
            }
        }

      
    }
}
