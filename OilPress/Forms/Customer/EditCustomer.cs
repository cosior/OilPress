using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilPress
{
    public partial class EditCustomer : Form
    {
        private Boolean editCustomerOk;

        public EditCustomer()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox6.Text = "Πελάτης Ανευρέθηκε. Αλλάξετε τα πεδία επιλογής σας και πιέστε \"ΟΚ\" ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            editCustomerOk = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            editCustomerOk = false;
            this.Close();
        }

        public Boolean GetEditCustomerStatus
        {
            get { return editCustomerOk; }
        }
    }
}
