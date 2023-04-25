using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTH1
{
    public partial class Tính_CV_và_DT_tam_giác : Form
    {
        public Tính_CV_và_DT_tam_giác()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDientich_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x1, y1, x2, y2, x3, y3;
            x1 = int.Parse(txtx1.Text);
            y1 = int.Parse(txty1.Text);
            x2 = int.Parse(txtx2.Text);
            y2 = int.Parse(txty2.Text);
            x3 = int.Parse(txtx3.Text);
            y3 = int.Parse(txty3.Text);
            double C, S, AB, AC,BC;
            AB = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            AC = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
            BC = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            C = AB+AC+BC;
            txtChuvi.Text = C.ToString();
            S = (0.5) * (Math.Abs(((x2 - x1) * (y3 - y1)) - ((x3 - x1) * (y2 - y1)) ) );
            txtDientich.Text = S.ToString();

        }
    }
}
