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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

         private void pictureBox2_Click(object sender, EventArgs e)
        {
           
            string email = Form3.C.ToString(); 

            string password = textBox2.Text;
            if (textBox1.Text == password)
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-ELP0PA5\\SQLEXPRESS;Initial Catalog=HalBinası;Integrated Security=True"))
                {
                    connection.Open();

                    using (SqlCommand guncel = new SqlCommand("UPDATE Giris_Tablosu SET Sifre=@p1 WHERE Kullanici_adi=@adı", connection))
                    {

                        guncel.Parameters.AddWithValue("@adı", email);
                        guncel.Parameters.AddWithValue("@p1", password);
                        guncel.ExecuteNonQuery();

                        MessageBox.Show("Şifre Başarılı Şekilde Değiştirilmiştir");
                        this.Hide();
                        GirisPanelii frm = new GirisPanelii();
                        frm.Show();

                    }
                }
            }
            else
            {
                MessageBox.Show("Şifreler Uyuşmuyor");
            }
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GirisPanelii frm1 = new GirisPanelii();
            frm1.Show();
            this.Hide();
        }

       
    }
}
/*SqlCommand guncel = new SqlCommand("UPDATE Giris_Tablosu SET Sifre=@p1 WHERE Kullanici_adi=@adı", baglanti))
                        {
   
    guncel.Parameters.AddWithValue("@adı", email);
    guncel.Parameters.AddWithValue("@p1", password);
    guncel.EndExecuteNonQuery();*/