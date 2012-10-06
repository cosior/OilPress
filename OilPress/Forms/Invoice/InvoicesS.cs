using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilPress
{
    public partial class InvoicesS : Form
    {
        private Boolean invoiceAdded;

        public InvoicesS()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            invoiceAdded = true;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            invoiceAdded = false;
            Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            invoiceAdded = true;
        }

        public Boolean GetInvoiceState
        {
            get { return invoiceAdded; }
        }
    }
}
