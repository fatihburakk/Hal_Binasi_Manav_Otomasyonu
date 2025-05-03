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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Hal_Binası_Stok_Kontrol
{
    public partial class Kaydol : Form
    {
        public Kaydol()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Lütfen Tüm Bilgileri Giriniz..! ");
            }
            else
            {
                if (textBox2.Text == textBox3.Text)
                {
                    using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-ELP0PA5\\SQLEXPRESS;Initial Catalog=HalBinası;Integrated Security=True"))
                    {
                        connection.Open();

                        using (SqlCommand guncel = new SqlCommand("INSERT INTO Giris_Tablosu (Kullanici_adi, Sifre) VALUES (@kullaniciAdi, @sifre)", connection))
                        {

                            guncel.Parameters.AddWithValue("@kullaniciAdi", textBox1.Text);
                            guncel.Parameters.AddWithValue("@sifre", textBox2.Text);
                            guncel.ExecuteNonQuery();
                            MessageBox.Show("Başarılı Bir Şekilde Kayıt Oluşturulmuştur ..!");
                            this.Hide();
                        }
                        connection.Close();
                    }
                }

                else if (textBox2.Text != textBox3.Text)
                {
                    MessageBox.Show("Şifreler Birbiriyle Uyuşmuyor, Lütfen Tekrar Giriniz..!");
                }
            }
        }
    }

}
