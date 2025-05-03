using Hal_Binası_Stok_Kontrol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hal_Binası_Stok_Kontrol
{
    public partial class Rapor : Form
    {
        public Rapor()
        {
            InitializeComponent();
        }

        private void Rapor_Load(object sender, EventArgs e)
        {
          
            
            // TODO: Bu kod satırı 'halBinasıDataSet3.Tbl_Fatura' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_FaturaTableAdapter.Fill(this.halBinasıDataSet3.Tbl_Fatura);
            label1.Text=$"TOPLAM KAYIT :{dataGridView1.RowCount}";
            label3.Text= $"TOPLAM KAZANÇ :{Satıs.RaporGidenTutar}";
        }
    }
}
