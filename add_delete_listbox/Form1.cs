using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace add_delete_listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // lấy string trong text rồi đưa ra
            string lst1 = txtNhap.Text.Trim();
            lstXuat.Items.Add(lst1);

        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                lstXuat.Items.RemoveAt(lstXuat.SelectedIndices[0]);
        }
    }
}
