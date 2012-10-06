using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilPress
{
    public partial class DeleteCustomer : Form
    {
        public Boolean deleteCustomerOk;

        public DeleteCustomer()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox6.Text = "Πελάτης Ανευρέθηκε. Πιέστε \"ΟΚ\" για διαγραφή Πελάτη!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deleteCustomerOk = false;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deleteCustomerOk = true;
            this.Close();
        }

        public Boolean GetDeleteCustomerStatus
        {
            get { return deleteCustomerOk; }
        }
    }
}
