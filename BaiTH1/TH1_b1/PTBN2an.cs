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
    public partial class PTBN2an : Form
    {
        public PTBN2an()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a1 = int.Parse(textBox1.Text);
            int b1 = int.Parse(textBox2.Text);
            int c1 = int.Parse(textBox3.Text);
            int a2 = int.Parse(textBox4.Text);
            int b2 = int.Parse(textBox5.Text);
            int c2 = int.Parse(textBox6.Text);
            float D, Dx, Dy, x, y;
            D = a1 * b2 - a2 * b1;
            Dx = c1 * b2 - c2 * b1;
            Dy = a1 * c2 - a2 * c1;
            if (D == 0)
            {
                if (Dx + Dy == 0)
                    MessageBox.Show("He phuong trinh co vo so nghiem");
                else
                    MessageBox.Show("He phuong trinh vo nghiem");
            }
            else
            {
                x = Dx / D;
                y = Dy / D;
                textBox7.Text = x.ToString() + " " + y.ToString();
            }
        }

    }
}
