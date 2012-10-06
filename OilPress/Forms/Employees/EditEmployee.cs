using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilPress
{
    public partial class EditEmployee : Form
    {
        public EditEmployee()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox6.Text = "Υπάλληλος Ανευρέθηκε. Αλλάξετε τα πεδία επιλογής σας και πιέστε \"ΟΚ\" ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
