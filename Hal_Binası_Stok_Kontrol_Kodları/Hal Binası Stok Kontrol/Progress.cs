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
    public partial class Progress : Form
    {
        public Progress()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if (panel2.Width >= 658 )
            {
                timer1.Stop();
                Form1 frm =new Form1();
                this.Hide();
                frm.Show();

            }
        }

       
    }
}
