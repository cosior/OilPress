﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilPress
{
    public partial class CancelSalesInvoice : Form
    {
        private Boolean cancelOk;

        public CancelSalesInvoice()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CancelSalesInvoice_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cancelOk = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cancelOk = false;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cancelOk = true;
            this.Close();
        }

        public Boolean GetCancelStatus
        {
            get { return cancelOk; }
        }
    }
}
