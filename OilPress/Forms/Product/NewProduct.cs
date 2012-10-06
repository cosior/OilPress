using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilPress
{
    public partial class NewProduct : Form
    {
        static int productid = 200010;

        public NewProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NewProduct_Load(object sender, EventArgs e)
        {
            label7.Text = productid++.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
