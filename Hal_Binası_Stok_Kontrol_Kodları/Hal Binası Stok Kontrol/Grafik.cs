using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Wpf.Charts.Base;

namespace Hal_Binası_Stok_Kontrol
{
    public partial class Grafik : Form
    {
        public Grafik()
        {
            InitializeComponent();
        }
       
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-ELP0PA5\\SQLEXPRESS;Initial Catalog=HalBinası;Integrated Security=True");

        private void Grafik_Load(object sender, EventArgs e)
        {
          

            baglanti.Open();
              SqlCommand komut = new SqlCommand("Select Ürünler,KgFiyat From Ürünler", baglanti);
              SqlDataReader oku = komut.ExecuteReader();
            


                while (oku.Read())
                {
                    chart1.Series["ÜRÜNLER FİYAT"].Points.AddXY(  oku[0].ToString(), Convert.ToInt32(oku[1]));
                    chart3.Series["FİYAT"].Points.AddXY(oku[0].ToString(), Convert.ToInt32(oku[1]));
                    chart3.Series["FİYAT"].IsValueShownAsLabel = true;
                chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                }

                baglanti.Close();
                baglanti.Open();
                SqlCommand kom = new SqlCommand("Select Ürünler,StokKg From Ürünler", baglanti);
                SqlDataReader ok = kom.ExecuteReader();


                while (ok.Read())
                {
                    chart2.Series["ÜRÜNLER STOK"].Points.AddXY(ok[0].ToString(), Convert.ToInt32(ok[1]));
                    chart4.Series["STOK"].Points.AddXY(ok[0].ToString(), Convert.ToInt32(ok[1]));
             //     chart4.Series["STOK"].IsValueShownAsLabel = true;
                chart2.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                }
                baglanti.Close();          
        
        
        
        }

       
    }
}
