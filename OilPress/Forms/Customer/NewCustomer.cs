using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilPress
{
    public partial class NewCustomer : Form
    {
        #region Variables
        static int customerid = 20110001;
        private Boolean newCustomerAdded;
        #endregion

        public NewCustomer()
        {
            InitializeComponent();
        }

        private void NewBook_Load(object sender, EventArgs e)
        {
            label7.Text = customerid++.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            newCustomerAdded = false;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newCustomerAdded = true;
            Close();
        }
        
        public bool GetCustomerStatus 
        {
            get { return newCustomerAdded; }
        }

    }
}
