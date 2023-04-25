using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace check_lstbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //hoặc 
// clsbNhap.Items.AddRange(new string[] { chuỗi});
            clsbNhap.Items.Add("C++ Language");
            clsbNhap.Items.Add("C# Language");
            clsbNhap.Items.Add("Java Language");
            clsbNhap.Items.Add("Perl Language");
            clsbNhap.Items.Add("Vb.Net");
            
          



        }

        private void clsbNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnChuyen_Click(object sender, EventArgs e)
            
        {
            for (int i = 0; i < clsbNhap.Items.Count; i++)
            {
                if (clsbNhap.GetItemChecked(i))
                {
                    lstXuat.Items.Add(clsbNhap.Items[i]);
                }

            }

        }
    }
}
