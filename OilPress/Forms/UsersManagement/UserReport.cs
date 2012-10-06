using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilPress
{
    public partial class UserReport : Form
    {
        public UserReport()
        {
            InitializeComponent();
        }

        private void UserReport_Load(object sender, EventArgs e)
        {
            FileHandler filehandler = new FileHandler("users.bin");
            String[] tempdate = new String[(filehandler.countFile()) * 2];
            tempdate = filehandler.GetUsers();
            String[] temp = new String[2];
            DataGridViewRowCollection rows = this.dataGridView1.Rows;

            int j = 0;
            for (int i = 0; i < tempdate.Length/2; i++)
			{
                temp[0] = tempdate[i + j];
                temp[1] = "    ********";
                rows.Add(temp);
                j++;
			}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
