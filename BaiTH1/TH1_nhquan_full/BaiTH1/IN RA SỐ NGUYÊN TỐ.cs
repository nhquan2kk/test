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
    public partial class IN_RA_SỐ_NGUYÊN_TỐ : Form
    {
        public IN_RA_SỐ_NGUYÊN_TỐ()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int n;
        public static bool SNT(int n)
        {
            for(int i=2;i<=n/2;i++)
                if(n%i==0)
                    return false;
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(textBox1.Text);
            string kq =" ";
            for(int i=1;i<=n;i++)
                if(SNT(i))
                    kq=kq+i.ToString()+" ";
            richTextBox1.Text= kq;
        }
    }
}
