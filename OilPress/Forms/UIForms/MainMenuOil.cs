using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilPress.Forms.UIForms
{
    public partial class MainMenuOil : Form
    {
        public MainMenuOil()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NewCustomer nc = new NewCustomer();
            nc.MdiParent = this.ParentForm;
            nc.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SubLogin slogin = new SubLogin();
            slogin.MdiParent = this.ParentForm;
            slogin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TempReceipt treceipt = new TempReceipt();
            treceipt.MdiParent = this.ParentForm;
            treceipt.Show();
        }
    }
}
