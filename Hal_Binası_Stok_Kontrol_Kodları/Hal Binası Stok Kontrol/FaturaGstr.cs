using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media.Converters;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hal_Binası_Stok_Kontrol
{
    public partial class FaturaGstr : Form
    {
        public FaturaGstr()
        {
            InitializeComponent();
        }
        public void TemizleListBox()
        {
            listBox1.Items.Clear();
        }
        public void fatura()
        {

        }
        private void FaturaGstr_Load(object sender, EventArgs e)
        {
            
            label8.Text = Satıs.GidenTutar;


            string gidenBilgi1 = Satıs.GidenBilgi1;

            // GidenBilgi1 içindeki her öğeyi \n karakterine göre bölelim
            string[] gidenBilgi1Lines = gidenBilgi1.Split('\n');

            // ListBox'a her satırı ayrı bir öğe olarak ekle
            foreach (string line in gidenBilgi1Lines)
            {
                listBox1.Items.Add(line);
            }


            string gidenBilgi2 = Satıs.GidenBilgi2;

            // GidenBilgi1 içindeki her öğeyi \n karakterine göre bölelim
            string[] gidenBilgi2Lines = gidenBilgi2.Split('\n');

            // ListBox'a her satırı ayrı bir öğe olarak ekle
            foreach (string line in gidenBilgi2Lines)
            {
                listBox1.Items.Add(line);
            }


            string gidenBilgi3 = Satıs.GidenBilgi3;

            // GidenBilgi1 içindeki her öğeyi \n karakterine göre bölelim
            string[] gidenBilgi3Lines = gidenBilgi3.Split('\n');

            // ListBox'a her satırı ayrı bir öğe olarak ekle
            foreach (string line in gidenBilgi3Lines)
            {
                listBox1.Items.Add(line);
            }


        }

    
       
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
                listBox1.Items.RemoveAt(i);
            }
            label8.Text = "0";
            Satıs frm =new Satıs();
            frm.Show();
            this.Hide();
        }
    }
}
