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
    public partial class Cac_phep_toan_tren_phan_so : Form
    {
        public Cac_phep_toan_tren_phan_so()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        
        {
                int a1, b1, a2, b2;
                a1 = int.Parse(txt_ts1.Text);
                b1 = int.Parse(txt_ms1.Text);
                a2 = int.Parse(txt_ts2.Text);
                b2 = int.Parse(txt_ms2.Text);
            if (radioButton1.Checked)
            {
                
                txtketqua.Text = ((a1 * b2) + (b1 * a2)) + "/" + (b1 * b2);

            }
                if(radioButton2.Checked)
                {
                
                    txtketqua.Text = ((a1 * b2) - (b1 * a2))+ "/" +(b1 * b2); ;
                }
                if(radioButton3.Checked)
                {
                
                    txtketqua.Text = (a1 * a2) + "/" + (b1 * b2);
            }
                if(radioButton4.Checked)
                {
                
                    txtketqua.Text = (a1 * b2)+ "/" + (b1 * a2);
            }

        }
        
    
    }
}
