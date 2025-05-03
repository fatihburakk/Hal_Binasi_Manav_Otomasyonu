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

namespace Hal_Binası_Stok_Kontrol
{
    public partial class KasaGrafik : Form
    {
        public KasaGrafik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-ELP0PA5\\SQLEXPRESS;Initial Catalog=HalBinası;Integrated Security=True");

        private void KasaGrafik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select KasaAdı,KalanAdet From Kasalar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {

                chart1.Series["Kasalarr"].Points.AddXY(oku[0].ToString(), Convert.ToInt32(oku[1]));
                chart1.Series["Kasalarr"].IsValueShownAsLabel = true;

            }

            baglanti.Close();
            baglanti.Open();
            SqlCommand kom = new SqlCommand("Select KasaAdı,KalanAdet From Kasalar", baglanti);
            SqlDataReader ok = komut.ExecuteReader();

            while (ok.Read())
            {

                chart2.Series["Kasa"].Points.AddXY(ok[0].ToString(), Convert.ToInt32(ok[1]));

            }


            baglanti.Close();
        }


        
    }
}
