using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilPress
{
    public partial class InvoicesP : Form
    {
        public InvoicesP()
        {
            InitializeComponent();
        }

        private void InvoicesP_Load(object sender, EventArgs e)
        {
            //textName.Text = "XY ΕΛΑΙΟΤΡΙΒΕΙΑ ΛΤΔ";
            //textMob.Text = "99 123456";
            //textTel.Text = "24 123456";
            //textTK.Text = " 1234 ";
            //textAddress.Text = "Λεωφόρος Αρχ. Μακαριου Αρ.123, Πλάτρες";
            //comboArea.Text = "Λεμεσός";
            //comboCity.Text = "Λεμεσός";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
