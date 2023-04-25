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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tính_CV_và_DT_tam_giác frmtamgiac = new Tính_CV_và_DT_tam_giác();
            frmtamgiac.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IN_RA_SỐ_NGUYÊN_TỐ frmSNT = new IN_RA_SỐ_NGUYÊN_TỐ();
            frmSNT.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PTBN2an frmPTBN2an=new PTBN2an();
            frmPTBN2an.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cac_phep_toan_tren_phan_so frmPhanso = new Cac_phep_toan_tren_phan_so();
            frmPhanso.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Calculator frmCalculator = new Calculator();
            frmCalculator.Show();
        }
    }
}
